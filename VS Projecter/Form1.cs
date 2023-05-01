namespace VS_Projecter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_SelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label4.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BTN_MakeProjBtn_Click(object sender, EventArgs e)
        {

        }
    }
}