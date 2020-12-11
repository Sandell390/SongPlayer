namespace SongPlayer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SongName = new System.Windows.Forms.Label();
            this.aSongNameLabel = new System.Windows.Forms.Label();
            this.aNextSongButton = new System.Windows.Forms.Button();
            this.aAddBibButton = new System.Windows.Forms.Button();
            this.aDelectBibButton = new System.Windows.Forms.Button();
            this.aReloadSongButton = new System.Windows.Forms.Button();
            this.aSongBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aExitKnap = new System.Windows.Forms.PictureBox();
            this.aMusicButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aMusicTing = new System.Windows.Forms.Panel();
            this.aVisualCheck = new System.Windows.Forms.CheckBox();
            this.aPicSong = new System.Windows.Forms.PictureBox();
            this.aPauseMusic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aDiretoriesTing = new System.Windows.Forms.Panel();
            this.aDiretoriesList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ScrollTextTimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aExitKnap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMusicButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aMusicTing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPicSong)).BeginInit();
            this.aDiretoriesTing.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.Location = new System.Drawing.Point(3, 3);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(105, 23);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Afspiller: ";
            // 
            // aSongNameLabel
            // 
            this.aSongNameLabel.AutoSize = true;
            this.aSongNameLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSongNameLabel.Location = new System.Drawing.Point(106, 4);
            this.aSongNameLabel.Name = "aSongNameLabel";
            this.aSongNameLabel.Size = new System.Drawing.Size(124, 21);
            this.aSongNameLabel.TabIndex = 2;
            this.aSongNameLabel.Text = "(Song Name)";
            // 
            // aNextSongButton
            // 
            this.aNextSongButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aNextSongButton.BackgroundImage")));
            this.aNextSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aNextSongButton.FlatAppearance.BorderSize = 0;
            this.aNextSongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.aNextSongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.aNextSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aNextSongButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNextSongButton.Location = new System.Drawing.Point(61, 39);
            this.aNextSongButton.Name = "aNextSongButton";
            this.aNextSongButton.Size = new System.Drawing.Size(69, 47);
            this.aNextSongButton.TabIndex = 3;
            this.aNextSongButton.UseVisualStyleBackColor = true;
            this.aNextSongButton.Click += new System.EventHandler(this.aNextSongButton_Click);
            // 
            // aAddBibButton
            // 
            this.aAddBibButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAddBibButton.Location = new System.Drawing.Point(625, 3);
            this.aAddBibButton.Name = "aAddBibButton";
            this.aAddBibButton.Size = new System.Drawing.Size(189, 47);
            this.aAddBibButton.TabIndex = 1;
            this.aAddBibButton.Text = "Tilføj bibliotek";
            this.aAddBibButton.UseVisualStyleBackColor = true;
            this.aAddBibButton.Click += new System.EventHandler(this.aAddBibButton_Click);
            // 
            // aDelectBibButton
            // 
            this.aDelectBibButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDelectBibButton.Location = new System.Drawing.Point(625, 56);
            this.aDelectBibButton.Name = "aDelectBibButton";
            this.aDelectBibButton.Size = new System.Drawing.Size(189, 47);
            this.aDelectBibButton.TabIndex = 7;
            this.aDelectBibButton.Text = "Slet bibliotekker";
            this.aDelectBibButton.UseVisualStyleBackColor = true;
            this.aDelectBibButton.Click += new System.EventHandler(this.aDelectBibButton_Click);
            // 
            // aReloadSongButton
            // 
            this.aReloadSongButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aReloadSongButton.Location = new System.Drawing.Point(7, 92);
            this.aReloadSongButton.Name = "aReloadSongButton";
            this.aReloadSongButton.Size = new System.Drawing.Size(212, 47);
            this.aReloadSongButton.TabIndex = 9;
            this.aReloadSongButton.Text = "Genindlæs sange";
            this.aReloadSongButton.UseVisualStyleBackColor = true;
            this.aReloadSongButton.Click += new System.EventHandler(this.aReloadSongButton_Click);
            // 
            // aSongBox
            // 
            this.aSongBox.BackColor = System.Drawing.Color.DimGray;
            this.aSongBox.ForeColor = System.Drawing.Color.White;
            this.aSongBox.FormattingEnabled = true;
            this.aSongBox.HorizontalScrollbar = true;
            this.aSongBox.Location = new System.Drawing.Point(7, 165);
            this.aSongBox.Name = "aSongBox";
            this.aSongBox.Size = new System.Drawing.Size(812, 251);
            this.aSongBox.TabIndex = 10;
            this.aSongBox.SelectedIndexChanged += new System.EventHandler(this.aSongBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sange:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 518);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.aExitKnap);
            this.panel1.Controls.Add(this.aMusicButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 518);
            this.panel1.TabIndex = 10;
            // 
            // aExitKnap
            // 
            this.aExitKnap.Image = ((System.Drawing.Image)(resources.GetObject("aExitKnap.Image")));
            this.aExitKnap.Location = new System.Drawing.Point(3, 465);
            this.aExitKnap.Name = "aExitKnap";
            this.aExitKnap.Size = new System.Drawing.Size(51, 50);
            this.aExitKnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aExitKnap.TabIndex = 17;
            this.aExitKnap.TabStop = false;
            this.aExitKnap.Click += new System.EventHandler(this.aExitKnap_Click);
            // 
            // aMusicButton
            // 
            this.aMusicButton.Image = ((System.Drawing.Image)(resources.GetObject("aMusicButton.Image")));
            this.aMusicButton.Location = new System.Drawing.Point(3, 3);
            this.aMusicButton.Name = "aMusicButton";
            this.aMusicButton.Size = new System.Drawing.Size(51, 37);
            this.aMusicButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aMusicButton.TabIndex = 16;
            this.aMusicButton.TabStop = false;
            this.aMusicButton.Click += new System.EventHandler(this.aMusicButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aMusicTing
            // 
            this.aMusicTing.BackColor = System.Drawing.Color.Transparent;
            this.aMusicTing.Controls.Add(this.aVisualCheck);
            this.aMusicTing.Controls.Add(this.aPicSong);
            this.aMusicTing.Controls.Add(this.aPauseMusic);
            this.aMusicTing.Controls.Add(this.label2);
            this.aMusicTing.Controls.Add(this.aSongNameLabel);
            this.aMusicTing.Controls.Add(this.SongName);
            this.aMusicTing.Controls.Add(this.aSongBox);
            this.aMusicTing.Controls.Add(this.aNextSongButton);
            this.aMusicTing.Controls.Add(this.aReloadSongButton);
            this.aMusicTing.Controls.Add(this.label1);
            this.aMusicTing.Location = new System.Drawing.Point(141, 75);
            this.aMusicTing.Name = "aMusicTing";
            this.aMusicTing.Size = new System.Drawing.Size(822, 431);
            this.aMusicTing.TabIndex = 14;
            // 
            // aVisualCheck
            // 
            this.aVisualCheck.AutoSize = true;
            this.aVisualCheck.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.aVisualCheck.Location = new System.Drawing.Point(225, 105);
            this.aVisualCheck.Name = "aVisualCheck";
            this.aVisualCheck.Size = new System.Drawing.Size(202, 25);
            this.aVisualCheck.TabIndex = 15;
            this.aVisualCheck.Text = "Visualisering af lyd";
            this.aVisualCheck.UseVisualStyleBackColor = true;
            // 
            // aPicSong
            // 
            this.aPicSong.Location = new System.Drawing.Point(145, 39);
            this.aPicSong.Name = "aPicSong";
            this.aPicSong.Size = new System.Drawing.Size(461, 50);
            this.aPicSong.TabIndex = 14;
            this.aPicSong.TabStop = false;
            // 
            // aPauseMusic
            // 
            this.aPauseMusic.BackgroundImage = global::SongPlayer.Properties.Resources.StartSong;
            this.aPauseMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aPauseMusic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aPauseMusic.FlatAppearance.BorderSize = 0;
            this.aPauseMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.aPauseMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.aPauseMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aPauseMusic.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPauseMusic.Location = new System.Drawing.Point(7, 39);
            this.aPauseMusic.Name = "aPauseMusic";
            this.aPauseMusic.Size = new System.Drawing.Size(48, 47);
            this.aPauseMusic.TabIndex = 13;
            this.aPauseMusic.UseVisualStyleBackColor = true;
            this.aPauseMusic.Click += new System.EventHandler(this.aPauseMusic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 92);
            this.label2.TabIndex = 12;
            this.label2.Text = "Supported File Type:\r\n.wav\r\n.flac\r\n.mp3\r\n";
            // 
            // aDiretoriesTing
            // 
            this.aDiretoriesTing.BackColor = System.Drawing.Color.Transparent;
            this.aDiretoriesTing.Controls.Add(this.aDiretoriesList);
            this.aDiretoriesTing.Controls.Add(this.aAddBibButton);
            this.aDiretoriesTing.Controls.Add(this.aDelectBibButton);
            this.aDiretoriesTing.Location = new System.Drawing.Point(126, 79);
            this.aDiretoriesTing.Name = "aDiretoriesTing";
            this.aDiretoriesTing.Size = new System.Drawing.Size(817, 416);
            this.aDiretoriesTing.TabIndex = 15;
            // 
            // aDiretoriesList
            // 
            this.aDiretoriesList.BackColor = System.Drawing.SystemColors.GrayText;
            this.aDiretoriesList.ForeColor = System.Drawing.SystemColors.Window;
            this.aDiretoriesList.FormattingEnabled = true;
            this.aDiretoriesList.Location = new System.Drawing.Point(5, 3);
            this.aDiretoriesList.Name = "aDiretoriesList";
            this.aDiretoriesList.Size = new System.Drawing.Size(614, 407);
            this.aDiretoriesList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(58, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 71);
            this.panel2.TabIndex = 16;
            // 
            // ScrollTextTimer
            // 
            this.ScrollTextTimer.Enabled = true;
            this.ScrollTextTimer.Interval = 200;
            this.ScrollTextTimer.Tick += new System.EventHandler(this.ScrollTextTimer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PauseSong.png");
            this.imageList1.Images.SetKeyName(1, "StartSong.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(854, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 518);
            this.Controls.Add(this.aDiretoriesTing);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.aMusicTing);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Player Inator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aExitKnap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMusicButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aMusicTing.ResumeLayout(false);
            this.aMusicTing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPicSong)).EndInit();
            this.aDiretoriesTing.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label aSongNameLabel;
        private System.Windows.Forms.Button aNextSongButton;
        private System.Windows.Forms.Button aAddBibButton;
        private System.Windows.Forms.Button aDelectBibButton;
        private System.Windows.Forms.Button aReloadSongButton;
        private System.Windows.Forms.ListBox aSongBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox aMusicButton;
        private System.Windows.Forms.Panel aMusicTing;
        private System.Windows.Forms.Panel aDiretoriesTing;
        private System.Windows.Forms.ListBox aDiretoriesList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox aExitKnap;
        private System.Windows.Forms.Button aPauseMusic;
        private System.Windows.Forms.Timer ScrollTextTimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox aPicSong;
        private System.Windows.Forms.CheckBox aVisualCheck;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

