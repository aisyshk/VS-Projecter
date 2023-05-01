using System.ComponentModel;
using System.Diagnostics;

namespace VS_Projecter
{
    public partial class MainWindow : Form
    {
        public string ProjectDirectory = "";

        public MainWindow()
        {
            InitializeComponent();

            BTN_SelectFolder.Enabled = false;
            BTN_MakeProjBtn.Enabled = false;
        }

        private void BTN_SelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            ProjectDirectory = $"{folderBrowserDialog1.SelectedPath}\\{TEXT_ProjectName.Text}";
            label4.Text = ProjectDirectory;

            BTN_MakeProjBtn.Enabled = true;
        }

        private void BTN_MakeProjBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            MessageBox.Show($"Repository Created.");
        }

        private void TEXT_ProjectName_TextChanged(object sender, EventArgs e)
        {
            if (TEXT_ProjectName.Text.Length <= 0)
                BTN_SelectFolder.Enabled = false;

            BTN_SelectFolder.Enabled = true;
        }

        private async void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;

            try
            {
                for (int i = 0; i < 100000; i++)
                {
                    await Task.Run(async () =>
                    {
                        Directory.CreateDirectory(ProjectDirectory);
                        Directory.CreateDirectory($"{ProjectDirectory}\\src");

                        if (CHK_MakeGit.Checked)
                        {
                            Process process = new();
                            ProcessStartInfo StartInfo = new ProcessStartInfo();

                            StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            StartInfo.FileName = "cmd.exe";
                            StartInfo.Arguments = $"/C cd {ProjectDirectory} && git init";

                            process.StartInfo = StartInfo;
                            process.Start();
                        }

                        var file = File.Create($"{ProjectDirectory}\\README.md");
                        using (StreamWriter writer = new StreamWriter(file))
                        {
                            writer.WriteLine($"# {TEXT_ProjectName.Text}");
                            writer.WriteLine($"");
                            writer.WriteLine($"");
                            writer.WriteLine($"This is an auto-generated README file.");
                            writer.WriteLine($"");
                            writer.WriteLine($"Change the contents to fit your repository!");
                        }
                    });

                    backgroundWorker.ReportProgress(-1, (i * 100) / 100000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
#if DEBUG
                MessageBox.Show(ex.Message);
#else
                MessageBox.Show("Error occured.");
#endif
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}