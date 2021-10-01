using ProjectEditor.Utils;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CurrentEditLabel.Visible = false;
            SprResourceCountLabel.Visible = false;
            MotResourceCountLabel.Visible = false;
        }

        private void LoadPrjBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "GO Project File |*.prj",
                Title = "Select a Map Project File"
            };


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fullpath = openFileDialog1.FileName;
                string directoryPath = Path.GetDirectoryName(fullpath);
                string filename = Path.GetFileName(fullpath);

                ProjectHeader Project = new ProjectHeader();
                try
                {
                    string path = fullpath;
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fs, Encoding.GetEncoding("EUC-KR"));
                    ReadString str = new ReadString();
                    CurrentEditLabel.Visible = true;
                    CurrentEditLabel.Text = "Current Editing : " + filename;

                    str.FiersRead = reader.ReadBytes(0x50);
                    str.Decode();
                    reader.ReadInt32();
                    Project.MapName = str.Name;
                    Project.Theme = reader.ReadInt32();
                    Project.Region = reader.ReadInt32();
                    Project.MapType = reader.ReadInt32();


                    //sub_93CA40
                    str.FiersRead = reader.ReadBytes(0x80);
                    str.Decode();
                    Project.BackgroundFile = str.Name;



                    str.FiersRead = reader.ReadBytes(0x80);
                    str.Decode();
                    Project.TileFile = str.Name;

                    str.FiersRead = reader.ReadBytes(0x80);
                    str.Decode();
                    Project.MapFile = str.Name;

                    MapName.Text = Project.MapName;
                    ThemeMap.Text = Project.Theme.ToString();
                    RegionMap.Text = Project.Region.ToString();
                    BackgroundFile.Text = Project.BackgroundFile;
                    TileFile.Text = Project.TileFile;
                    MapFile.Text = Project.MapFile;

                    //////// OBJ
                    Project.ObjectCount = reader.ReadInt32();

                    SprResourceCountLabel.Text = "Spr Resource Count : " + Project.ObjectCount.ToString();
                    SprResourceCountLabel.Visible = true;
                    for (int i = 0; i < Project.ObjectCount; i++)
                    {
                        string SprFile = "";
                        char ch1;
                        while ((int)(ch1 = reader.ReadChar()) != 0) SprFile = SprFile + ch1;
                        reader.ReadBytes(127 - SprFile.Length);// acc 128
                                                               //      Console.WriteLine(SprFile);
                        listBox1.Items.Insert(i, SprFile);
                    }

                    Project.MotCount = reader.ReadInt32();

                    for (int i = 0; i < Project.MotCount; i++)
                    {
                        string MotFile = "";
                        char ch2;
                        while ((int)(ch2 = reader.ReadChar()) != 0) MotFile = MotFile + ch2;
                        reader.ReadBytes(127 - MotFile.Length);// acc 128
                                                               //  Console.WriteLine(MotFile);
                        listBox2.Items.Insert(i, MotFile);
                    }
                    MotResourceCountLabel.Text = "Mot Resource Count : " + Project.MotCount.ToString();
                    MotResourceCountLabel.Visible = true;





                    //==== sub_9702F0 ======== //
                    reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    string TilPOS = "";

                    char ch3;

                    while ((int)(ch3 = reader.ReadChar()) != 0) TilPOS = TilPOS + ch3;
                    reader.ReadBytes(127 - TilPOS.Length);// acc 128
                    listBox3.Items.Insert(0, TilPOS.ToString());


                    string MapPOS = "";
                    char ch4;
                    while ((int)(ch4 = reader.ReadChar()) != 0) MapPOS = MapPOS + ch4;
                    reader.ReadBytes(127 - MapPOS.Length);// acc 128
                    listBox3.Items.Insert(1, MapPOS.ToString());



                    reader.ReadInt32();

                    string BgPOS = "";
                    char ch5;
                    while ((int)(ch5 = reader.ReadChar()) != 0) BgPOS = BgPOS + ch5;
                    reader.ReadBytes(127 - BgPOS.Length);// acc 128
                    listBox3.Items.Insert(2, BgPOS.ToString());

                    // ======== sub_96FFB0
                    int strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {

                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();

                            reader.ReadBytes(0x10);
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            listBox4.Items.Insert(i, str.Name);

                        }
                    }

                    //======== sub_970110
                    strCount = reader.ReadInt32();

                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            Console.WriteLine("====== {0} ", i);
                            Console.WriteLine("Int 1 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 2 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 3 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 4 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("======");

                        }
                    }


                    ///============== sub_970710   Map Object
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();
                            Console.WriteLine("====== {0} ", i);

                            //   Console.WriteLine("Map OBJ 1 : {0}", str.Name);
                            listBox5.Items.Insert(i, str.Name);

                            Console.WriteLine("Int 1 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 2 : {0}", reader.ReadInt32().ToString());

                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();
                            // Console.WriteLine("Map OBJ 2 : {0}", str.Name);
                            listBox6.Items.Insert(i, str.Name);

                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();
                            listBox7.Items.Insert(i, str.Name);
                            //Console.WriteLine("Map OBJ 3 : {0}", str.Name);

                            Console.WriteLine("Int 3 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 4 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Int 5 : {0}", reader.ReadInt32().ToString());
                            Console.WriteLine("Byte 6 : {0}", reader.ReadByte().ToString());
                            Console.WriteLine("Byte 7 : {0}", reader.ReadBytes(0x14).ToString());
                            Console.WriteLine("======");
                        }
                    }

                    Console.WriteLine("====== Monster ======");
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {

                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();

                            listBox8.Items.Insert(i, str.Name);

                            int mv1 = reader.ReadInt32();
                            int mv2 = reader.ReadInt32();
                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();
                          
                            listBox9.Items.Insert(i, str.Name);

                            str.FiersRead = reader.ReadBytes(0x80);
                            str.Decode();
                            listBox10.Items.Insert(i, str.Name);



                            int mv3 = reader.ReadInt32();
                            int mv4 = reader.ReadInt32();
                            int mv5 = reader.ReadInt32();
                            int mv6 = reader.ReadInt32();
                            int mv7 = reader.ReadByte();
                            int mv8 = reader.ReadInt32();
                            int mv9 = reader.ReadInt32();
                            reader.ReadBytes(0x14);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to read file  " + ex.ToString(), "");
                }
            }
        }
    }
}
