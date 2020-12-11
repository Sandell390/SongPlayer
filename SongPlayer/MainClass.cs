using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Newtonsoft.Json;
using NAudio.Wave;
using NAudio.Flac;
using WaveFormRendererLib;

namespace SongPlayer
{
    public class directories
    {
        //Indholder info om Sange, deres path og id
        public List<infoClass> MainList { get; set; }
    }

    public class infoClass
    {
        public int Id = 0; //Id bliver givet til hvert bibliotek
        public string dirPath { get; set; } //Path for bibliotek
        public List<string> path { get; set; } //Sange navne i bibliotek
    }

    public class FileSystem 
    {
        public List<string> wavFiles = new List<string>(); //full path af sangene (Navnet giver ikke mening, ved det)
        public List<string> wavNames = new List<string>(); //Navnet på sangene

        public string JsonFilePath = AppDomain.CurrentDomain.BaseDirectory + "Directories.json"; //Pathen til Json filen

        static int CountIds = 1;
        public void FirstRead(string JsonFilePath)
        {
            //Tjekker om der er blevet lavet en Json File
            try
            {
                var directories = ReadAndReturn(JsonFilePath);

                List<infoClass> CountPaths = directories.MainList;

                CountIds = CountPaths.Count;

            }
            catch (Exception)
            {
                //Laver Json Fil hvis der ikke er nogen 
                WriteFile(JsonFilePath);
            }
        }

        void WriteFile(string JsonFilePath)
        {
            //Laver en ny Json fil hvis der ikke er nogen
            try
            {
                var directories = GetDirectories();

                var jsonToWrite = JsonConvert.SerializeObject(directories, Formatting.Indented);

                using (var writer = new StreamWriter(JsonFilePath))
                {
                    writer.Write(jsonToWrite);
                }

                reload(JsonFilePath);
            }
            catch (Exception)
            {

                MessageBox.Show("Kan ikke lave Json Fil, Kontakt Jesper");
            }
        }
        private directories GetDirectories()
        {
            //Sætter default variabler i Json Fil
            var directories = new directories
            {
                MainList = new List<infoClass> { new infoClass { Id = 1, dirPath = AppDomain.CurrentDomain.BaseDirectory + "Musik\\", path = new List<string>() } }
            };

            //Bliver nød til at lave et foreach loop for at få adgang til listen til sangene
            foreach (var item in directories.MainList)
            {
                item.path.AddRange(GetFileFormats(item.dirPath));
            }

            return directories;
        }

        public directories ReadAndReturn(string JsonFilePath)
        {
            string jsonFromFile;
            using (var reader = new StreamReader(JsonFilePath))
            {
                jsonFromFile = reader.ReadToEnd();
            }

            var pathh = JsonConvert.DeserializeObject<directories>(jsonFromFile);

            return pathh;
        }

        public void reload(string JsonFilePath)
        {
            //Opdater Musik filer
            
            
            try
            {
                var directories = ReadAndReturn(JsonFilePath);

                List<string> _temp = new List<string>();

                wavNames.Clear();
                wavFiles.Clear();


                //Sætter full path for sangene og deres navn 
                foreach (var item in directories.MainList)
                {
                    //Kan ikke fjerne sange fra json fil, 

                    _temp = GetFileFormats(item.dirPath);
                    int count = 0;

                    string torem = null; //Temp var
                    foreach (var songs in item.path)
                    {
                        if (songs != _temp[count])
                        {
                            torem = songs;

                            break;
                        }
                        count++;
                    }
                    if (torem != null)
                    {
                        item.path.Remove(torem);
                    }

                    //Console.WriteLine(item.dirPath);
                    foreach (var file in _temp)
                    {

                        wavFiles.Add(Path.Combine(item.dirPath, file));
                        wavNames.Add(file);

                    }

                }

                String encoded = JsonConvert.SerializeObject(directories);
                File.WriteAllText(JsonFilePath, encoded);
            }
            catch (Exception)
            {

                MessageBox.Show("Kan ikke læse " + JsonFilePath + " Kontakt Jesper");
            }
            

           

        }

