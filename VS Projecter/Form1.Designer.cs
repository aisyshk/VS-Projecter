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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label2 = new Label();
            label3 = new Label();
            BTN_SelectFolder = new Button();
            label4 = new Label();
            BTN_MakeProjBtn = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(147, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 29);
            textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Initialize Git Repo?";
            checkBox1.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(152, 73);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 7;
            label4.Text = "(Your VS Projects folder)";
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 529);
            Controls.Add(BTN_MakeProjBtn);
            Controls.Add(label4);
            Controls.Add(BTN_SelectFolder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "VS Projecter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Label label3;
        private Button BTN_SelectFolder;
        private Label label4;
        private Button BTN_MakeProjBtn;
    }
}