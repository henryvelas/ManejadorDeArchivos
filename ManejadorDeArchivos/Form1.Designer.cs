namespace ManejadorDeArchivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboSystemDriver = new System.Windows.Forms.ComboBox();
            this.txtSystemDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewDiretory = new System.Windows.Forms.TextBox();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnCreateSubDirectory = new System.Windows.Forms.Button();
            this.txtSubDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDirectoryFiles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowDirectoryFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopyDirectory = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSources = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntOpenFile = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnRenameFile = new System.Windows.Forms.Button();
            this.txtRenameFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSystemDriver
            // 
            this.cboSystemDriver.FormattingEnabled = true;
            this.cboSystemDriver.Location = new System.Drawing.Point(12, 26);
            this.cboSystemDriver.Name = "cboSystemDriver";
            this.cboSystemDriver.Size = new System.Drawing.Size(433, 28);
            this.cboSystemDriver.TabIndex = 0;
            this.cboSystemDriver.SelectedIndexChanged += new System.EventHandler(this.cboSystemDriver_SelectedIndexChanged);
            // 
            // txtSystemDetails
            // 
            this.txtSystemDetails.Location = new System.Drawing.Point(12, 77);
            this.txtSystemDetails.Multiline = true;
            this.txtSystemDetails.Name = "txtSystemDetails";
            this.txtSystemDetails.Size = new System.Drawing.Size(433, 378);
            this.txtSystemDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(476, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Directory (include path)";
            // 
            // txtNewDiretory
            // 
            this.txtNewDiretory.Location = new System.Drawing.Point(783, 27);
            this.txtNewDiretory.Name = "txtNewDiretory";
            this.txtNewDiretory.Size = new System.Drawing.Size(269, 27);
            this.txtNewDiretory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(1058, 26);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(173, 29);
            this.btnCreateDirectory.TabIndex = 4;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnCreateSubDirectory
            // 
            this.btnCreateSubDirectory.Location = new System.Drawing.Point(1058, 91);
            this.btnCreateSubDirectory.Name = "btnCreateSubDirectory";
            this.btnCreateSubDirectory.Size = new System.Drawing.Size(173, 29);
            this.btnCreateSubDirectory.TabIndex = 7;
            this.btnCreateSubDirectory.Text = "Create Sub-Directory";
            this.btnCreateSubDirectory.UseVisualStyleBackColor = true;
            this.btnCreateSubDirectory.Click += new System.EventHandler(this.btnCreateSubDirectory_Click);
            // 
            // txtSubDirectory
            // 
            this.txtSubDirectory.Location = new System.Drawing.Point(783, 92);
            this.txtSubDirectory.Name = "txtSubDirectory";
            this.txtSubDirectory.Size = new System.Drawing.Size(269, 27);
            this.txtSubDirectory.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(476, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Sub-Directory";
            // 
            // cboDirectoryFiles
            // 
            this.cboDirectoryFiles.FormattingEnabled = true;
            this.cboDirectoryFiles.Location = new System.Drawing.Point(783, 161);
            this.cboDirectoryFiles.Name = "cboDirectoryFiles";
            this.cboDirectoryFiles.Size = new System.Drawing.Size(269, 28);
            this.cboDirectoryFiles.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(476, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Show Directory Details";
            // 
            // btnShowDirectoryFiles
            // 
            this.btnShowDirectoryFiles.Location = new System.Drawing.Point(1058, 160);
            this.btnShowDirectoryFiles.Name = "btnShowDirectoryFiles";
            this.btnShowDirectoryFiles.Size = new System.Drawing.Size(173, 29);
            this.btnShowDirectoryFiles.TabIndex = 10;
            this.btnShowDirectoryFiles.Text = "Show Directory";
            this.btnShowDirectoryFiles.UseVisualStyleBackColor = true;
            this.btnShowDirectoryFiles.Click += new System.EventHandler(this.btnShowDirectoryFiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopyDirectory);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.txtSources);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(495, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 168);
            this.panel1.TabIndex = 11;
            // 
            // btnCopyDirectory
            // 
            this.btnCopyDirectory.Location = new System.Drawing.Point(520, 76);
            this.btnCopyDirectory.Name = "btnCopyDirectory";
            this.btnCopyDirectory.Size = new System.Drawing.Size(126, 70);
            this.btnCopyDirectory.TabIndex = 17;
            this.btnCopyDirectory.Text = "Copy";
            this.btnCopyDirectory.UseVisualStyleBackColor = true;
            this.btnCopyDirectory.Click += new System.EventHandler(this.btnCopyDirectory_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(162, 119);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(330, 27);
            this.txtDestination.TabIndex = 16;
            // 
            // txtSources
            // 
            this.txtSources.Location = new System.Drawing.Point(162, 78);
            this.txtSources.Name = "txtSources";
            this.txtSources.Size = new System.Drawing.Size(330, 27);
            this.txtSources.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Copy Directory";
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Location = new System.Drawing.Point(950, 425);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(173, 29);
            this.BtnCreateFile.TabIndex = 14;
            this.BtnCreateFile.Text = "Create File";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // txtNewFile
            // 
            this.txtNewFile.Location = new System.Drawing.Point(657, 427);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(269, 27);
            this.txtNewFile.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(518, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "New File";
            // 
            // bntOpenFile
            // 
            this.bntOpenFile.Location = new System.Drawing.Point(469, 482);
            this.bntOpenFile.Name = "bntOpenFile";
            this.bntOpenFile.Size = new System.Drawing.Size(173, 29);
            this.bntOpenFile.TabIndex = 17;
            this.bntOpenFile.Text = "Open";
            this.bntOpenFile.UseVisualStyleBackColor = true;
            this.bntOpenFile.Click += new System.EventHandler(this.bntOpenFile_Click);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(176, 484);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(269, 27);
            this.txtOpenFile.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Open File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnRenameFile
            // 
            this.BtnRenameFile.Location = new System.Drawing.Point(469, 541);
            this.BtnRenameFile.Name = "BtnRenameFile";
            this.BtnRenameFile.Size = new System.Drawing.Size(173, 29);
            this.BtnRenameFile.TabIndex = 20;
            this.BtnRenameFile.Text = "Rename";
            this.BtnRenameFile.UseVisualStyleBackColor = true;
            this.BtnRenameFile.Click += new System.EventHandler(this.BtnRenameFile_Click);
            // 
            // txtRenameFile
            // 
            this.txtRenameFile.Location = new System.Drawing.Point(176, 543);
            this.txtRenameFile.Name = "txtRenameFile";
            this.txtRenameFile.Size = new System.Drawing.Size(269, 27);
            this.txtRenameFile.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rename";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(37, 639);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(253, 160);
            this.txtWrite.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 805);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(37, 608);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Write";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(339, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Read";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 805);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(339, 639);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(253, 160);
            this.txtRead.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(636, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "Find";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 805);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 29);
            this.button3.TabIndex = 28;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(636, 639);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(253, 160);
            this.txtFind.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(934, 608);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "Update";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(934, 805);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 29);
            this.button4.TabIndex = 31;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(934, 639);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(253, 160);
            this.txtUpdate.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 881);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.BtnRenameFile);
            this.Controls.Add(this.txtRenameFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bntOpenFile);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCreateFile);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowDirectoryFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDirectoryFiles);
            this.Controls.Add(this.btnCreateSubDirectory);
            this.Controls.Add(this.txtSubDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.txtNewDiretory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSystemDetails);
            this.Controls.Add(this.cboSystemDriver);
            this.Name = "Form1";
            this.Text = " File Handeler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboSystemDriver;
        private TextBox txtSystemDetails;
        private Label label1;
        private TextBox txtNewDiretory;
        private Button btnCreateDirectory;
        private Button btnCreateSubDirectory;
        private TextBox txtSubDirectory;
        private Label label2;
        private ComboBox cboDirectoryFiles;
        private Label label3;
        private Button btnShowDirectoryFiles;
        private Panel panel1;
        private Button btnCopyDirectory;
        private TextBox txtDestination;
        private TextBox txtSources;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BtnCreateFile;
        private TextBox txtNewFile;
        private Label label7;
        private Button bntOpenFile;
        private TextBox txtOpenFile;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button BtnRenameFile;
        private TextBox txtRenameFile;
        private Label label9;
        private TextBox txtWrite;
        private Button button1;
        private Label label10;
        private Label label11;
        private Button button2;
        private TextBox txtRead;
        private Label label12;
        private Button button3;
        private TextBox txtFind;
        private Label label13;
        private Button button4;
        private TextBox txtUpdate;
    }
}