        public void UpdateFile(string UserDirectory)
        {
            //Adder bruger input til Json fil

            //Læser Json filen ind
            var directories = (dynamic)null;
            try
            {
                directories = ReadAndReturn(JsonFilePath);

                //Indsætter bruger input ind i class
                directories.MainList.Add(AddDirectories(directories, UserDirectory));

                //Skriver til filen
                var convertedJson = JsonConvert.SerializeObject(directories, Formatting.Indented);
                using (var writer = new StreamWriter(JsonFilePath))
                {
                    writer.Write(convertedJson);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kan ikke læse " + JsonFilePath + " Kontakt Jesper");
            }

            
        }

        private infoClass AddDirectories(directories directories, string UserDirectory)
        {

            //Får bruger input så det kan bruges til at indsættes i Json filz
            var infoClass = new infoClass
            {
                dirPath = UserDirectory,
                Id = directories.MainList.Count + 1,
                path = new List<string>()

            };

            //Skriver sangene navn ind i filen som er i mappen
            infoClass.path.AddRange(GetFileFormats(infoClass.dirPath));

            return infoClass;
        }

        public void UpdateDirList(ListBox listBox) 
        {
            //Updater listen over bibliotekker
            listBox.SelectionMode = SelectionMode.One;
            listBox.Items.Clear();
            listBox.BeginUpdate();

            var directories = (dynamic)null;
            try
            {
                directories = ReadAndReturn(JsonFilePath);

                foreach (var item in directories.MainList)
                {
                    listBox.Items.Add(item.dirPath);
                }

                listBox.EndUpdate();
            }
            catch (Exception)
            {

                MessageBox.Show("Kan ikke læse " + JsonFilePath + " Kontakt Jesper");
            }

            
        }

        public void delectPath(int brugerTal)
        {
            //Sletter biblioteker
            try
            {
                var directories = ReadAndReturn(JsonFilePath);

                int tal = directories.MainList.Count;

                if (brugerTal == 0)
                {
                    MessageBox.Show("Du kan ikke fjerne dette bibliotek");
                }
                else if (brugerTal > 0 && brugerTal < tal)
                {
                    if (File.Exists(JsonFilePath))
                    {
                        infoClass torem = null; //Temp var
                        foreach (var item in directories.MainList)
                        {
                            if (brugerTal + 1 == item.Id)
                            {
                                torem = item;

                                break;
                            }
                        }
                        if (torem != null) //Fjerner bibliotekket hvis der er et
                        {
                            directories.MainList.Remove(torem);
                            foreach (var item in directories.MainList)
                            {
                                if (item.Id > brugerTal + 1)
                                {
                                    item.Id -= 1;
                                }
                            }
                        }
                        //Updater filen
                        String encoded = JsonConvert.SerializeObject(directories);
                        System.IO.File.WriteAllText(JsonFilePath, encoded);
                    }
                }
                reload(JsonFilePath);
            }
            catch (Exception)
            {

                MessageBox.Show("Kan ikke læse " + JsonFilePath + " Kontakt Jesper");
            }

            
        }

        private List<string> GetFileFormats(string dirPath) //Får alle de supportede fil typer
        {
            List<string> fileFormats = new List<string>();

            fileFormats.Clear();

            fileFormats.AddRange(Directory.GetFiles(dirPath, "*.wav").Select(Path.GetFileName).ToList());
            fileFormats.AddRange(Directory.GetFiles(dirPath, "*.flac").Select(Path.GetFileName).ToList());
            fileFormats.AddRange(Directory.GetFiles(dirPath, "*.mp3").Select(Path.GetFileName).ToList());
            fileFormats.AddRange(Directory.GetFiles(dirPath, "*.aiff").Select(Path.GetFileName).ToList());
            fileFormats.AddRange(Directory.GetFiles(dirPath, "*.wma").Select(Path.GetFileName).ToList());

            return fileFormats;
        }
    }

    public class MediaController 
    {
        public int tal; //Bliver brugt til at finde list item nummer 
        private int previousSong = -1;

        private WaveOutEvent outputDevice; //? Hold musen over classen, Tror det er hvilken lyd enhed man har tilsluttede
        private AudioFileReader audioFile; //? Hold musen over classen, Noget med at den åbener en fil også oversætter den til computer sprog

        public Button aPauseMusicButton; //Til at skifte billeder på pause knappen
        public ImageList imageList; //Indeholder billeder til pause knappen

        public bool paused = true;

        public void Doof() //Afspiller sang når man start programmet 
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + "\\Musik\\My Name Is Doof.flac");
            LoopStream loop = new LoopStream(audioFile);
            outputDevice.Init(loop);
            outputDevice.Play();
        }

        public void PlayMusic(string JsonFilePath, FileSystem fileSystem) //Afspiller random musik der i alle bibliokkerne 
        {

            try
            {
                
                Random random = new Random();

                tal = random.Next(0, fileSystem.wavFiles.Count); //Vægler en random sang 

                if (fileSystem.wavFiles.Count > 1)
                {
                    while (tal == previousSong)
                    {
                        tal = random.Next(0, fileSystem.wavFiles.Count);
                    }
                }
                

                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(fileSystem.wavFiles[tal]);
                outputDevice.Init(audioFile);
               

                if (outputDevice == null)
                {
                    outputDevice.PlaybackStopped += OnPlaybackStopped; //Forstår ikke det her
                }

                outputDevice.Play();

                paused = false;
                
                aPauseMusicButton.BackgroundImage = imageList.Images[0];

                previousSong = tal;
            }
            catch (Exception)
            {

                MessageBox.Show("Kunne ikke afspille en tilfældig sang. Hvis du har fjernet nogle sange så genlæs sangene");

            }
            
          
        }

