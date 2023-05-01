namespace VS_Projecter
{
    partial class MainWindow
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
            label1 = new Label();
            TEXT_ProjectName = new TextBox();
            CHK_MakeGit = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label2 = new Label();
            label3 = new Label();
            BTN_SelectFolder = new Button();
            label4 = new Label();
            BTN_MakeProjBtn = new Button();
            progressBar1 = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Project Name";
            // 
            // TEXT_ProjectName
            // 
            TEXT_ProjectName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TEXT_ProjectName.Location = new Point(147, 5);
            TEXT_ProjectName.Name = "TEXT_ProjectName";
            TEXT_ProjectName.Size = new Size(443, 29);
            TEXT_ProjectName.TabIndex = 1;
            TEXT_ProjectName.TextChanged += TEXT_ProjectName_TextChanged;
            // 
            // CHK_MakeGit
            // 
            CHK_MakeGit.AutoSize = true;
            CHK_MakeGit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CHK_MakeGit.Location = new Point(12, 101);
            CHK_MakeGit.Name = "CHK_MakeGit";
            CHK_MakeGit.Size = new Size(164, 25);
            CHK_MakeGit.TabIndex = 3;
            CHK_MakeGit.Text = "Initialize Git Repo?";
            CHK_MakeGit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 4;
            label2.Text = "Project Folder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 5;
            label3.Text = "(Your VS Projects folder)";
            // 
            // BTN_SelectFolder
            // 
            BTN_SelectFolder.Location = new Point(149, 48);
            BTN_SelectFolder.Name = "BTN_SelectFolder";
            BTN_SelectFolder.Size = new Size(91, 25);
            BTN_SelectFolder.TabIndex = 6;
            BTN_SelectFolder.Text = "Select Folder..";
            BTN_SelectFolder.UseVisualStyleBackColor = true;
            BTN_SelectFolder.Click += BTN_SelectFolder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 53);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // BTN_MakeProjBtn
            // 
            BTN_MakeProjBtn.Location = new Point(426, 121);
            BTN_MakeProjBtn.Name = "BTN_MakeProjBtn";
            BTN_MakeProjBtn.Size = new Size(164, 33);
            BTN_MakeProjBtn.TabIndex = 8;
            BTN_MakeProjBtn.Text = "Create Project";
            BTN_MakeProjBtn.UseVisualStyleBackColor = true;
            BTN_MakeProjBtn.Click += BTN_MakeProjBtn_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.RosyBrown;
            progressBar1.Location = new Point(7, 160);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(583, 23);
            progressBar1.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 191);
            Controls.Add(progressBar1);
            Controls.Add(BTN_MakeProjBtn);
            Controls.Add(label4);
            Controls.Add(BTN_SelectFolder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CHK_MakeGit);
            Controls.Add(TEXT_ProjectName);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "VS Projecter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TEXT_ProjectName;
        private CheckBox CHK_MakeGit;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Label label3;
        private Button BTN_SelectFolder;
        private Label label4;
        private Button BTN_MakeProjBtn;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}