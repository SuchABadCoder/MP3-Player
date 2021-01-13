using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Model
{
    class AllSongs
    {
        public static List<Song> Songs = new List<Song>();

        public static void LoadSongs() //сканирует все директории и загружает треки в список
        {
            Songs.Clear();
            foreach (var directory in Storage.Dir)
            {
                try
                {
                    FileInfo[] files = directory.GetFiles("*.mp3");
                    foreach (var file in files)
                    {
                        var audioFile = TagLib.File.Create(file.FullName);
                        var song = new Song(audioFile.Tag.Title ?? "Unknown",
                            audioFile.Tag.Performers.FirstOrDefault() ?? "Unknown",
                            audioFile.Tag.Year,
                            audioFile.Tag.Album ?? "Unknown",
                            audioFile.Tag.Genres.FirstOrDefault() ?? "Unknown",
                            file.FullName);
                        Songs.Add(song);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