        public void UserPlayMusic(int UserChoice, FileSystem fileSystem) //Afspiller valgt musik
        {

            try
            {
                tal = UserChoice;


                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(fileSystem.wavFiles[UserChoice]);
                outputDevice.Init(audioFile);

                if (outputDevice == null)
                {
                    outputDevice.PlaybackStopped += OnPlaybackStopped; //Forstår ikke det her
                }
                outputDevice.Play();

                paused = false;
                
                aPauseMusicButton.BackgroundImage = imageList.Images[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Kunne ikke afspille den vaglte sang, hvis du har fjernet sangen så genlæse sangene");

            }
            
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args) //Clear audio ting ting, Forstår det ikke helt men det skal være der
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
        public void StopMusic() //Stopper musik
        {
            outputDevice?.Stop();

        }

        public void PauseMusic() 
        {
            try
            {
                if (!paused)
                {
                    aPauseMusicButton.BackgroundImage = imageList.Images[1];
                    paused = true;
                    outputDevice?.Stop();
                }
                else if (paused)
                {
                    aPauseMusicButton.BackgroundImage = imageList.Images[0];
                    outputDevice.Play();
                    paused = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kan ikke pause musikken da du ikke har valgt noget musik");
            }
           
        }

        public void SongBoxUpdate(ListBox aSongBox, FileSystem fileSystem) //Updater listen over sange
        {
            aSongBox.SelectionMode = SelectionMode.One;
            aSongBox.Items.Clear();
            aSongBox.BeginUpdate();

            for (int i = 0; i < fileSystem.wavNames.Count; i++)
            {

                aSongBox.Items.Add(fileSystem.wavNames[i]);
            }
            aSongBox.EndUpdate();

        }

        public void RenderPNGvisual(PictureBox pictureBox, FileSystem fileSystem) //visualization af lyd, Kopieret fra nettet
        {
            
            var maxPeakProvider = new MaxPeakProvider();
            var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            var topSpacerColor = Color.FromArgb(64, 224, 224, 224);

            var myRendererSettings = new SoundCloudBlockWaveFormSettings(Color.FromArgb(196, 197, 53, 0), topSpacerColor, Color.FromArgb(196, 79, 26, 0),
                Color.FromArgb(64, 79, 79, 79))
            {
                Name = "SoundCloud Orange Transparent Blocks",
                PixelsPerPeak = 2,
                SpacerPixels = 1,
                TopSpacerGradientStartColor = topSpacerColor,
                BackgroundColor = Color.Transparent
            }; ;
            myRendererSettings.Width = pictureBox.Width;
            myRendererSettings.TopHeight = 20;
            myRendererSettings.BottomHeight = 15;
            

            var renderer = new WaveFormRenderer();
            var audioFilePath = fileSystem.wavFiles[tal];
            var image = renderer.Render(audioFilePath, rmsPeakProvider, myRendererSettings);

            pictureBox.Image = image;
        }

    }

    
    public class LoopStream : WaveStream //Loop musik, kopieret fra nettet
    {
        WaveStream sourceStream;

        /// <summary>
        /// Creates a new Loop stream
        /// </summary>
        /// <param name="sourceStream">The stream to read from. Note: the Read method of this stream should return 0 when it reaches the end
        /// or else we will not loop to the start again.</param>
        public LoopStream(WaveStream sourceStream)
        {
            this.sourceStream = sourceStream;
            this.EnableLooping = true;
        }

        /// <summary>
        /// Use this to turn looping on or off
        /// </summary>
        public bool EnableLooping { get; set; }

        /// <summary>
        /// Return source stream's wave format
        /// </summary>
        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }

        /// <summary>
        /// LoopStream simply returns
        /// </summary>
        public override long Length
        {
            get { return sourceStream.Length; }
        }

        /// <summary>
        /// LoopStream simply passes on positioning to source stream
        /// </summary>
        public override long Position
        {
            get { return sourceStream.Position; }
            set { sourceStream.Position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;

            while (totalBytesRead < count)
            {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                if (bytesRead == 0)
                {
                    if (sourceStream.Position == 0 || !EnableLooping)
                    {
                        // something wrong with the source stream
                        break;
                    }
                    // loop
                    sourceStream.Position = 0;
                }
                totalBytesRead += bytesRead;
            }
            return totalBytesRead;
        }
    }
}

/*
Sources
Windows forms documentation: ListBox, FolderDialog
https://github.com/naudio/NAudio Addon/library brugt til at afspille lyd fra filer
https://stackoverflow.com/questions/13175868/how-to-get-full-file-path-from-file-name/13175944
https://www.youtube.com/watch?v=SholKTNGdHk Json file example
https://stackoverflow.com/questions/33081102/json-add-new-object-to-existing-json-file-c-sharp
https://www.dotnetperls.com/list Eksempler på lister 
https://stackoverflow.com/questions/28479670/how-remove-element-for-json-file-in-c-sharp
https://markheath.net/post/looped-playback-in-net-with-naudio
https://youtu.be/J4J3ZcXRN_E Windows Forms tutorial 
https://github.com/naudio/NAudio.WaveFormRenderer Library for visualization af lyd
https://github.com/naudio/NAudio/blob/master/Docs/WaveFormRendering.md visualization af lyd Tutorial
*/
