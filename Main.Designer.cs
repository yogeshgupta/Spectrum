namespace spectrum
{
    partial class DD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DD));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BrwsBtn = new System.Windows.Forms.Button();
            this.brsTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.dwnldButton = new System.Windows.Forms.Button();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bse = new System.Windows.Forms.CheckBox();
            this.nse = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rCT1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSpectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Downloader";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.BrwsBtn);
            this.groupBox1.Controls.Add(this.brsTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.dwnldButton);
            this.groupBox1.Controls.Add(this.dTP2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dTP1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bse);
            this.groupBox1.Controls.Add(this.nse);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your file option";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(284, 103);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 17);
            this.checkBox6.TabIndex = 26;
            this.checkBox6.Text = "NCDEX";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(284, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 17);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.Text = "BSE FO";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(284, 31);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.Text = "NSE FO";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(284, 145);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 17);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Word Indices";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(51, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Word Currency";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(51, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "MCX";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BrwsBtn
            // 
            this.BrwsBtn.Location = new System.Drawing.Point(294, 261);
            this.BrwsBtn.Name = "BrwsBtn";
            this.BrwsBtn.Size = new System.Drawing.Size(75, 23);
            this.BrwsBtn.TabIndex = 20;
            this.BrwsBtn.Text = "Browse";
            this.BrwsBtn.UseVisualStyleBackColor = true;
            this.BrwsBtn.Click += new System.EventHandler(this.BrwsBtn_Click);
            // 
            // brsTB
            // 
            this.brsTB.Location = new System.Drawing.Point(66, 261);
            this.brsTB.Name = "brsTB";
            this.brsTB.Size = new System.Drawing.Size(201, 20);
            this.brsTB.TabIndex = 19;
            this.brsTB.TextChanged += new System.EventHandler(this.brsTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Save at:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(284, 181);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(110, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(294, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dwnldButton
            // 
            this.dwnldButton.Location = new System.Drawing.Point(36, 312);
            this.dwnldButton.Name = "dwnldButton";
            this.dwnldButton.Size = new System.Drawing.Size(75, 23);
            this.dwnldButton.TabIndex = 14;
            this.dwnldButton.Text = "Download";
            this.dwnldButton.UseVisualStyleBackColor = true;
            this.dwnldButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dTP2
            // 
            this.dTP2.Location = new System.Drawing.Point(67, 222);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(200, 20);
            this.dTP2.TabIndex = 13;
            this.dTP2.ValueChanged += new System.EventHandler(this.dTP2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "End Date:";
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(66, 184);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(200, 20);
            this.dTP1.TabIndex = 11;
            this.dTP1.Value = new System.DateTime(2011, 7, 8, 0, 0, 0, 0);
            this.dTP1.ValueChanged += new System.EventHandler(this.dTP1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Date:";
            // 
            // bse
            // 
            this.bse.AutoSize = true;
            this.bse.Location = new System.Drawing.Point(51, 64);
            this.bse.Name = "bse";
            this.bse.Size = new System.Drawing.Size(47, 17);
            this.bse.TabIndex = 2;
            this.bse.Text = "BSE";
            this.bse.UseVisualStyleBackColor = true;
            // 
            // nse
            // 
            this.nse.AutoSize = true;
            this.nse.Location = new System.Drawing.Point(51, 31);
            this.nse.Name = "nse";
            this.nse.Size = new System.Drawing.Size(48, 17);
            this.nse.TabIndex = 0;
            this.nse.Text = "NSE";
            this.nse.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rCT1
            // 
            this.rCT1.Location = new System.Drawing.Point(439, 64);
            this.rCT1.Name = "rCT1";
            this.rCT1.Size = new System.Drawing.Size(197, 328);
            this.rCT1.TabIndex = 2;
            this.rCT1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutUSToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeFile});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutUsToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeFile
            // 
            this.closeFile.Name = "closeFile";
            this.closeFile.Size = new System.Drawing.Size(103, 22);
            this.closeFile.Text = "Close";
            this.closeFile.Click += new System.EventHandler(this.closeFile_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aboutUSToolStripMenuItem1
            // 
            this.aboutUSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSpectrumToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
            this.aboutUSToolStripMenuItem1.Name = "aboutUSToolStripMenuItem1";
            this.aboutUSToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.aboutUSToolStripMenuItem1.Text = "Help";
            // 
            // aboutSpectrumToolStripMenuItem
            // 
            this.aboutSpectrumToolStripMenuItem.Name = "aboutSpectrumToolStripMenuItem";
            this.aboutSpectrumToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutSpectrumToolStripMenuItem.Text = "About Spectrum";
            this.aboutSpectrumToolStripMenuItem.Click += new System.EventHandler(this.aboutSpectrumToolStripMenuItem_Click);
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutAuthorToolStripMenuItem.Text = "About author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // DD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 425);
            this.Controls.Add(this.rCT1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DD";
            this.Text = " Spectrum V1.0";
            this.Load += new System.EventHandler(this.DD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox bse;
        private System.Windows.Forms.CheckBox nse;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button dwnldButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rCT1;
        private System.Windows.Forms.Button BrwsBtn;
        private System.Windows.Forms.TextBox brsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFile;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutSpectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

