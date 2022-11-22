namespace AdapterCompositePattern
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
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_FileSize = new System.Windows.Forms.Label();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.lbl_FolderSize = new System.Windows.Forms.Label();
            this.lbl_FolderPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectFile.Location = new System.Drawing.Point(12, 26);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 6;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.ForeColor = System.Drawing.Color.Black;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 67);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(63, 15);
            this.lbl_FileName.TabIndex = 7;
            this.lbl_FileName.Text = "FileName: ";
            // 
            // lbl_FileSize
            // 
            this.lbl_FileSize.AutoSize = true;
            this.lbl_FileSize.ForeColor = System.Drawing.Color.Black;
            this.lbl_FileSize.Location = new System.Drawing.Point(12, 92);
            this.lbl_FileSize.Name = "lbl_FileSize";
            this.lbl_FileSize.Size = new System.Drawing.Size(51, 15);
            this.lbl_FileSize.TabIndex = 8;
            this.lbl_FileSize.Text = "FileSize: ";
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectFolder.Location = new System.Drawing.Point(510, 26);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(88, 23);
            this.btn_SelectFolder.TabIndex = 9;
            this.btn_SelectFolder.Text = "Select Folder";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_FolderSize
            // 
            this.lbl_FolderSize.AutoSize = true;
            this.lbl_FolderSize.ForeColor = System.Drawing.Color.Black;
            this.lbl_FolderSize.Location = new System.Drawing.Point(510, 92);
            this.lbl_FolderSize.Name = "lbl_FolderSize";
            this.lbl_FolderSize.Size = new System.Drawing.Size(63, 15);
            this.lbl_FolderSize.TabIndex = 11;
            this.lbl_FolderSize.Text = "FolderSize:";
            // 
            // lbl_FolderPath
            // 
            this.lbl_FolderPath.AutoSize = true;
            this.lbl_FolderPath.ForeColor = System.Drawing.Color.Black;
            this.lbl_FolderPath.Location = new System.Drawing.Point(510, 67);
            this.lbl_FolderPath.Name = "lbl_FolderPath";
            this.lbl_FolderPath.Size = new System.Drawing.Size(67, 15);
            this.lbl_FolderPath.TabIndex = 10;
            this.lbl_FolderPath.Text = "FolderPath:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 158);
            this.Controls.Add(this.lbl_FolderSize);
            this.Controls.Add(this.lbl_FolderPath);
            this.Controls.Add(this.btn_SelectFolder);
            this.Controls.Add(this.lbl_FileSize);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_SelectFile);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SelectFile_Folderbtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btn_SelectFile;
        private Label lbl_FileName;
        private Label lbl_FileSize;
        private Button btn_SelectFolder;
        private Label lbl_FolderSize;
        private Label lbl_FolderPath;
    }
}