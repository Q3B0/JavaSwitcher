using System.Diagnostics;

namespace JavaSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.label1.Text = "";
            this.label1.ForeColor = Color.Black;
            this.textBox1.Text = "";
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "ÇëÑ¡ÔñJDKÄ¿Â¼";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string jdkPath = folderBrowser.SelectedPath;
                if (CheckJava(jdkPath))
                {
                    this.textBox1.Text = folderBrowser.SelectedPath;
                }
                else
                {
                    this.label1.Text = "JDKÄ¿Â¼´íÎó";
                    this.label1.ForeColor = Color.Red;
                }

            }
        }

        private bool CheckJava(string path)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "java.exe";
                process.StartInfo.WorkingDirectory = $"{path}\\bin\\"; ;
                process.StartInfo.Arguments = " --version";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                return process.Start();
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string javaHomePath = this.textBox1.Text.Trim();
            Environment.SetEnvironmentVariable("JAVA_HOME", javaHomePath);
            Process.Start("cmd.exe", "/k set PATH=%JAVA_HOME%\\bin;%PATH%");
        }
    }
}