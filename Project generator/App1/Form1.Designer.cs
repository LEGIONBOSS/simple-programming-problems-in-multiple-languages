namespace App1
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
            textBox_CommentStart = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            textBox_BoilerPlate = new TextBox();
            groupBox2 = new GroupBox();
            textBox_FileName = new TextBox();
            label4 = new Label();
            textBox_FileExtension = new TextBox();
            label2 = new Label();
            textBox_CommentEnd = new TextBox();
            label3 = new Label();
            label_ProjectFolder = new Label();
            button_ProjectFolder = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label_FolderNamesTxt = new Label();
            button_FolderNamesTxt = new Button();
            button_Generate = new Button();
            button_Cancel = new Button();
            label_Status = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_CommentStart
            // 
            textBox_CommentStart.Location = new Point(131, 51);
            textBox_CommentStart.Name = "textBox_CommentStart";
            textBox_CommentStart.Size = new Size(100, 23);
            textBox_CommentStart.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 3;
            label1.Text = "Comment block start";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox_BoilerPlate);
            groupBox3.Location = new Point(12, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(472, 260);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Boiler plate code";
            // 
            // textBox_BoilerPlate
            // 
            textBox_BoilerPlate.Location = new Point(6, 22);
            textBox_BoilerPlate.Multiline = true;
            textBox_BoilerPlate.Name = "textBox_BoilerPlate";
            textBox_BoilerPlate.ScrollBars = ScrollBars.Vertical;
            textBox_BoilerPlate.Size = new Size(448, 232);
            textBox_BoilerPlate.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox_FileName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_FileExtension);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_CommentEnd);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox_CommentStart);
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 92);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Code characters";
            // 
            // textBox_FileName
            // 
            textBox_FileName.Location = new Point(131, 22);
            textBox_FileName.Name = "textBox_FileName";
            textBox_FileName.Size = new Size(100, 23);
            textBox_FileName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 25);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 12;
            label4.Text = "File name";
            // 
            // textBox_FileExtension
            // 
            textBox_FileExtension.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_FileExtension.Location = new Point(366, 22);
            textBox_FileExtension.Name = "textBox_FileExtension";
            textBox_FileExtension.Size = new Size(100, 23);
            textBox_FileExtension.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(244, 54);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 6;
            label2.Text = "Comment block end";
            // 
            // textBox_CommentEnd
            // 
            textBox_CommentEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_CommentEnd.Location = new Point(366, 51);
            textBox_CommentEnd.Name = "textBox_CommentEnd";
            textBox_CommentEnd.Size = new Size(100, 23);
            textBox_CommentEnd.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(281, 25);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "File extension";
            // 
            // label_ProjectFolder
            // 
            label_ProjectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ProjectFolder.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label_ProjectFolder.ForeColor = Color.Blue;
            label_ProjectFolder.Location = new Point(6, 26);
            label_ProjectFolder.Name = "label_ProjectFolder";
            label_ProjectFolder.Size = new Size(379, 19);
            label_ProjectFolder.TabIndex = 0;
            label_ProjectFolder.Text = "Select the project folder";
            // 
            // button_ProjectFolder
            // 
            button_ProjectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ProjectFolder.Location = new Point(391, 22);
            button_ProjectFolder.Name = "button_ProjectFolder";
            button_ProjectFolder.Size = new Size(75, 23);
            button_ProjectFolder.TabIndex = 1;
            button_ProjectFolder.Text = "Select";
            button_ProjectFolder.UseVisualStyleBackColor = true;
            button_ProjectFolder.Click += button_ProjectFolder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button_ProjectFolder);
            groupBox1.Controls.Add(label_ProjectFolder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project location";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(label_FolderNamesTxt);
            groupBox4.Controls.Add(button_FolderNamesTxt);
            groupBox4.Location = new Point(12, 78);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(472, 60);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Folder names txt location";
            // 
            // label_FolderNamesTxt
            // 
            label_FolderNamesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_FolderNamesTxt.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label_FolderNamesTxt.ForeColor = Color.Blue;
            label_FolderNamesTxt.Location = new Point(6, 26);
            label_FolderNamesTxt.Name = "label_FolderNamesTxt";
            label_FolderNamesTxt.Size = new Size(379, 19);
            label_FolderNamesTxt.TabIndex = 2;
            label_FolderNamesTxt.Text = "Select the txt file";
            // 
            // button_FolderNamesTxt
            // 
            button_FolderNamesTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_FolderNamesTxt.Location = new Point(391, 22);
            button_FolderNamesTxt.Name = "button_FolderNamesTxt";
            button_FolderNamesTxt.Size = new Size(75, 23);
            button_FolderNamesTxt.TabIndex = 2;
            button_FolderNamesTxt.Text = "Select";
            button_FolderNamesTxt.UseVisualStyleBackColor = true;
            button_FolderNamesTxt.Click += button_FolderNamesTxt_Click;
            // 
            // button_Generate
            // 
            button_Generate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Generate.DialogResult = DialogResult.OK;
            button_Generate.Location = new Point(409, 513);
            button_Generate.Name = "button_Generate";
            button_Generate.Size = new Size(75, 23);
            button_Generate.TabIndex = 18;
            button_Generate.Text = "Generate";
            button_Generate.UseVisualStyleBackColor = true;
            button_Generate.Click += button_Generate_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(328, 513);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 7;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.ForeColor = Color.Red;
            label_Status.Location = new Point(12, 517);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(0, 15);
            label_Status.TabIndex = 8;
            // 
            // Form1
            // 
            AcceptButton = button_Generate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Cancel;
            ClientSize = new Size(496, 548);
            Controls.Add(label_Status);
            Controls.Add(button_Cancel);
            Controls.Add(button_Generate);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project folder generator";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_CommentStart;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label_ProjectFolder;
        private Button button_ProjectFolder;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label_FolderNamesTxt;
        private Button button_FolderNamesTxt;
        private TextBox textBox_BoilerPlate;
        private TextBox textBox_FileExtension;
        private Label label2;
        private TextBox textBox_CommentEnd;
        private Label label3;
        private Button button_Generate;
        private Button button_Cancel;
        private TextBox textBox_FileName;
        private Label label4;
        private Label label_Status;
    }
}
