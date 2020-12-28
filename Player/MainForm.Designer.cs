namespace Player
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AlbumCover = new System.Windows.Forms.PictureBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.allSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btBack = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbAllSongs = new System.Windows.Forms.ListBox();
            this.lbPlaylists = new System.Windows.Forms.ListBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TextTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumCover
            // 
            this.AlbumCover.Location = new System.Drawing.Point(35, 28);
            this.AlbumCover.Name = "AlbumCover";
            this.AlbumCover.Size = new System.Drawing.Size(206, 203);
            this.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumCover.TabIndex = 0;
            this.AlbumCover.TabStop = false;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btPlay.Enabled = false;
            this.btPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPlay.Location = new System.Drawing.Point(98, 347);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(32, 312);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(22, 13);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "0:0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.btBack,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(274, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSongsToolStripMenuItem,
            this.playlistsToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton2.Text = "Open";
            this.toolStripDropDownButton2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton2_DropDownItemClicked);
            // 
            // allSongsToolStripMenuItem
            // 
            this.allSongsToolStripMenuItem.Name = "allSongsToolStripMenuItem";
            this.allSongsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.allSongsToolStripMenuItem.Text = "Songs";
            this.allSongsToolStripMenuItem.Click += new System.EventHandler(this.allSongsToolStripMenuItem_Click);
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performerToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.yearToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // performerToolStripMenuItem
            // 
            this.performerToolStripMenuItem.Name = "performerToolStripMenuItem";
            this.performerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.performerToolStripMenuItem.Text = "Performer";
            this.performerToolStripMenuItem.Click += new System.EventHandler(this.performerToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.yearToolStripMenuItem.Text = "Year";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.directoryToolStripMenuItem.Text = "Directory";
            this.directoryToolStripMenuItem.Click += new System.EventHandler(this.directoryToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // btBack
            // 
            this.btBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(36, 22);
            this.btBack.Text = "Back";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(28, 276);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(224, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(179, 347);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(49, 23);
            this.btNext.TabIndex = 7;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(43, 347);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(49, 23);
            this.btPrev.TabIndex = 8;
            this.btPrev.Text = "<<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(219, 312);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(22, 13);
            this.lbDuration.TabIndex = 9;
            this.lbDuration.Text = "0:0";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(35, 234);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(206, 22);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Song Name   ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.TextChanged += new System.EventHandler(this.lbTitle_TextChanged);
            // 
            // lbArtist
            // 
            this.lbArtist.Location = new System.Drawing.Point(35, 260);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(206, 13);
            this.lbArtist.TabIndex = 11;
            this.lbArtist.Text = "Artist";
            this.lbArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAllSongs
            // 
            this.lbAllSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllSongs.FormattingEnabled = true;
            this.lbAllSongs.ItemHeight = 16;
            this.lbAllSongs.Location = new System.Drawing.Point(0, 28);
            this.lbAllSongs.Name = "lbAllSongs";
            this.lbAllSongs.Size = new System.Drawing.Size(274, 356);
            this.lbAllSongs.TabIndex = 12;
            this.lbAllSongs.Visible = false;
            this.lbAllSongs.SelectedIndexChanged += new System.EventHandler(this.lbAllSongs_SelectedIndexChanged);
            // 
            // lbPlaylists
            // 
            this.lbPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlaylists.FormattingEnabled = true;
            this.lbPlaylists.ItemHeight = 16;
            this.lbPlaylists.Location = new System.Drawing.Point(0, 28);
            this.lbPlaylists.Name = "lbPlaylists";
            this.lbPlaylists.Size = new System.Drawing.Size(274, 356);
            this.lbPlaylists.TabIndex = 13;
            this.lbPlaylists.Visible = false;
            this.lbPlaylists.SelectedIndexChanged += new System.EventHandler(this.lbPlaylists_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "Shuffle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TextTimer
            // 
            this.TextTimer.Interval = 400;
            this.TextTimer.Tick += new System.EventHandler(this.TextTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 383);
            this.Controls.Add(this.lbPlaylists);
            this.Controls.Add(this.lbAllSongs);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.AlbumCover);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.trackBar);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Audio  Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AlbumCover;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.ListBox lbAllSongs;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem allSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ListBox lbPlaylists;
        private System.Windows.Forms.ToolStripButton btBack;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer TextTimer;
    }
}

