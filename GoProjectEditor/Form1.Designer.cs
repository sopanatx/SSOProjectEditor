
namespace GoProjectEditor
{
    partial class Form1
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
            this.groupMapInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mapstate = new System.Windows.Forms.TextBox();
            this.maptheme = new System.Windows.Forms.TextBox();
            this.textBoxMapname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MapName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mapPOSX = new System.Windows.Forms.TextBox();
            this.mapPOSY = new System.Windows.Forms.TextBox();
            this.textBoxBackgroundFile = new System.Windows.Forms.TextBox();
            this.bgFileLabel = new System.Windows.Forms.Label();
            this.groupMapInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMapInfo
            // 
            this.groupMapInfo.Controls.Add(this.bgFileLabel);
            this.groupMapInfo.Controls.Add(this.textBoxBackgroundFile);
            this.groupMapInfo.Controls.Add(this.mapPOSY);
            this.groupMapInfo.Controls.Add(this.mapPOSX);
            this.groupMapInfo.Controls.Add(this.label6);
            this.groupMapInfo.Controls.Add(this.label5);
            this.groupMapInfo.Controls.Add(this.labelInfo1);
            this.groupMapInfo.Controls.Add(this.label2);
            this.groupMapInfo.Controls.Add(this.mapstate);
            this.groupMapInfo.Controls.Add(this.maptheme);
            this.groupMapInfo.Controls.Add(this.textBoxMapname);
            this.groupMapInfo.Controls.Add(this.label1);
            this.groupMapInfo.Controls.Add(this.MapName);
            this.groupMapInfo.Location = new System.Drawing.Point(7, 7);
            this.groupMapInfo.Name = "groupMapInfo";
            this.groupMapInfo.Size = new System.Drawing.Size(346, 281);
            this.groupMapInfo.TabIndex = 0;
            this.groupMapInfo.TabStop = false;
            this.groupMapInfo.Text = "Map Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Map State (S) :";
            // 
            // mapstate
            // 
            this.mapstate.Location = new System.Drawing.Point(105, 94);
            this.mapstate.Name = "mapstate";
            this.mapstate.Size = new System.Drawing.Size(42, 20);
            this.mapstate.TabIndex = 4;
            // 
            // maptheme
            // 
            this.maptheme.Location = new System.Drawing.Point(105, 68);
            this.maptheme.Name = "maptheme";
            this.maptheme.Size = new System.Drawing.Size(42, 20);
            this.maptheme.TabIndex = 3;
            // 
            // textBoxMapname
            // 
            this.textBoxMapname.Location = new System.Drawing.Point(9, 45);
            this.textBoxMapname.Name = "textBoxMapname";
            this.textBoxMapname.Size = new System.Drawing.Size(172, 20);
            this.textBoxMapname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Theme (T) :";
            // 
            // MapName
            // 
            this.MapName.AutoSize = true;
            this.MapName.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapName.Location = new System.Drawing.Point(6, 29);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(71, 13);
            this.MapName.TabIndex = 0;
            this.MapName.Text = "Map Name : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filename:";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.ForeColor = System.Drawing.Color.Red;
            this.labelInfo1.Location = new System.Drawing.Point(74, 29);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(266, 13);
            this.labelInfo1.TabIndex = 6;
            this.labelInfo1.Text = "* Edit this map name will not effect in game. Map Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curr__Read_Position :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "POS (X) :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "POS (Y) :";
            // 
            // mapPOSX
            // 
            this.mapPOSX.Location = new System.Drawing.Point(70, 120);
            this.mapPOSX.Name = "mapPOSX";
            this.mapPOSX.Size = new System.Drawing.Size(45, 20);
            this.mapPOSX.TabIndex = 9;
            this.mapPOSX.TextChanged += new System.EventHandler(this.mapPOSX_TextChanged);
            // 
            // mapPOSY
            // 
            this.mapPOSY.Location = new System.Drawing.Point(186, 120);
            this.mapPOSY.Name = "mapPOSY";
            this.mapPOSY.Size = new System.Drawing.Size(45, 20);
            this.mapPOSY.TabIndex = 10;
            // 
            // textBoxBackgroundFile
            // 
            this.textBoxBackgroundFile.Location = new System.Drawing.Point(10, 198);
            this.textBoxBackgroundFile.Name = "textBoxBackgroundFile";
            this.textBoxBackgroundFile.Size = new System.Drawing.Size(172, 20);
            this.textBoxBackgroundFile.TabIndex = 11;
            // 
            // bgFileLabel
            // 
            this.bgFileLabel.AutoSize = true;
            this.bgFileLabel.Location = new System.Drawing.Point(7, 182);
            this.bgFileLabel.Name = "bgFileLabel";
            this.bgFileLabel.Size = new System.Drawing.Size(111, 13);
            this.bgFileLabel.TabIndex = 12;
            this.bgFileLabel.Text = "Map Background File:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupMapInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupMapInfo.ResumeLayout(false);
            this.groupMapInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMapInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mapstate;
        private System.Windows.Forms.TextBox maptheme;
        private System.Windows.Forms.TextBox textBoxMapname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MapName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mapPOSY;
        private System.Windows.Forms.TextBox mapPOSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bgFileLabel;
        private System.Windows.Forms.TextBox textBoxBackgroundFile;
    }
}

