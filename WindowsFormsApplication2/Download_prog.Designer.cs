namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Way_to_save = new System.Windows.Forms.Button();
            this.Text_way_to_save = new System.Windows.Forms.TextBox();
            this.Link_to_manga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_parts = new System.Windows.Forms.Button();
            this.Select_all = new System.Windows.Forms.Button();
            this.Select_no = new System.Windows.Forms.Button();
            this.Download_this = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.About_found = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.display_link = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.down_paret_now = new System.Windows.Forms.Label();
            this.convert_cbr = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adress = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Found_parts = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_volume_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.volume_tree = new System.Windows.Forms.TreeView();
            this.volume_count = new System.Windows.Forms.Button();
            this.volume_number = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_number)).BeginInit();
            this.SuspendLayout();
            // 
            // Way_to_save
            // 
            this.Way_to_save.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Way_to_save.Location = new System.Drawing.Point(459, 7);
            this.Way_to_save.Name = "Way_to_save";
            this.Way_to_save.Size = new System.Drawing.Size(203, 32);
            this.Way_to_save.TabIndex = 0;
            this.Way_to_save.Text = "Выбрать путь сохранения";
            this.Way_to_save.UseVisualStyleBackColor = true;
            this.Way_to_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_way_to_save
            // 
            this.Text_way_to_save.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_way_to_save.Location = new System.Drawing.Point(5, 12);
            this.Text_way_to_save.Name = "Text_way_to_save";
            this.Text_way_to_save.Size = new System.Drawing.Size(447, 27);
            this.Text_way_to_save.TabIndex = 2;
            this.Text_way_to_save.Enter += new System.EventHandler(this.Text_way_to_save_Enter);
            this.Text_way_to_save.Leave += new System.EventHandler(this.Text_way_to_save_Leave);
            // 
            // Link_to_manga
            // 
            this.Link_to_manga.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_to_manga.Location = new System.Drawing.Point(5, 45);
            this.Link_to_manga.Name = "Link_to_manga";
            this.Link_to_manga.Size = new System.Drawing.Size(447, 27);
            this.Link_to_manga.TabIndex = 5;
            this.Link_to_manga.Enter += new System.EventHandler(this.Link_to_manga_Enter);
            this.Link_to_manga.Leave += new System.EventHandler(this.Link_to_manga_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Найденые главы";
            // 
            // Search_parts
            // 
            this.Search_parts.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_parts.Location = new System.Drawing.Point(459, 42);
            this.Search_parts.Name = "Search_parts";
            this.Search_parts.Size = new System.Drawing.Size(203, 32);
            this.Search_parts.TabIndex = 7;
            this.Search_parts.Text = "Поиск глав по ссылке";
            this.Search_parts.UseVisualStyleBackColor = true;
            this.Search_parts.Click += new System.EventHandler(this.Search_parts_Click);
            // 
            // Select_all
            // 
            this.Select_all.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_all.Location = new System.Drawing.Point(457, 114);
            this.Select_all.Name = "Select_all";
            this.Select_all.Size = new System.Drawing.Size(105, 52);
            this.Select_all.TabIndex = 8;
            this.Select_all.Text = "Выбрать все";
            this.Select_all.UseVisualStyleBackColor = true;
            this.Select_all.Click += new System.EventHandler(this.Select_all_Click);
            // 
            // Select_no
            // 
            this.Select_no.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_no.Location = new System.Drawing.Point(454, 205);
            this.Select_no.Name = "Select_no";
            this.Select_no.Size = new System.Drawing.Size(105, 72);
            this.Select_no.TabIndex = 9;
            this.Select_no.Text = "Снять выбор со всех";
            this.Select_no.UseVisualStyleBackColor = true;
            this.Select_no.Click += new System.EventHandler(this.Select_no_Click);
            // 
            // Download_this
            // 
            this.Download_this.Font = new System.Drawing.Font("Impress BT Cyr", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_this.Location = new System.Drawing.Point(349, 475);
            this.Download_this.Name = "Download_this";
            this.Download_this.Size = new System.Drawing.Size(165, 177);
            this.Download_this.TabIndex = 10;
            this.Download_this.Text = "Начать скачивание выбраных глав";
            this.Download_this.UseVisualStyleBackColor = true;
            this.Download_this.Click += new System.EventHandler(this.Download_this_Click);
            // 
            // About
            // 
            this.About.Enabled = false;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.Location = new System.Drawing.Point(711, 606);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(158, 48);
            this.About.TabIndex = 11;
            this.About.Text = "О программе";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // About_found
            // 
            this.About_found.AutoSize = true;
            this.About_found.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_found.Location = new System.Drawing.Point(299, 77);
            this.About_found.Name = "About_found";
            this.About_found.Size = new System.Drawing.Size(103, 21);
            this.About_found.TabIndex = 12;
            this.About_found.Text = "Найдено глав";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ForeColor = System.Drawing.Color.Green;
            this.status.Location = new System.Drawing.Point(544, 576);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 14;
            this.status.Text = "Состояние ОК";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(548, 541);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(427, 21);
            this.progressBar1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(543, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(558, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Прогресс скачивания текущей главы. Во время скачивания в программе невозможно про" +
    "изводить другие действия.";
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.Location = new System.Drawing.Point(875, 613);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(158, 34);
            this.stop.TabIndex = 19;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // display_link
            // 
            this.display_link.AutoSize = true;
            this.display_link.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display_link.Location = new System.Drawing.Point(544, 454);
            this.display_link.Name = "display_link";
            this.display_link.Size = new System.Drawing.Size(449, 21);
            this.display_link.TabIndex = 20;
            this.display_link.Text = "Ссылка на закачиваемую страницу: Закачка не производится";
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause.Location = new System.Drawing.Point(547, 600);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(158, 34);
            this.pause.TabIndex = 21;
            this.pause.Text = "Пауза";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // down_paret_now
            // 
            this.down_paret_now.AutoSize = true;
            this.down_paret_now.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.down_paret_now.Location = new System.Drawing.Point(544, 475);
            this.down_paret_now.Name = "down_paret_now";
            this.down_paret_now.Size = new System.Drawing.Size(337, 21);
            this.down_paret_now.TabIndex = 27;
            this.down_paret_now.Text = "Скачиваемая глава: Закачка не производится";
            // 
            // convert_cbr
            // 
            this.convert_cbr.AutoSize = true;
            this.convert_cbr.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convert_cbr.Location = new System.Drawing.Point(317, 447);
            this.convert_cbr.Name = "convert_cbr";
            this.convert_cbr.Size = new System.Drawing.Size(224, 25);
            this.convert_cbr.TabIndex = 31;
            this.convert_cbr.Text = "Конвертировать главы в cbr";
            this.convert_cbr.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adress,
            this.Language});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(289, 187);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Adress
            // 
            this.Adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Impress BT Cyr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Adress.DefaultCellStyle = dataGridViewCellStyle13;
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Adress.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Adress.Width = 58;
            // 
            // Language
            // 
            this.Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Impress BT Cyr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Language.DefaultCellStyle = dataGridViewCellStyle14;
            this.Language.HeaderText = "Язык";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Language.Width = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 216);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список поддерживаемых сайтов";
            // 
            // Found_parts
            // 
            this.Found_parts.ContextMenuStrip = this.contextMenuStrip1;
            this.Found_parts.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Found_parts.FormattingEnabled = true;
            this.Found_parts.ItemHeight = 21;
            this.Found_parts.Location = new System.Drawing.Point(5, 101);
            this.Found_parts.Name = "Found_parts";
            this.Found_parts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Found_parts.Size = new System.Drawing.Size(446, 340);
            this.Found_parts.TabIndex = 35;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_volume_menu,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // add_volume_menu
            // 
            this.add_volume_menu.Name = "add_volume_menu";
            this.add_volume_menu.Size = new System.Drawing.Size(174, 26);
            this.add_volume_menu.Text = "Добавить";
            this.add_volume_menu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.add_volume_menu_DropDownItemClicked);
            this.add_volume_menu.Click += new System.EventHandler(this.add_volume_menu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem1.Text = "Очистить том";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.volume_tree);
            this.groupBox2.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(565, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 374);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Глав для скачивания: 0";
            // 
            // volume_tree
            // 
            this.volume_tree.AllowDrop = true;
            this.volume_tree.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume_tree.Location = new System.Drawing.Point(6, 24);
            this.volume_tree.Name = "volume_tree";
            this.volume_tree.Size = new System.Drawing.Size(410, 340);
            this.volume_tree.TabIndex = 41;
            this.volume_tree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.volume_tree_BeforeSelect);
            this.volume_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.volume_tree_AfterSelect);
            // 
            // volume_count
            // 
            this.volume_count.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume_count.Location = new System.Drawing.Point(454, 314);
            this.volume_count.Name = "volume_count";
            this.volume_count.Size = new System.Drawing.Size(108, 56);
            this.volume_count.TabIndex = 40;
            this.volume_count.Text = "Количество томов";
            this.volume_count.UseVisualStyleBackColor = true;
            this.volume_count.Click += new System.EventHandler(this.volume_count_Click);
            // 
            // volume_number
            // 
            this.volume_number.AutoSize = true;
            this.volume_number.Font = new System.Drawing.Font("Impress BT Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume_number.Location = new System.Drawing.Point(471, 376);
            this.volume_number.Name = "volume_number";
            this.volume_number.Size = new System.Drawing.Size(70, 34);
            this.volume_number.TabIndex = 44;
            this.volume_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 662);
            this.Controls.Add(this.volume_number);
            this.Controls.Add(this.volume_count);
            this.Controls.Add(this.Select_no);
            this.Controls.Add(this.Select_all);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Found_parts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convert_cbr);
            this.Controls.Add(this.down_paret_now);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.display_link);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.About_found);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Download_this);
            this.Controls.Add(this.Search_parts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Link_to_manga);
            this.Controls.Add(this.Text_way_to_save);
            this.Controls.Add(this.Way_to_save);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volume_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Way_to_save;
        private System.Windows.Forms.TextBox Text_way_to_save;
        private System.Windows.Forms.TextBox Link_to_manga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_parts;
        private System.Windows.Forms.Button Select_all;
        private System.Windows.Forms.Button Select_no;
        private System.Windows.Forms.Button Download_this;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label About_found;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label display_link;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Label down_paret_now;
        private System.Windows.Forms.CheckBox convert_cbr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewLinkColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Found_parts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button volume_count;
        private System.Windows.Forms.TreeView volume_tree;
        private System.Windows.Forms.NumericUpDown volume_number;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem add_volume_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

