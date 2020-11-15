using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoProjectEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  textBoxMapname.Enabled = false;
            maptheme.Enabled = false;
            mapstate.Enabled = false;
            mapPOSX.Enabled = false;
            mapPOSY.Enabled = false;
          
        }


        private void showMapName(string name)
        {
            MessageBox.Show(name,"Info");
        }

        private string convertByteToString(byte[] data)
        {
            string result = Encoding.GetEncoding("euc-kr").GetString(data);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Go Project File|*.prj";
            openFileDialog1.Title = "Select a Project File";
         
            //InitDone = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;

                label3.Text = filename;
                

                using (BinaryReader bin = new BinaryReader(File.Open(label3.Text, FileMode.Open)))
                {
                    var stream = bin.BaseStream;
                    var mapname = convertByteToString(bin.ReadBytes(0X50));
                    bin.ReadInt32();
                    int mapTheme = bin.ReadInt32();
                    int mapState = bin.ReadInt32();
                    bin.ReadInt32();
                    
                    textBoxMapname.Text = mapname;
                    maptheme.Text = mapTheme.ToString();
                    mapstate.Text = mapState.ToString();

                    var mapBgFile = convertByteToString(bin.ReadBytes(0X80));
                    showMapName("Bg File: " + mapBgFile);
                    textBoxBackgroundFile.Text = mapBgFile;
                    bin.ReadBytes(0X6D);
                    //s

                    label4.Text = "Current_Read_Pos: " + stream.Position;

                }
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mapPOSX_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
