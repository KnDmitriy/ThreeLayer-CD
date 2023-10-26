namespace ThreeLayer.PL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Form_Disks = new System.Windows.Forms.ListBox();
            this.Form_Songs = new System.Windows.Forms.ListBox();
            this.DiskName = new System.Windows.Forms.TextBox();
            this.btnAddDisk = new System.Windows.Forms.Button();
            this.btnRemoveDisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSongNameForm = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchingBy = new System.Windows.Forms.ListBox();
            this.btnSearchSong = new System.Windows.Forms.Button();
            this.SearchedDisks = new System.Windows.Forms.ListBox();
            this.SearchedSongs = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SortingBy = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Form_Disks
            // 
            this.Form_Disks.FormattingEnabled = true;
            this.Form_Disks.Location = new System.Drawing.Point(12, 188);
            this.Form_Disks.Name = "Form_Disks";
            this.Form_Disks.Size = new System.Drawing.Size(159, 186);
            this.Form_Disks.TabIndex = 0;
            this.Form_Disks.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Form_Songs
            // 
            this.Form_Songs.FormattingEnabled = true;
            this.Form_Songs.Location = new System.Drawing.Point(177, 188);
            this.Form_Songs.Name = "Form_Songs";
            this.Form_Songs.Size = new System.Drawing.Size(162, 186);
            this.Form_Songs.TabIndex = 1;
            this.Form_Songs.SelectedIndexChanged += new System.EventHandler(this._Songs__SelectedIndexChanged);
            // 
            // DiskName
            // 
            this.DiskName.Location = new System.Drawing.Point(12, 54);
            this.DiskName.Name = "DiskName";
            this.DiskName.Size = new System.Drawing.Size(159, 20);
            this.DiskName.TabIndex = 2;
            this.DiskName.Click += new System.EventHandler(this.DiskName_Click);
            this.DiskName.TextChanged += new System.EventHandler(this.DiskName_TextChanged);
            this.DiskName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiskName_KeyPress);
            // 
            // btnAddDisk
            // 
            this.btnAddDisk.Location = new System.Drawing.Point(12, 12);
            this.btnAddDisk.Name = "btnAddDisk";
            this.btnAddDisk.Size = new System.Drawing.Size(159, 23);
            this.btnAddDisk.TabIndex = 3;
            this.btnAddDisk.Text = "Добавить";
            this.btnAddDisk.UseVisualStyleBackColor = true;
            this.btnAddDisk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRemoveDisk
            // 
            this.btnRemoveDisk.Location = new System.Drawing.Point(12, 80);
            this.btnRemoveDisk.Name = "btnRemoveDisk";
            this.btnRemoveDisk.Size = new System.Drawing.Size(159, 23);
            this.btnRemoveDisk.TabIndex = 4;
            this.btnRemoveDisk.Text = "Удалить";
            this.btnRemoveDisk.UseVisualStyleBackColor = true;
            this.btnRemoveDisk.Click += new System.EventHandler(this.BtnRemoveDisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название диска:";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(177, 12);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(159, 23);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.Text = "Добавить";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.BtnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(177, 81);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(159, 23);
            this.btnRemoveSong.TabIndex = 7;
            this.btnRemoveSong.Text = "Удалить";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Композиция:";
            // 
            // AddSongNameForm
            // 
            this.AddSongNameForm.Location = new System.Drawing.Point(177, 55);
            this.AddSongNameForm.Name = "AddSongNameForm";
            this.AddSongNameForm.Size = new System.Drawing.Size(162, 20);
            this.AddSongNameForm.TabIndex = 8;
            this.AddSongNameForm.TextChanged += new System.EventHandler(this.SongName_TextChanged);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(345, 25);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(164, 20);
            this.SearchName.TabIndex = 10;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск по:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // SearchingBy
            // 
            this.SearchingBy.FormattingEnabled = true;
            this.SearchingBy.Items.AddRange(new object[] {
            "Исполнителю",
            "Названию композиции"});
            this.SearchingBy.Location = new System.Drawing.Point(345, 106);
            this.SearchingBy.Name = "SearchingBy";
            this.SearchingBy.Size = new System.Drawing.Size(164, 30);
            this.SearchingBy.TabIndex = 13;
            this.SearchingBy.SelectedIndexChanged += new System.EventHandler(this.SearchingBy_SelectedIndexChanged);
            // 
            // btnSearchSong
            // 
            this.btnSearchSong.Location = new System.Drawing.Point(345, 52);
            this.btnSearchSong.Name = "btnSearchSong";
            this.btnSearchSong.Size = new System.Drawing.Size(164, 23);
            this.btnSearchSong.TabIndex = 14;
            this.btnSearchSong.Text = "Поиск";
            this.btnSearchSong.UseVisualStyleBackColor = true;
            this.btnSearchSong.Click += new System.EventHandler(this.BtnAddSearchedSong_Click);
            this.btnSearchSong.Enter += new System.EventHandler(this.BtnAddSearchedSong_Click);
            // 
            // SearchedDisks
            // 
            this.SearchedDisks.FormattingEnabled = true;
            this.SearchedDisks.Location = new System.Drawing.Point(345, 142);
            this.SearchedDisks.Name = "SearchedDisks";
            this.SearchedDisks.Size = new System.Drawing.Size(164, 95);
            this.SearchedDisks.TabIndex = 15;
            this.SearchedDisks.SelectedIndexChanged += new System.EventHandler(this.SearchedDisks_SelectedIndexChanged);
            // 
            // SearchedSongs
            // 
            this.SearchedSongs.FormattingEnabled = true;
            this.SearchedSongs.Location = new System.Drawing.Point(345, 240);
            this.SearchedSongs.Name = "SearchedSongs";
            this.SearchedSongs.Size = new System.Drawing.Size(164, 134);
            this.SearchedSongs.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Диски:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Композиции:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(537, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 35);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Сортировка по:";
            // 
            // SortingBy
            // 
            this.SortingBy.FormattingEnabled = true;
            this.SortingBy.Items.AddRange(new object[] {
            "Исполнителю",
            "Названию композиции"});
            this.SortingBy.Location = new System.Drawing.Point(177, 139);
            this.SortingBy.Name = "SortingBy";
            this.SortingBy.Size = new System.Drawing.Size(164, 30);
            this.SortingBy.TabIndex = 21;
            this.SortingBy.SelectedIndexChanged += new System.EventHandler(this.SortungBy_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 382);
            this.Controls.Add(this.SortingBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchedSongs);
            this.Controls.Add(this.SearchedDisks);
            this.Controls.Add(this.btnSearchSong);
            this.Controls.Add(this.SearchingBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddSongNameForm);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDisk);
            this.Controls.Add(this.btnAddDisk);
            this.Controls.Add(this.DiskName);
            this.Controls.Add(this.Form_Songs);
            this.Controls.Add(this.Form_Disks);
            this.Name = "Form1";
            this.Text = "Каталог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Form_Disks;
        private System.Windows.Forms.ListBox Form_Songs;
        private System.Windows.Forms.TextBox DiskName;
        private System.Windows.Forms.Button btnAddDisk;
        private System.Windows.Forms.Button btnRemoveDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddSongNameForm;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SearchingBy;
        private System.Windows.Forms.Button btnSearchSong;
        private System.Windows.Forms.ListBox SearchedDisks;
        private System.Windows.Forms.ListBox SearchedSongs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox SortingBy;
    }
}

