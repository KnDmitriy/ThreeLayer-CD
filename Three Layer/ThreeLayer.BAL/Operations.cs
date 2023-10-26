using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.BLL;

namespace ThreeLayer.BAL
{
    public class Operations
    {
        public static void PrintCatalog(catalogCd CompactDisk)
        {
            Console.WriteLine("\nCatalog CD:");
            foreach (CD cd in CompactDisk.GetCD())
            {
                Console.WriteLine($"Name CD: {cd.cdName}");
            }

            Console.WriteLine("\nCD catalog:");
            foreach (CD cd in CompactDisk.GetCD())
            {
                Console.WriteLine($"\nCD: {cd.cdName}");
                for (int i = 0; i < cd.songsCatalog.Count; i++)
                    Console.WriteLine("Song: {0} - {1}", cd.songsCatalog[i].singerName, cd.songsCatalog[i].songName);
            }
        }

        public static void SearchBySong(catalogCd CompactDisk)
        {
            Console.WriteLine("\nEnter singer name to search:");
            string singername = Console.ReadLine();
            List<Songs> searchedSong = new List<Songs>();
            bool res = false;
            foreach (CD item in CompactDisk.GetCD())
            {
                searchedSong = item.SearchSongBySingerName(singername);
                if (searchedSong != null)
                {
                    for (int i = 0; i < searchedSong.Count; i++)
                    {
                        Console.WriteLine("Song found - Song: {0} - {1}", searchedSong[i].singerName, searchedSong[i].songName);
                    }
                    res = true;
                }
            }
            if (!res)
            {
                Console.WriteLine("Song not found.");
            }
        }

        public static void SongRemove(catalogCd CompactDisk)
        {
            Console.WriteLine("\nWhich CD should to remove:");
            string CDname = Console.ReadLine();
            Console.WriteLine("\nEnter Singer name to remove:");
            string singerToRemove = Console.ReadLine();
            Console.WriteLine("\nEnter Song name to remove:");
            string songToRemove = Console.ReadLine();
            bool songRemoved = false;
            foreach (CD item in CompactDisk.GetCD())
            {
                if (item == CompactDisk.SearchCDByCDName(CDname))
                {
                    songRemoved = item.RemoveSong(singerToRemove, songToRemove);
                }
            }
            if (songRemoved)
            {
                Console.WriteLine("Song removed successfully.");
            }
            if (!songRemoved)
            {
                Console.WriteLine("Song not found.");
            }
        }

        public static void CDRemove(catalogCd CompactDisk)
        {
            Console.WriteLine("\nEnter CD name to remove:");
            string cdToRemove = Console.ReadLine();
            bool cdRemoved = CompactDisk.RemoveCD(cdToRemove);
            if (cdRemoved)
            {
                Console.WriteLine("CD removed successfully.");
            }
            else
            {
                Console.WriteLine("CD not found.");
            }
        }

        public static void AddCD(catalogCd CompactDisk)
        {
            Console.WriteLine("\nEnter CD name to add:");
            string cdToAdd = Console.ReadLine();
            Console.WriteLine("\nDo you want to add a song? Yes - y, No - n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                List<Songs> songs = new List<Songs>();
                Console.WriteLine("\nEnter singer name:");
                string singer = Console.ReadLine();
                Console.WriteLine("\nEnter song name:");
                string song = Console.ReadLine();
                if (CompactDisk.SearchCDByCDName(cdToAdd) != null)
                {

                    cdToAdd = $"{cdToAdd}_Copy";
                    Songs songAdds = new Songs(singer, song);
                    songs.Add(songAdds);
                    CompactDisk.AddCD(new CD(cdToAdd, songs));
                }
                else
                {
                    Songs songAdds = new Songs(singer, song);
                    songs.Add(songAdds);
                    CompactDisk.AddCD(new CD(cdToAdd, songs));
                }
            }
            else
            {
                if (CompactDisk.SearchCDByCDName(cdToAdd) != null)
                {
                    cdToAdd = $"{cdToAdd}_Copy";
                    CompactDisk.AddCD(new CD(cdToAdd));
                }
                else
                {
                    CompactDisk.AddCD(new CD(cdToAdd));
                }
            }
        }

        public static void AddSong(catalogCd CompactDisk)
        {
            Console.WriteLine("\nWhich CD should add to?:");
            string cdname = Console.ReadLine();
            CD searchedCD = CompactDisk.SearchCDByCDName(cdname);
            if (searchedCD != null)
            {
                Console.WriteLine("\nEnter singer name:");
                string singer = Console.ReadLine();
                Console.WriteLine("\nEnter song name:");
                string song = Console.ReadLine();
                foreach (CD item in CompactDisk.GetCD())
                {
                    if (!item.CheckExist(singer, song))
                    {
                        song = $"{song}_Copy";
                        Songs songAdds = new Songs(singer, song);
                        searchedCD.songsCatalog.Add(songAdds);
                        break;
                    }
                    else
                    {
                        Songs songAdds = new Songs(singer, song);
                        searchedCD.songsCatalog.Add(songAdds);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("CD not found.");
            }
        }
    }
}
