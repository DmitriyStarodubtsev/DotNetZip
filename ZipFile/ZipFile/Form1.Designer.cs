namespace ZipFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.btnFileName = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder: ";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(78, 31);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(265, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(349, 31);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(29, 20);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(405, 31);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(75, 20);
            this.btnZipFolder.TabIndex = 3;
            this.btnZipFolder.Text = "Zip";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            // 
            // btnZipFile
            // 
            this.btnZipFile.Location = new System.Drawing.Point(405, 57);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(75, 20);
            this.btnZipFile.TabIndex = 7;
            this.btnZipFile.Text = "Zip";
            this.btnZipFile.UseVisualStyleBackColor = true;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(349, 57);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(29, 20);
            this.btnFileName.TabIndex = 6;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(78, 57);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(265, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(78, 83);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(265, 23);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 129);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnZipFile;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

