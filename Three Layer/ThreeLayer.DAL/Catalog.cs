using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ThreeLayer.Entities;
using System.Collections;

namespace ThreeLayer.DAL
{
    [Serializable]
    public class Catalog : ICatalog
    {
        private static string Name;
        private static List<Disk> Disks;
        public Catalog()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = new FileStream("data.dat", FileMode.OpenOrCreate);
            if(f.Length == 0) //файл пуст - создаю новую базу
            {
                Disks = new List<Disk>();
                Name = "";
            }
            else //иначе выполняю десериализацию
            {
                Disks = (List<Disk>)formatter.Deserialize(f);
                
                
            }
            f.Close();
        }
        /*~Catalog()
        {
            SaveCatalog();
        }*/
        public Catalog(string name, List<Disk> disks)
        {
            Name = name;
            Disks = disks;
        }
        public void SaveCatalog()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(f, Disks);
            }
        }
        

        public void AddDisk(string name, List<Disk.SongAndSinger> list)
        {
            Disks.Add(new Disk(name, list));
        }
        public void AddDisk(Disk dsk)
        {
            Disks.Add( dsk);
        }
        public void AddSong(string song, string singer, Disk dsk)//dsk - диск, в который нужно добавить песню
        {
            dsk.disk.Add(new Disk.SongAndSinger(song, singer));
        }
        public void AddSong(string song, string singer, string diskName)
        {
            foreach (Disk item in Disks)
            {
                if (item.NameOfDisk == diskName)
                {
                    item.disk.Add(new Disk.SongAndSinger(song, singer));
                }
            }
            
        }
        public void AddSong(Disk.SongAndSinger Song, Disk dsk)//dsk - диск, в который нужно добавить песню
        {
            foreach (Disk item in Disks)
            {
                if (item == dsk)
                {
                    dsk.disk.Add(new Disk.SongAndSinger(Song));
                }
            }
        }

        public Disk FindDisk(string diskName)
        {
            foreach (Disk item in Disks)
            {
                if (item.NameOfDisk == diskName)
                {
                    return item;
                }
            }
            return null;
        }

        public bool IsSongUniqueInTheDisk(Disk.SongAndSinger song, Disk dsk )
        {
            foreach (Disk item in Disks)
            {
                if (item == dsk)
                {
                    foreach(Disk.SongAndSinger song_item in item.disk)
                    {
                        if(song.Song == song_item.Song && song.Singer == song_item.Singer)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                
            }
            return true;
        }

        public List<Disk> FindSongs(string arg, string parametr)
        {
            List<Disk> res = new List<Disk>();
            Disk temp;
            switch (parametr)
            {
                case "Исполнителю":
                    foreach(Disk disk in Disks)
                    {
                        temp = new Disk(disk.NameOfDisk);
                        bool isTempEmpty = true;
                        foreach (Disk.SongAndSinger song in disk.disk)
                        {
                            if (song.Singer == arg)
                            {
                                temp.AddSong(song);
                                isTempEmpty = false;
                            }
                        }
                        if (!isTempEmpty)
                            res.Add(temp);
                        
                        
                    }
                    return res;
                case "Названию композиции":
                    foreach (Disk disk in Disks)
                    {
                        
                        temp = new Disk(disk.NameOfDisk);
                        bool isTempEmpty = true;
                        foreach (Disk.SongAndSinger song in disk.disk)
                        {
                            if (song.Song == arg)
                            {
                                temp.AddSong(song);
                                isTempEmpty = false;
                            }
                        }
                        if(!isTempEmpty)
                            res.Add(temp);
                            
                        
                    }
                    return res;
                default: return null;
            }
        }

        public int IndexOfDiskInCatalog(string nameOfDisk)
            //Возвращает индекс диска с именем nameOfDisk в списке каталога. 
            //Если диск не найден, то возвращает -1.
        {
            for (int i = 0; i < Disks.Count; ++i)
            {
                if (Disks[i].NameOfDisk == nameOfDisk)//сравнивает по ссылкам
                {
                    return i;
                }
            }
            return -1; //диска с таким именем нет в списке каталога
        }

        public int IndexOfSongInDisk(Disk.SongAndSinger song, Disk dsk)
        {
           return dsk.disk.IndexOf(song);
            
           
        }
        public void RemoveDisk(string nameOfDisk)//удаляет все диски с именем nameOfDisk
        {
            for (int i = 0; i < Disks.Count; ++i)
            {
                if (Disks[i].NameOfDisk == nameOfDisk)//сравнивает по ссылкам
                {
                    Disks.Remove(Disks[i]);
                }
            }
        }

        public void RemoveDisk(Disk dsk)
        {
            for (int i = 0; i < Disks.Count; ++i)
            {
                if (Disks[i] == dsk)//сравнивает по ссылкам
                {
                    Disks.Remove(Disks[i]);
                }
            }
        }
        public void RemoveSong(Disk.SongAndSinger song, Disk dsk)
        {
            dsk.disk.Remove(song);
        }
        public void RemoveSong(string singer, string song, Disk dsk)
        {
            dsk.disk.Remove(new Disk.SongAndSinger(singer, song));
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
        public int CompareToBySinger(Disk.SongAndSinger x, Disk.SongAndSinger y)
        {
            int tmp = x.Singer.CompareTo(y.Singer);
            if (tmp == 0)
                return x.Song.CompareTo(y.Song);
            else
                return tmp;
        }
        public int CompareToBySong(Disk.SongAndSinger x, Disk.SongAndSinger y)
        {
            int tmp = x.Song.CompareTo(y.Song);
            if (tmp == 0)
                return x.Singer.CompareTo(y.Singer);
            else
                return tmp;
        }
        public void SortSongsInCatalogBySinger()
        {
            foreach (Disk item in Disks)
            {
                item.disk.Sort(CompareToBySinger);
            }
        }
        public void SortSongsInCatalogBySong()
        {
            foreach (Disk item in Disks)
            {
                item.disk.Sort(CompareToBySong);
            }
        }
        public void SortDisks()
        {
            Disks.Sort((x, y) => x.NameOfDisk.CompareTo(y.NameOfDisk));
        }
        public Disk GetDisk(string name)//возвращает первый диск с именем name
        {
            foreach(Disk item in Disks)
            {
                if(item.NameOfDisk == name)
                {
                    return item;
                }
                
            }
            return null;
        }
        public Disk GetDisk(Disk dsk)
        {
            foreach(Disk item in Disks)
            {
                if(item == dsk)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Disk> GetAllDisks()
        {
            return Disks;
        }
        public List<string> GetNamesOfDisks()
        {
            List<string> res = new List<string>();
            foreach(Disk item in Disks)
            {
                res.Add(item.NameOfDisk);
            }
            return res;
        }
        public List<string> GetSongsOfTheDisk(string nameOfDisk)
        {
            List<string> res = new List<string>();
            foreach (Disk item in Disks)
            {
                if (item.NameOfDisk == nameOfDisk)
                {
                    foreach (Disk.SongAndSinger song in item.disk)
                    {
                        res.Add($"{song.Singer} - {song.Singer}");
                    }
                }
            }
            return res;
        }
        public List<string> GetSongsOfTheDisk(Disk dsk)
        {
            List<string> res = new List<string>();
            foreach (Disk item in Disks)
            {
                if (item== dsk)
                {
                    foreach (Disk.SongAndSinger song in item.disk)
                    {
                        res.Add($"{song.Singer} - {song.Song}");
                    }
                }
            }
            return res;
        }
        public bool IsEmptyOrWhiteSpace(string name)
        {
            return (name == " " || name == "");
        }

    }
}
