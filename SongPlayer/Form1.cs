using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.Flac;

namespace SongPlayer
{
    public partial class MainWindow : Form
    {
        
        FileSystem fileSystem = new FileSystem(); //Class der har med at skrive og læse til Json fil

        MediaController mediacontroller = new MediaController(); //Class der har med lyd filer 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aDiretoriesTing.Visible = false;
            //Checker om der er en Json fil
            fileSystem.FirstRead(fileSystem.JsonFilePath);

            //Loader alle sangene ind
            fileSystem.reload(fileSystem.JsonFilePath);

            //Updater Songbox
            mediacontroller.SongBoxUpdate(aSongBox, fileSystem);

            //Updater DirList
            fileSystem.UpdateDirList(aDiretoriesList);

            //Afspiller den første sang

            //mediacontroller.Doof();
            aSongNameLabel.Text = "Mit navn er Doof, i skal gøre hvad jeg siger ";


            mediacontroller.aPauseMusicButton = aPauseMusic;

            mediacontroller.imageList = imageList1;
        }

        //Afspiller en random sang
        private void aNextSongButton_Click(object sender, EventArgs e)
        {
            mediacontroller.StopMusic();

            mediacontroller.PlayMusic(fileSystem.JsonFilePath, fileSystem);

            aSongNameLabel.Text = fileSystem.wavNames[mediacontroller.tal] + " ";
            if (aVisualCheck.CheckState == CheckState.Checked) 
            {
                mediacontroller.RenderPNGvisual(aPicSong, fileSystem);
            }else 
            {
                aPicSong.Image = null;
            }
            
        }

        //Stopper musik
        private void aStopButton_Click(object sender, EventArgs e)
        {
            mediacontroller.StopMusic();
            aSongNameLabel.Text = "Musikken er stoppet ";
        }

        //Reloader alle Sange
        private void aReloadSongButton_Click(object sender, EventArgs e)
        {
            fileSystem.reload(fileSystem.JsonFilePath);
            mediacontroller.SongBoxUpdate(aSongBox,fileSystem);
        }

        //Afspiller den valgte sang
        private void aSongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediacontroller.StopMusic();
            mediacontroller.UserPlayMusic(aSongBox.SelectedIndex,fileSystem);
            aSongNameLabel.Text = fileSystem.wavNames[mediacontroller.tal] + " ";

            if (aVisualCheck.CheckState == CheckState.Checked)
            {
                mediacontroller.RenderPNGvisual(aPicSong, fileSystem);
            }
            else
            {
                aPicSong.Image = null;
            }
        }

        //Tilføjer et bibliotek (Mappe)
        private void aAddBibButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    fileSystem.UpdateFile(fbd.SelectedPath);

                    fileSystem.reload(fileSystem.JsonFilePath);
                    fileSystem.UpdateDirList(aDiretoriesList);
                    mediacontroller.SongBoxUpdate(aSongBox, fileSystem);
                }
            }

        }
        //Skifter til afspillings side
        private void aMusicButton_Click(object sender, EventArgs e)
        {
            aMusicTing.Visible = true;
            aDiretoriesTing.Visible = false;

        }
        //Skifter til bibliotek side
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            aMusicTing.Visible = false;
            aDiretoriesTing.Visible = true;
        }

        //Sletter bibliotek
        private void aDelectBibButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileSystem.delectPath(aDiretoriesList.SelectedIndex);
                fileSystem.reload(fileSystem.JsonFilePath);
                fileSystem.UpdateDirList(aDiretoriesList);
                mediacontroller.SongBoxUpdate(aSongBox, fileSystem);
            }
            catch (Exception)
            {
                MessageBox.Show("Du har ikke valgt et bibliotek");
            }
        }

        //Self Destruct
        private void aExitKnap_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //Pauser og starter paused musik
        private void aPauseMusic_Click(object sender, EventArgs e)
        {
            mediacontroller.PauseMusic();

        }

        //Få text som er over 50 characters lang til at "scrolle" 
        private void ScrollTextTimer_Tick(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/13740183/label-scroll-effect
            if (aSongNameLabel.Text.Length >= 50) 
            {
                aSongNameLabel.Text = aSongNameLabel.Text.Substring(1, aSongNameLabel.Text.Length - 1) + aSongNameLabel.Text.Substring(0, 1);

            }
        }
    }
}
