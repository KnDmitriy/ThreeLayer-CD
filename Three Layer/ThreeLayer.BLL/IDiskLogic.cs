using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Entities;
using ThreeLayer.DAL;

namespace ThreeLayer.BLL
{
    public interface IDiskLogic
    {
        //Add
        void AddDisk(string name, List<Disk.SongAndSinger> list);
        void AddDisk(Disk dsk);
        void AddSong(string song, string singer, Disk dsk);//dsk - диск, в который нужно добавить песню
        void AddSong(Disk.SongAndSinger song, Disk dsk);//dsk - диск, в который нужно добавить песню
        //Find
        List<Disk> FindSongs(string arg, string parametr);
        Disk FindDisk(string diskName);

        bool IsSongUniqueInTheDisk(Disk.SongAndSinger song, Disk dsk);
        int IndexOfDiskInCatalog(string nameOfDisk);

        int IndexOfSongInDisk(Disk.SongAndSinger song, Disk dsk);
        //Возвращает индекс коспозиции с именем songAndSinger в списке диска. 
        //Если композиция не найдена, то возвращает -1.
        //Remove
        void RemoveDisk(string nameOfDisk);//удаляет все диски с именем nameOfDisk
        void RemoveDisk(Disk dsk);
         void RemoveSong(Disk.SongAndSinger song, Disk dsk);
        //Sort
        void SortSongsInCatalogBySinger();
        void SortSongsInCatalogBySong();
        void SortDisks();
        //Getters
        Disk GetDisk(string name);
        Disk GetDisk(Disk dsk);
        List<string> GetSongsOfTheDisk(string nameOfDisk);
        List<string> GetSongsOfTheDisk(Disk dsk);
        List<Disk> GetAllDisks();
        List<string> GetNamesOfDisks();

        void SaveCatalog();
        bool IsEmptyOrWhiteSpace(string name);
    }
}
