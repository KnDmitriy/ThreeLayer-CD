using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.DAL;
using ThreeLayer.Entities;

namespace ThreeLayer.BLL
{
    public class DiskLogic : IDiskLogic
    {
        private ICatalog catalog;
        public DiskLogic(ICatalog catal)
        {
            catalog = catal;
        }

        public void AddDisk(string name, List<Disk.SongAndSinger> list)
        {
           catalog.AddDisk(name, list);
        }

        public void AddDisk(Disk dsk)
        {
            catalog.AddDisk(dsk);
        }
        public void AddSong(string singer, string song, Disk dsk)//dsk - диск, в который нужно добавить песню
        {
            
            catalog.AddSong(new Disk.SongAndSinger(singer, song), dsk);
        }
        public void AddSong(Disk.SongAndSinger song, Disk dsk)//dsk - диск, в который нужно добавить песню
        {
            foreach (Disk item in catalog.GetAllDisks())
            {
                if (item == dsk)
                {
                    dsk.disk.Add(song);
                }
            }
           
        }

        public List<Disk> FindSongs(string arg, string parametr)
        {
            return catalog.FindSongs(arg, parametr);
        }
        public Disk FindDisk(string diskName)
        {
            return catalog.FindDisk(diskName);
        }
        public bool IsSongUniqueInTheDisk(Disk.SongAndSinger song, Disk dsk)
        {
            return catalog.IsSongUniqueInTheDisk(song, dsk);
        }
        public int IndexOfDiskInCatalog(string nameOfDisk)
        {
            return catalog.IndexOfDiskInCatalog(nameOfDisk);
        }
        public int IndexOfSongInDisk(Disk.SongAndSinger song, Disk dsk)
        {
            return catalog.IndexOfSongInDisk(song, dsk);
        }

        public void RemoveDisk(string nameOfDisk)//удаляет все диски с именем nameOfDisk
        {
            catalog.RemoveDisk(nameOfDisk);
        }
        public void RemoveDisk(Disk dsk)
        {
            catalog.RemoveDisk(dsk);
        }
        public void RemoveSong(Disk.SongAndSinger song, Disk dsk)
        {
            dsk.disk.Remove(song);
        }
       
        /*
        public bool Remove(string song, string singer)
        {
            SongAndSinger songToRemove = disk.Find(sng => sng.Song == song && sng.Singer == singer);
            if (songToRemove != null)
            {
                disk.Remove(songToRemove);
                return true;
            }
            return false;
        }


        public void Remove(SongAndSinger item)
        {
            if (disk.Exists(x => x.Song == item.Song && x.Singer == item.Singer))
            {
                disk.Remove(item);
            }
            else
            {
                Console.WriteLine($"Песни {item.Song}, исполняемой {item.Singer}, не найдено на диске {NameOfDisk}");
            }
        }*/
        public void SortSongsInCatalogBySinger()
        {
            catalog.SortSongsInCatalogBySinger();
        }
        public void SortSongsInCatalogBySong()
        {
            catalog.SortSongsInCatalogBySong();
        }
        public void SortDisks()
        {
            catalog.SortDisks();
        }
        public Disk GetDisk(string name)
        {
            return catalog.GetDisk(name);
        }
        public Disk GetDisk(Disk dsk)
        {
            return catalog.GetDisk(dsk);
        }
        public List<Disk> GetAllDisks()
        {
            return catalog.GetAllDisks();
        }
        public List<string> GetNamesOfDisks()
        {
            return catalog.GetNamesOfDisks();
        }
        public List<string> GetSongsOfTheDisk(string nameOfDisk)
        {
            return catalog.GetSongsOfTheDisk(nameOfDisk);
        }
        public List<string> GetSongsOfTheDisk(Disk dsk)
        {
            return catalog.GetSongsOfTheDisk(dsk);
        }

        public void SaveCatalog()
        {
            catalog.SaveCatalog();
        }
        public bool IsEmptyOrWhiteSpace(string name)
        {
            return catalog.IsEmptyOrWhiteSpace(name);
        }

    }
}

