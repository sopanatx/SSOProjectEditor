﻿namespace ProjectEditor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CurrentEditLabel = new System.Windows.Forms.Label();
            this.MapFileLabel = new System.Windows.Forms.Label();
            this.MapFile = new System.Windows.Forms.TextBox();
            this.TileLabel = new System.Windows.Forms.Label();
            this.TileFile = new System.Windows.Forms.TextBox();
            this.LinkMapBtn = new System.Windows.Forms.Button();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.BackgroundFile = new System.Windows.Forms.TextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.RegionMap = new System.Windows.Forms.TextBox();
            this.ThemeMap = new System.Windows.Forms.TextBox();
            this.LoadPrjBtn = new System.Windows.Forms.Button();
            this.MapName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SprResourceCountLabel = new System.Windows.Forms.Label();
            this.MotResourceCountLabel = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Controls.Add(this.MotResourceCountLabel);
            this.tabPage1.Controls.Add(this.SprResourceCountLabel);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.CurrentEditLabel);
            this.tabPage1.Controls.Add(this.MapFileLabel);
            this.tabPage1.Controls.Add(this.MapFile);
            this.tabPage1.Controls.Add(this.TileLabel);
            this.tabPage1.Controls.Add(this.TileFile);
            this.tabPage1.Controls.Add(this.LinkMapBtn);
            this.tabPage1.Controls.Add(this.BackgroundLabel);
            this.tabPage1.Controls.Add(this.BackgroundFile);
            this.tabPage1.Controls.Add(this.RegionLabel);
            this.tabPage1.Controls.Add(this.ThemeLabel);
            this.tabPage1.Controls.Add(this.MapNameLabel);
            this.tabPage1.Controls.Add(this.RegionMap);
            this.tabPage1.Controls.Add(this.ThemeMap);
            this.tabPage1.Controls.Add(this.LoadPrjBtn);
            this.tabPage1.Controls.Add(this.MapName);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map Info & Resource";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CurrentEditLabel
            // 
            this.CurrentEditLabel.AutoSize = true;
            this.CurrentEditLabel.Location = new System.Drawing.Point(140, 529);
            this.CurrentEditLabel.Name = "CurrentEditLabel";
            this.CurrentEditLabel.Size = new System.Drawing.Size(94, 13);
            this.CurrentEditLabel.TabIndex = 34;
            this.CurrentEditLabel.Text = "Current Editing: ....";
            // 
            // MapFileLabel
            // 
            this.MapFileLabel.AutoSize = true;
            this.MapFileLabel.Location = new System.Drawing.Point(211, 164);
            this.MapFileLabel.Name = "MapFileLabel";
            this.MapFileLabel.Size = new System.Drawing.Size(53, 13);
            this.MapFileLabel.TabIndex = 33;
            this.MapFileLabel.Text = "Map File: ";
            // 
            // MapFile
            // 
            this.MapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapFile.Location = new System.Drawing.Point(214, 180);
            this.MapFile.Name = "MapFile";
            this.MapFile.Size = new System.Drawing.Size(264, 20);
            this.MapFile.TabIndex = 32;
            // 
            // TileLabel
            // 
            this.TileLabel.AutoSize = true;
            this.TileLabel.Location = new System.Drawing.Point(211, 121);
            this.TileLabel.Name = "TileLabel";
            this.TileLabel.Size = new System.Drawing.Size(49, 13);
            this.TileLabel.TabIndex = 31;
            this.TileLabel.Text = "Tile File :";
            // 
            // TileFile
            // 
            this.TileFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileFile.Location = new System.Drawing.Point(214, 137);
            this.TileFile.Name = "TileFile";
            this.TileFile.Size = new System.Drawing.Size(264, 20);
            this.TileFile.TabIndex = 30;
            // 
            // LinkMapBtn
            // 
            this.LinkMapBtn.Enabled = false;
            this.LinkMapBtn.Location = new System.Drawing.Point(910, 16);
            this.LinkMapBtn.Name = "LinkMapBtn";
            this.LinkMapBtn.Size = new System.Drawing.Size(87, 30);
            this.LinkMapBtn.TabIndex = 29;
            this.LinkMapBtn.Text = "Link Map File..";
            this.LinkMapBtn.UseVisualStyleBackColor = true;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(211, 77);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(90, 13);
            this.BackgroundLabel.TabIndex = 28;
            this.BackgroundLabel.Text = "Background File :";
            // 
            // BackgroundFile
            // 
            this.BackgroundFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundFile.Location = new System.Drawing.Point(214, 93);
            this.BackgroundFile.Name = "BackgroundFile";
            this.BackgroundFile.Size = new System.Drawing.Size(264, 20);
            this.BackgroundFile.TabIndex = 27;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(275, 6);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(47, 13);
            this.RegionLabel.TabIndex = 26;
            this.RegionLabel.Text = "Region: ";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(140, 6);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(43, 13);
            this.ThemeLabel.TabIndex = 25;
            this.ThemeLabel.Text = "Theme:";
            // 
            // MapNameLabel
            // 
            this.MapNameLabel.AutoSize = true;
            this.MapNameLabel.Location = new System.Drawing.Point(8, 6);
            this.MapNameLabel.Name = "MapNameLabel";
            this.MapNameLabel.Size = new System.Drawing.Size(59, 13);
            this.MapNameLabel.TabIndex = 24;
            this.MapNameLabel.Text = "Map Name";
            // 
            // RegionMap
            // 
            this.RegionMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionMap.Location = new System.Drawing.Point(278, 22);
            this.RegionMap.Name = "RegionMap";
            this.RegionMap.Size = new System.Drawing.Size(129, 24);
            this.RegionMap.TabIndex = 23;
            // 
            // ThemeMap
            // 
            this.ThemeMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeMap.Location = new System.Drawing.Point(143, 22);
            this.ThemeMap.Name = "ThemeMap";
            this.ThemeMap.Size = new System.Drawing.Size(129, 24);
            this.ThemeMap.TabIndex = 22;
            // 
            // LoadPrjBtn
            // 
            this.LoadPrjBtn.Location = new System.Drawing.Point(8, 519);
            this.LoadPrjBtn.Name = "LoadPrjBtn";
            this.LoadPrjBtn.Size = new System.Drawing.Size(95, 33);
            this.LoadPrjBtn.TabIndex = 21;
            this.LoadPrjBtn.Text = "Load Project File";
            this.LoadPrjBtn.UseVisualStyleBackColor = true;
            this.LoadPrjBtn.Click += new System.EventHandler(this.LoadPrjBtn_Click);
            // 
            // MapName
            // 
            this.MapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapName.Location = new System.Drawing.Point(8, 22);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(129, 24);
            this.MapName.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 446);
            this.listBox1.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Portal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(214, 262);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 251);
            this.listBox2.TabIndex = 35;
            // 
            // SprResourceCountLabel
            // 
            this.SprResourceCountLabel.AutoSize = true;
            this.SprResourceCountLabel.Location = new System.Drawing.Point(219, 218);
            this.SprResourceCountLabel.Name = "SprResourceCountLabel";
            this.SprResourceCountLabel.Size = new System.Drawing.Size(109, 13);
            this.SprResourceCountLabel.TabIndex = 36;
            this.SprResourceCountLabel.Text = "Resource Spr Count: ";
            // 
            // MotResourceCountLabel
            // 
            this.MotResourceCountLabel.AutoSize = true;
            this.MotResourceCountLabel.Location = new System.Drawing.Point(219, 231);
            this.MotResourceCountLabel.Name = "MotResourceCountLabel";
            this.MotResourceCountLabel.Size = new System.Drawing.Size(111, 13);
            this.MotResourceCountLabel.TabIndex = 37;
            this.MotResourceCountLabel.Text = "Resource Mot Count: ";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(494, 262);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(264, 251);
            this.listBox3.TabIndex = 38;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 587);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label CurrentEditLabel;
        private System.Windows.Forms.Label MapFileLabel;
        private System.Windows.Forms.TextBox MapFile;
        private System.Windows.Forms.Label TileLabel;
        private System.Windows.Forms.TextBox TileFile;
        private System.Windows.Forms.Button LinkMapBtn;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.TextBox BackgroundFile;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Label MapNameLabel;
        private System.Windows.Forms.TextBox RegionMap;
        private System.Windows.Forms.TextBox ThemeMap;
        private System.Windows.Forms.Button LoadPrjBtn;
        private System.Windows.Forms.TextBox MapName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label SprResourceCountLabel;
        private System.Windows.Forms.Label MotResourceCountLabel;
        private System.Windows.Forms.ListBox listBox3;
    }
}

