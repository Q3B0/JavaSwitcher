namespace JavaSwitcher
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
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(112, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(28, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 17);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "选择JDK目录";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 61);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(430, 25);
            button1.Name = "button1";
            button1.Size = new Size(78, 23);
            button1.TabIndex = 4;
            button1.Text = "切换";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 100);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Java版本切换";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}