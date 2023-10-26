using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Entities
{
    [Serializable]
    public class Disk
    {
        public string NameOfDisk;
        public List<SongAndSinger> disk;

        [Serializable]
        public struct SongAndSinger
        {
            public string Song ;
            public string Singer;
            
           
            public SongAndSinger(string singer, string song)
            {
                Song = song;
                Singer = singer;
            }
            public SongAndSinger(SongAndSinger song)
            {
                Song = song.Song;
                Singer = song.Singer;
            }
            public override string ToString()
            {
                string res = $"{Singer} - {Song}";
                
                return res;
            }
        }
        public Disk()
        {
            NameOfDisk = "";
            disk = new List<SongAndSinger> { };
        }
        public Disk(string name, List<SongAndSinger> list)
        {
            NameOfDisk = name;
            disk = list;
        }
        public Disk(string name)
        {
            NameOfDisk = name;
            disk = new List<SongAndSinger> { };
        }
        
        public void AddSong(SongAndSinger song)
        {
            disk.Add(song);
        }
        public void AddSong(string singer, string song)
        {
            disk.Add(new SongAndSinger(singer, song));
        }
       
    }
}
