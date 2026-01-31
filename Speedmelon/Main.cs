using Speedmelon.util;

namespace Speedmelon
{
    public partial class Main : Form
    {

        private String MelonLoaderURL = "https://github.com/LavaGang/MelonLoader/releases/latest/download/MelonLoader.x64.zip";
        private String UnstrippedURL = "https://github.com/TimosCodd/Speedmelon/raw/refs/heads/main/Unstripped.zip";

        public Main()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Game Executable (*.exe)|*.exe";
            openFileDialog1.Title = "Select SpeedRunners 2.exe";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxGamePath.Text = openFileDialog1.FileName;
            }
        }
        private async void buttonInstall_Click(object sender, EventArgs e)
        {
            IProgress<string> progress = new Progress<string>(status => statusLabel.Text = status);

            if (textBoxGamePath.Text.EndsWith(".exe"))
            {
                String gameRootFolder = Path.GetDirectoryName(textBoxGamePath.Text)!;
                progress.Report("Downloading Unstripped DLLs");
                String managedPath = Path.Combine(gameRootFolder, "SpeedRunners 2_Data", "Managed");
                await DownloadManager.InstallPackage(UnstrippedURL, managedPath, progress);

                progress.Report("Downloading MelonLoader");
                await DownloadManager.InstallPackage(MelonLoaderURL, gameRootFolder, progress);

                statusLabel.ForeColor = Color.Green;
                progress.Report("Finished!");

            }
            else progress.Report("Error: No .exe selected");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void textBoxGamePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
