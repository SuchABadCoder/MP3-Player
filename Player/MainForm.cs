using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        private readonly string coverImage = @"Image\cover.jpg";

        private double currentPosition = 0;
        private int plstN = 0, counter = 0;
        private bool clickOnPlay = false, 
            playlistsOpened = false,
            clickOnShuffle = false;

        private IWMPPlaylist playlist = null;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private DateTime date = new DateTime(0, 0);
        private AllSongs songs = new AllSongs();
        private Storage storage = new Storage();
        public delegate void InvokeDelegate();

        public MainForm()
        {
            InitializeComponent();
            player.PlayStateChange += Player_PlayStateChange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlbumCover.Image = Image.FromFile(coverImage);
            storage.Deserialize();
            FillListBox_AllSongs();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            storage.Serialize();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == 3 && clickOnPlay)
            {
                timer.Start();
                LoadTags();
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (!clickOnPlay)
            {
                player.controls.currentPosition = currentPosition;
                timer.Start();
                player.controls.play();
                btPlay.Text = "Pause";
                clickOnPlay = true;
            }
            else
            {
                currentPosition = player.controls.currentPosition;
                timer.Stop();
                player.controls.stop();
                btPlay.Text = "Play";
                clickOnPlay = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter < trackBar.Maximum)
            {
                trackBar.Value = counter;
                var currentTime = date.AddSeconds(counter);
                lbTime.Text = currentTime.ToString("mm:ss");
                counter++;
            }
            else
                timer.Stop();

        }

        private void btPrev_Click(object sender, EventArgs e) //предыдущий трек
        {
            player.controls.previous();
            LoadTags();
            currentPosition = 0;
            lbTime.Text = date.ToString("mm:ss");
        }

        private void btNext_Click(object sender, EventArgs e) //слудующий трек
        {
            player.controls.next();
            LoadTags();
            currentPosition = 0;
            lbTime.Text = date.ToString("mm:ss");
        }

        private void LoadTags()
        {
            try
            {
                var audioFile = TagLib.File.Create(player.currentMedia.sourceURL);
                var mStream = new MemoryStream();

                var songDuration = player.currentMedia.duration;

                trackBar.Value = 0;
                counter = 0;
                trackBar.Maximum = (int)songDuration;

                DateTime current = date.AddSeconds((int)songDuration);
                lbDuration.Text = current.ToString("mm:ss");

                lbTitle.Text = audioFile.Tag.Title ?? "Unknown";
                lbArtist.Text = audioFile.Tag.Performers.FirstOrDefault() ?? "Unknown";

                AlbumCover.Image = null;

                var firstPicture = audioFile.Tag.Pictures.FirstOrDefault();
                if (firstPicture != null)
                {
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    AlbumCover.Image = bm;
                }
                else
                    AlbumCover.Image = Image.FromFile(coverImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e) //перемотка
        {
            player.controls.currentPosition = currentPosition = counter = trackBar.Value;
            var currentTime = date.AddSeconds(trackBar.Value);
            lbTime.Text = currentTime.ToString("mm:ss");
            if (clickOnPlay)
                player.controls.play();
        }

        private void lbAllSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbAllSongs.SelectedIndex;
            playlist = player.playlistCollection.newPlaylist("CurrentPlaylist");

            if (index != -1)
            {
                for (int i = index; i < lbAllSongs.Items.Count; i++)
                {
                    var song = lbAllSongs.Items[i] as Song;
                    playlist.appendItem(player.newMedia(song.Path));
                }
                for (int i = 0; i < index; i++)
                {
                    var song = lbAllSongs.Items[i] as Song;
                    playlist.appendItem(player.newMedia(song.Path));
                }

                player.currentPlaylist = playlist;
                timer.Start();
                btPlay.Text = "Pause";
                clickOnPlay = true;
                btPlay.Enabled = true;
                trackBar.Enabled = true;

                lbAllSongs.Visible = false;
            }
        }

        private void allSongsToolStripMenuItem_Click(object sender, EventArgs e) //Open -> Songs
        {
            lbAllSongs.Visible = true;
            lbPlaylists.Visible = false;
            FillListBox_AllSongs();
        }

        private async void directoryToolStripMenuItem_Click(object sender, EventArgs e) //Open -> Directory
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Storage.Dir.Add(new DirectoryInfo(folderBrowserDialog.SelectedPath));

            await Task.Run(() => {
                BeginInvoke(new InvokeDelegate(() => Cursor = Cursors.AppStarting));
                AllSongs.LoadSongs();
                BeginInvoke(new InvokeDelegate(() => Cursor = Cursors.Default));
            });
            FillListBox_AllSongs();
            lbAllSongs.Visible = true;
        }

        private void performerToolStripMenuItem_Click(object sender, EventArgs e)//Open -> Playlists -> Performer
        {
            ShowPlaylists();
            lbPlaylists.DisplayMember = "Performer";
            plstN = 0;

            var result = AllSongs.Songs.GroupBy(x => x.Performer).Select(x => x.First()).ToList();
            for (int i = 0; i < result.Count; i++)
                lbPlaylists.Items.Add(result[i]);
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)//Open -> Playlists -> Genre
        {
            ShowPlaylists();
            lbPlaylists.DisplayMember = "Genre";
            plstN = 1;

            var result = AllSongs.Songs.GroupBy(x => x.Genre).Select(x => x.First()).ToList();
            for (int i = 0; i < result.Count; i++)
                lbPlaylists.Items.Add(result[i]);
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)//Open -> Playlists -> Year
        {
            ShowPlaylists();
            lbPlaylists.DisplayMember = "Year";
            plstN = 2;

            var result = AllSongs.Songs.GroupBy(x => x.Year).Select(x => x.First()).ToList();
            for (int i = 0; i < result.Count; i++)
                lbPlaylists.Items.Add(result[i]);
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)//Open -> Playlists -> Album
        {
            ShowPlaylists();
            lbPlaylists.DisplayMember = "Album";
            plstN = 3;

            var result = AllSongs.Songs.GroupBy(x => x.Album).Select(x => x.First()).ToList();
            for (int i = 0; i < result.Count; i++)
                lbPlaylists.Items.Add(result[i]);
        }

        private void lbPlaylists_SelectedIndexChanged(object sender, EventArgs e) //выбран плейлист
        {
            if (lbPlaylists.SelectedIndex != -1)
            {
                var song = lbPlaylists.Items[lbPlaylists.SelectedIndex] as Song;
                lbAllSongs.Items.Clear();

                switch (plstN)
                {
                    case 0: //performer
                        var result = AllSongs.Songs.Where(x => x.Performer == song.Performer).ToList();
                        for (int i = 0; i < result.Count; i++)
                            lbAllSongs.Items.Add(result[i]);
                        break;
                    case 1: //Genre
                        result = AllSongs.Songs.Where(x => x.Genre == song.Genre).ToList();
                        for (int i = 0; i < result.Count; i++)
                            lbAllSongs.Items.Add(result[i]);
                        break;
                    case 2: //Year
                        result = AllSongs.Songs.Where(x => x.Year == song.Year).ToList();
                        for (int i = 0; i < result.Count; i++)
                            lbAllSongs.Items.Add(result[i]);
                        break;
                    case 3: //Album
                        result = AllSongs.Songs.Where(x => x.Album == song.Album).ToList();
                        for (int i = 0; i < result.Count; i++)
                            lbAllSongs.Items.Add(result[i]);
                        break;
                }

                lbAllSongs.Visible = true;
                playlistsOpened = true;
                lbPlaylists.Visible = false;
            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbPlaylists.Visible = false;
            lbAllSongs.Visible = false;
        }

        private void FillListBox_AllSongs()
        {
            lbAllSongs.Items.Clear();
            lbAllSongs.DisplayMember = "Title";
            for (int i = 0; i < AllSongs.Songs.Count; i++)
                lbAllSongs.Items.Add(AllSongs.Songs[i]);
        }

        private void btBack_Click(object sender, EventArgs e) //back
        {
            if (lbPlaylists.Visible)
                lbPlaylists.Visible = false;
            if (lbAllSongs.Visible)
                lbAllSongs.Visible = false;
            if (playlistsOpened)
            {
                lbAllSongs.Visible = false;
                playlistsOpened = false;
                lbPlaylists.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Shuffle
        {
            if (!clickOnShuffle)
            {
                player.settings.setMode("shuffle", true);
                clickOnShuffle = true;
                toolStripButton1.Checked = true;
            }
            else
            {
                player.settings.setMode("shuffle", false);
                clickOnShuffle = false;
                toolStripButton1.Checked = false;
            }
        }

        private void lbTitle_TextChanged(object sender, EventArgs e) //Text changed
        {
            if (TextRenderer.MeasureText(lbTitle.Text, lbTitle.Font).Width > lbTitle.Width)
                TextTimer.Start();
            else
                TextTimer.Stop();
        }

        private void TextTimer_Tick(object sender, EventArgs e) //Float text
        {
            var text = lbTitle.Text + ' ';
            text = text.Substring(1) + text[0];
            lbTitle.Text = text;
        }

        private void ShowPlaylists()
        {
            lbPlaylists.Visible = true;
            lbAllSongs.Visible = false;
            lbPlaylists.Items.Clear();
        }
    }
}
