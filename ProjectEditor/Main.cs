﻿using ProjectEditor.Utils;
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


                    //sub_96FFE0
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
                        Console.WriteLine(SprFile);
                        listBox1.Items.Insert(i, SprFile);
                    }

                    Project.MotCount = reader.ReadInt32();

                    for (int i = 0; i < Project.MotCount; i++)
                    {
                        string MotFile = "";
                        char ch2;
                        while ((int)(ch2 = reader.ReadChar()) != 0) MotFile = MotFile + ch2;
                        reader.ReadBytes(127 - MotFile.Length);// acc 128
                        Console.WriteLine(MotFile);
                        listBox2.Items.Insert(i, MotFile);
                    }
                    

               
                    reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    for (int i = 0; i < Project.MotCount; i++)
                    {
                        string MotTFile = "";
                        char ch3;
                        while ((int)(ch3 = reader.ReadChar()) != 0) MotTFile = MotTFile + ch3;
                        reader.ReadBytes(127 - MotTFile.Length);// acc 128
                        Console.WriteLine(MotTFile);
                        listBox3.Items.Insert(i, MotTFile);
                    }


                    MotResourceCountLabel.Text = "Mot Resource Count : " + Project.MotCount.ToString();
                    MotResourceCountLabel.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Failed to read file", "");
                }
            }
        }
    }
}
