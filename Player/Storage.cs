using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Model
{
    public class Storage
    {
        public static List<DirectoryInfo> Dir = new List<DirectoryInfo>();
        private readonly string _source = "Storage/source";

        public void Serialize()
        {
            string json = JsonConvert.SerializeObject(Dir);
            using (StreamWriter sw = new StreamWriter(_source, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }

        public async void Deserialize()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_source))
                {
                    string json = sr.ReadToEnd();
                    Dir = JsonConvert.DeserializeObject<List<DirectoryInfo>>(json);
                    await Task.Run(() => AllSongs.LoadSongs());
                }
            }
            catch { }
        }
    }
}
