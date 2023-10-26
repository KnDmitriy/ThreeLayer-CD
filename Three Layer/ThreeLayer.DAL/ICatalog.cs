using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Entities;

namespace ThreeLayer.DAL
{
    public interface ICatalog
    {
        //Add
        void AddDisk(string name, List<Disk.SongAndSinger> list);
        void AddDisk(Disk dsk);
        void AddSong(Disk.SongAndSinger item, Disk dsk);//dsk - диск, в который нужно добавить песню
        void AddSong(string song, string singer, string diskName);
        //Remove
        void RemoveDisk(string nameOfDisk);
        void RemoveDisk(Disk dsk);
        void RemoveSong(Disk.SongAndSinger song, Disk dsk);
        void RemoveSong(string singer, string song, Disk dsk);

        //Find
        List<Disk> FindSongs(string arg, string parametr);
        Disk FindDisk(string diskName);
        bool IsSongUniqueInTheDisk(Disk.SongAndSinger song, Disk dsk);

        int IndexOfDiskInCatalog(string nameOfDisk);
        //Возвращает индекс диска с именем nameOfDisk в списке каталога. 
        //Если диск не найден, то возвращает -1.

        int IndexOfSongInDisk(Disk.SongAndSinger song, Disk dsk);
        //Возвращает индекс коспозиции с именем songAndSinger в списке диска. 
        //Если композиция не найдена, то возвращает -1.

        //Sort
        void SortSongsInCatalogBySinger();
        void SortSongsInCatalogBySong();
        void SortDisks();
        int CompareToBySinger(Disk.SongAndSinger x, Disk.SongAndSinger y);
        int CompareToBySong(Disk.SongAndSinger x, Disk.SongAndSinger y);
        //Getters
        Disk GetDisk(string name);
        Disk GetDisk(Disk dsk);
        List<Disk> GetAllDisks();
        List<string> GetSongsOfTheDisk(string nameOfDisk);
        List<string> GetSongsOfTheDisk(Disk dsk);
        List<string> GetNamesOfDisks();
        
        void SaveCatalog();
        bool IsEmptyOrWhiteSpace(string name);

    }
}
