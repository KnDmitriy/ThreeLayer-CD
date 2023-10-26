using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayer.BLL;
using ThreeLayer.Common;
using ThreeLayer.Entities;


namespace ThreeLayer.PL
{
    public partial class Form1 : Form
    {
        IDiskLogic logic = DependencyResolver.DiskLogic_;

        Disk Selected_Disk;
        Disk.SongAndSinger Selected_Song;
        Disk Add_Disk;
        Disk.SongAndSinger Add_Song;
        string Searched_Song;
        string Searched_Song_Switch;
        List<Disk> disks = new List<Disk>();
        List<Disk> searchedDisks = new List<Disk>();
        public Form1() 
        {
            InitializeComponent();
            logic.SortDisks();
            disks = logic.GetAllDisks();
            
            foreach (Disk disk in disks)
            {
                if(disk != null)
                {
                    Form_Disks.Items.Add(disk.NameOfDisk);
                }
                
            }
            
            
            Form_Disks.Sorted = true;
            Form_Disks.DisplayMember = "diskName";

            Form_Disks.SelectedIndex = -1;
            Form_Songs.SelectedIndex = -1;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_Songs.Items.Clear();
            //if (_Disks_.SelectedItem != null)
            /*
            if(Form_Disks.SelectedIndex >= 0)
            {
                Selected_Disk = Disk(Form_Disks.SelectedItem.ToString());
                foreach (var item in catalog_.GetSongsOfTheDisk(Form_Disks.SelectedItem.ToString()))
                {

                }
            }
            else
            {
                _Songs_.Items.Clear();
            }
            */
            if (Form_Disks.SelectedIndex >= 0)
            {
                if (SortingBy.SelectedIndex <= 0)
                    logic.SortSongsInCatalogBySinger();
                else
                    logic.SortSongsInCatalogBySong();
                Selected_Disk = logic.GetDisk((string)Form_Disks.Items[Form_Disks.SelectedIndex]);
                List<string> res = logic.GetSongsOfTheDisk(Selected_Disk);
                //Selected_Disk.disk;
                foreach (string item in res)
                {
                    Form_Songs.Items.Add(item);
                }
                
            }
            else
            {
                Form_Disks.SelectedIndex = -1;
            }
        }

        private void _Songs__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Disk = new Disk(DiskName.Text);
            if(Add_Disk.NameOfDisk != "")
            {
                if(logic.FindDisk(DiskName.Text) == null)
                {
                    Form_Disks.Items.Add(Add_Disk.NameOfDisk);
                    logic.AddDisk(Add_Disk);
                    logic.SortDisks();
                    DiskName.Clear();
                }
                else
                {
                    MessageBox.Show("Невозможно добавить диск с именем, которое уже существует в списке дисков.");
                }
            }
            else
            {
                MessageBox.Show("Введите название диска.");
            }
            
        }

      

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Form_Songs.SelectedIndex >= 0)
            {
                
                int selectedIndexSong = Form_Songs.SelectedIndex;
                int selectedIndexDisk = Form_Disks.SelectedIndex;
                Disk.SongAndSinger Sas = new Disk.SongAndSinger(disks[selectedIndexDisk].disk[selectedIndexSong].Singer, disks[selectedIndexDisk].disk[Form_Songs.SelectedIndex].Song);                Form_Songs.Items.Remove(Sas);
                Form_Songs.Items.Remove(disks[selectedIndexDisk].disk[selectedIndexSong].ToString());
                logic.RemoveSong(disks[selectedIndexDisk].disk[selectedIndexSong], disks[selectedIndexDisk]);
            }
            else 
            {
                MessageBox.Show("Выберите композицию из списка композиций, которую хотите удалить.");
            }
        }

        private void BtnRemoveDisk_Click(object sender, EventArgs e)
        {
            if(Form_Disks.SelectedIndex >= 0)
            {
                int selectedIndex = Form_Disks.SelectedIndex;
                Form_Disks.Items.Remove(disks[Form_Disks.SelectedIndex].NameOfDisk);
                logic.RemoveDisk(disks[selectedIndex]);
            }
            else
            {
                MessageBox.Show("Выберите диск, который хотите удалить.");
            }
            
            
        }

        private void BtnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temp = AddSongNameForm.Text.Split(new[] { " - " }, StringSplitOptions.None);
                Add_Song = new Disk.SongAndSinger(temp[0], temp[1]);
                if (!logic.IsEmptyOrWhiteSpace(Add_Song.Singer) && !logic.IsEmptyOrWhiteSpace(Add_Song.Song)
                    && Form_Disks.SelectedIndex >= 0)
                {
                    if (logic.IsSongUniqueInTheDisk(Add_Song, disks[Form_Disks.SelectedIndex]))
                    {
                        logic.AddSong(Add_Song, disks[Form_Disks.SelectedIndex]);
                        logic.SortSongsInCatalogBySinger();
                        Form_Songs.Items.Insert(logic.IndexOfSongInDisk(Add_Song, disks[Form_Disks.SelectedIndex]), Add_Song);
                        AddSongNameForm.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Невозможно добавить одинаковые композиции на один диск.");
                    }
                }
                else if(Form_Disks.SelectedIndex < 0)
                {
                    MessageBox.Show("Выберите диск, в который хотите добавить композицию.");
                }
                else
                {
                    MessageBox.Show("Введите песню в формате: исполнитель - название композиции.");
                }
            }
            catch
            {
                MessageBox.Show("Введите песню в формате: исполнитель - название композиции.");
            }
            
        }

        private void SongName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddSearchedSong_Click(object sender, EventArgs e)
        {
            if (SearchName.Text != "" && SearchingBy.SelectedIndex >= 0)
            {
                SearchedDisks.Items.Clear();
                SearchedSongs.Items.Clear();

                searchedDisks = logic.FindSongs(SearchName.Text, SearchingBy.Items[SearchingBy.SelectedIndex].ToString());
                if(searchedDisks.Count > 0)
                {
                    foreach (Disk disk in searchedDisks)
                    {
                        SearchedDisks.Items.Add(disk.NameOfDisk);
                    }
                }
                else
                {
                    if (SearchingBy.SelectedIndex == 0)
                        MessageBox.Show("Композиций данного исполнителя нет на данных дисках.");
                    else
                        MessageBox.Show("Композиций с данным названием нет на данных дисках.");
                }
                
            }
            else if(SearchName.Text == "")
            {
                MessageBox.Show("Введите исполнителя или название композиции, чтобы осуществить поиск.");
            }
            else if(SearchingBy.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите, какой поиск Вы хотите осуществлять: по исполнителю или по названию композиции.");
            }
          
        }

        private void SearchedDisks_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchedSongs.Items.Clear();
            
            foreach (Disk.SongAndSinger song in searchedDisks[SearchedDisks.SelectedIndex].disk)
            {
                SearchedSongs.Items.Add(song.ToString());
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            logic.SaveCatalog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите сохранить изменения во внесенные данные о дисках и композициях?", "Запрос на сохранение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                logic.SaveCatalog();
            }
        }

        private void DiskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiskName_Click(object sender, EventArgs e)
        {

        }

        private void DiskName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void SortungBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1_SelectedIndexChanged(sender, e);
        }

        private void SearchingBy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
