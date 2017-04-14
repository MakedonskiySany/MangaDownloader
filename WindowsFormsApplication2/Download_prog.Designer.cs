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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Way_to_save = new System.Windows.Forms.Button();
            this.Found_parts = new System.Windows.Forms.CheckedListBox();
            this.Text_way_to_save = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Link_to_manga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_parts = new System.Windows.Forms.Button();
            this.Select_all = new System.Windows.Forms.Button();
            this.Select_no = new System.Windows.Forms.Button();
            this.Download_this = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.About_found = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Way_to_save
            // 
            this.Way_to_save.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Way_to_save.Location = new System.Drawing.Point(458, 73);
            this.Way_to_save.Name = "Way_to_save";
            this.Way_to_save.Size = new System.Drawing.Size(203, 32);
            this.Way_to_save.TabIndex = 0;
            this.Way_to_save.Text = "Выбрать путь сохранения";
            this.Way_to_save.UseVisualStyleBackColor = true;
            this.Way_to_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Found_parts
            // 
            this.Found_parts.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Found_parts.FormattingEnabled = true;
            this.Found_parts.Location = new System.Drawing.Point(5, 184);
            this.Found_parts.Name = "Found_parts";
            this.Found_parts.Size = new System.Drawing.Size(447, 334);
            this.Found_parts.TabIndex = 0;
            this.Found_parts.TabStop = false;
            this.Found_parts.UseTabStops = false;
            // 
            // Text_way_to_save
            // 
            this.Text_way_to_save.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_way_to_save.Location = new System.Drawing.Point(6, 76);
            this.Text_way_to_save.Name = "Text_way_to_save";
            this.Text_way_to_save.Size = new System.Drawing.Size(447, 27);
            this.Text_way_to_save.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Место сохранения файлов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ссылка на мангу";
            // 
            // Link_to_manga
            // 
            this.Link_to_manga.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_to_manga.Location = new System.Drawing.Point(6, 130);
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
            this.label3.Location = new System.Drawing.Point(5, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Найденые главы";
            // 
            // Search_parts
            // 
            this.Search_parts.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_parts.Location = new System.Drawing.Point(459, 127);
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
            this.Select_all.Location = new System.Drawing.Point(458, 184);
            this.Select_all.Name = "Select_all";
            this.Select_all.Size = new System.Drawing.Size(203, 30);
            this.Select_all.TabIndex = 8;
            this.Select_all.Text = "Выбрать все";
            this.Select_all.UseVisualStyleBackColor = true;
            this.Select_all.Click += new System.EventHandler(this.Select_all_Click);
            // 
            // Select_no
            // 
            this.Select_no.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_no.Location = new System.Drawing.Point(458, 220);
            this.Select_no.Name = "Select_no";
            this.Select_no.Size = new System.Drawing.Size(203, 30);
            this.Select_no.TabIndex = 9;
            this.Select_no.Text = "Снять выбор со всех";
            this.Select_no.UseVisualStyleBackColor = true;
            this.Select_no.Click += new System.EventHandler(this.Select_no_Click);
            // 
            // Download_this
            // 
            this.Download_this.Font = new System.Drawing.Font("Impress BT Cyr", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_this.Location = new System.Drawing.Point(458, 286);
            this.Download_this.Name = "Download_this";
            this.Download_this.Size = new System.Drawing.Size(203, 127);
            this.Download_this.TabIndex = 10;
            this.Download_this.Text = "Начать скачивание выбраных глав";
            this.Download_this.UseVisualStyleBackColor = true;
            this.Download_this.Click += new System.EventHandler(this.Download_this_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About.Location = new System.Drawing.Point(458, 499);
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
            this.About_found.Location = new System.Drawing.Point(300, 160);
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
            this.status.Location = new System.Drawing.Point(110, 609);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 14;
            this.status.Text = "Состояние ОК";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impress BT Cyr", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(804, 49);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 594);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(597, 12);
            this.progressBar1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Прогресс скачивания текущей главы. Во время скачивания в программе невозможно про" +
    "изводить другие действия.";
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.Location = new System.Drawing.Point(458, 459);
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
            this.display_link.Location = new System.Drawing.Point(2, 547);
            this.display_link.Name = "display_link";
            this.display_link.Size = new System.Drawing.Size(324, 13);
            this.display_link.TabIndex = 20;
            this.display_link.Text = "Ссылка на закачиваемую страницу: Закачка не производится";
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause.Location = new System.Drawing.Point(458, 419);
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
            this.down_paret_now.Location = new System.Drawing.Point(2, 562);
            this.down_paret_now.Name = "down_paret_now";
            this.down_paret_now.Size = new System.Drawing.Size(244, 13);
            this.down_paret_now.TabIndex = 27;
            this.down_paret_now.Text = "Скачиваемая глава: Закачка не производится";
            // 
            // convert_cbr
            // 
            this.convert_cbr.AutoSize = true;
            this.convert_cbr.Font = new System.Drawing.Font("Impress BT Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convert_cbr.Location = new System.Drawing.Point(458, 255);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(667, 360);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impress BT Cyr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Adress.DefaultCellStyle = dataGridViewCellStyle1;
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Adress.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Adress.Width = 44;
            // 
            // Language
            // 
            this.Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impress BT Cyr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Language.DefaultCellStyle = dataGridViewCellStyle2;
            this.Language.HeaderText = "Язык";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Language.Width = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.convert_cbr);
            this.Controls.Add(this.down_paret_now);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.display_link);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.About_found);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Download_this);
            this.Controls.Add(this.Select_no);
            this.Controls.Add(this.Select_all);
            this.Controls.Add(this.Search_parts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Link_to_manga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_way_to_save);
            this.Controls.Add(this.Found_parts);
            this.Controls.Add(this.Way_to_save);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Way_to_save;
        private System.Windows.Forms.CheckedListBox Found_parts;
        private System.Windows.Forms.TextBox Text_way_to_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Link_to_manga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_parts;
        private System.Windows.Forms.Button Select_all;
        private System.Windows.Forms.Button Select_no;
        private System.Windows.Forms.Button Download_this;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label About_found;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
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
    }
}

