namespace kulinaria_app_v2.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelDishName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxStructure = new System.Windows.Forms.ListBox();
            this.dataGridViewDishes = new System.Windows.Forms.DataGridView();
            this.comboBoxTypeOfDish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchOfDish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDishName
            // 
            this.labelDishName.AutoSize = true;
            this.labelDishName.Location = new System.Drawing.Point(1048, 133);
            this.labelDishName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDishName.Name = "labelDishName";
            this.labelDishName.Size = new System.Drawing.Size(44, 16);
            this.labelDishName.TabIndex = 19;
            this.labelDishName.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Состав блюда";
            // 
            // Exit
            // 
            this.Exit.HeaderText = "Вес";
            this.Exit.MinimumWidth = 6;
            this.Exit.Name = "Exit";
            this.Exit.Width = 125;
            // 
            // Base
            // 
            this.Base.HeaderText = "Основа";
            this.Base.MinimumWidth = 6;
            this.Base.Name = "Base";
            this.Base.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Категория";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // DishName
            // 
            this.DishName.HeaderText = "Название";
            this.DishName.MinimumWidth = 6;
            this.DishName.Name = "DishName";
            this.DishName.Width = 125;
            // 
            // Image
            // 
            this.Image.HeaderText = "Картинка";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 80;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 80;
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // listBoxStructure
            // 
            this.listBoxStructure.FormattingEnabled = true;
            this.listBoxStructure.ItemHeight = 16;
            this.listBoxStructure.Location = new System.Drawing.Point(908, 190);
            this.listBoxStructure.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStructure.Name = "listBoxStructure";
            this.listBoxStructure.Size = new System.Drawing.Size(272, 260);
            this.listBoxStructure.TabIndex = 18;
            // 
            // dataGridViewDishes
            // 
            this.dataGridViewDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Image,
            this.DishName,
            this.Type,
            this.Base,
            this.Exit});
            this.dataGridViewDishes.Location = new System.Drawing.Point(16, 133);
            this.dataGridViewDishes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDishes.Name = "dataGridViewDishes";
            this.dataGridViewDishes.RowHeadersWidth = 51;
            this.dataGridViewDishes.RowTemplate.Height = 50;
            this.dataGridViewDishes.Size = new System.Drawing.Size(857, 438);
            this.dataGridViewDishes.TabIndex = 16;
            this.dataGridViewDishes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDishes_CellDoubleClick);
            // 
            // comboBoxTypeOfDish
            // 
            this.comboBoxTypeOfDish.FormattingEnabled = true;
            this.comboBoxTypeOfDish.Location = new System.Drawing.Point(540, 84);
            this.comboBoxTypeOfDish.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTypeOfDish.Name = "comboBoxTypeOfDish";
            this.comboBoxTypeOfDish.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTypeOfDish.TabIndex = 15;
            this.comboBoxTypeOfDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfDish_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Категория";
            // 
            // textBoxSearchOfDish
            // 
            this.textBoxSearchOfDish.Location = new System.Drawing.Point(157, 84);
            this.textBoxSearchOfDish.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchOfDish.Name = "textBoxSearchOfDish";
            this.textBoxSearchOfDish.Size = new System.Drawing.Size(236, 22);
            this.textBoxSearchOfDish.TabIndex = 13;
            this.textBoxSearchOfDish.TextChanged += new System.EventHandler(this.textBoxSearchOfDish_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск блюда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Меню";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem,
            this.продуктToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.fIOToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStripMainMenu";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБлюдоToolStripMenuItem,
            this.удалитьБлюдоToolStripMenuItem,
            this.поискПоКритериямToolStripMenuItem});
            this.блюдаToolStripMenuItem.Image = global::kulinaria_app_v2.Properties.Resources.dish;
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            // 
            // добавитьБлюдоToolStripMenuItem
            // 
            this.добавитьБлюдоToolStripMenuItem.Name = "добавитьБлюдоToolStripMenuItem";
            this.добавитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.добавитьБлюдоToolStripMenuItem.Text = "Добавить блюдо";
            this.добавитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлюдоToolStripMenuItem_Click);
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            this.удалитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.удалитьБлюдоToolStripMenuItem_Click);
            // 
            // поискПоКритериямToolStripMenuItem
            // 
            this.поискПоКритериямToolStripMenuItem.Name = "поискПоКритериямToolStripMenuItem";
            this.поискПоКритериямToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.поискПоКритериямToolStripMenuItem.Text = "Поиск по критериям";
            this.поискПоКритериямToolStripMenuItem.Click += new System.EventHandler(this.поискПоКритериямToolStripMenuItem_Click);
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрПродуктовToolStripMenuItem,
            this.добавитьПродуктToolStripMenuItem});
            this.продуктToolStripMenuItem.Image = global::kulinaria_app_v2.Properties.Resources.diet;
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // просмотрПродуктовToolStripMenuItem
            // 
            this.просмотрПродуктовToolStripMenuItem.Name = "просмотрПродуктовToolStripMenuItem";
            this.просмотрПродуктовToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.просмотрПродуктовToolStripMenuItem.Text = "Просмотр продуктов";
            this.просмотрПродуктовToolStripMenuItem.Click += new System.EventHandler(this.просмотрПродуктовToolStripMenuItem_Click);
            // 
            // добавитьПродуктToolStripMenuItem
            // 
            this.добавитьПродуктToolStripMenuItem.Name = "добавитьПродуктToolStripMenuItem";
            this.добавитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.добавитьПродуктToolStripMenuItem.Text = "Добавить продукт";
            this.добавитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.добавитьПродуктToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Image = global::kulinaria_app_v2.Properties.Resources.recipe;
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            this.рецептToolStripMenuItem.Click += new System.EventHandler(this.рецептToolStripMenuItem_Click);
            // 
            // fIOToolStripMenuItem
            // 
            this.fIOToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПрофильToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fIOToolStripMenuItem.Image = global::kulinaria_app_v2.Properties.Resources.profil;
            this.fIOToolStripMenuItem.Name = "fIOToolStripMenuItem";
            this.fIOToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fIOToolStripMenuItem.Text = "FIO";
            // 
            // редактироватьПрофильToolStripMenuItem
            // 
            this.редактироватьПрофильToolStripMenuItem.Name = "редактироватьПрофильToolStripMenuItem";
            this.редактироватьПрофильToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.редактироватьПрофильToolStripMenuItem.Text = "Редактировать профиль";
            this.редактироватьПрофильToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПрофильToolStripMenuItem_Click);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(753, 110);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(0, 16);
            this.selectLabel.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 604);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.labelDishName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxStructure);
            this.Controls.Add(this.dataGridViewDishes);
            this.Controls.Add(this.comboBoxTypeOfDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchOfDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDishName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxStructure;
        private System.Windows.Forms.DataGridView dataGridViewDishes;
        private System.Windows.Forms.ComboBox comboBoxTypeOfDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchOfDish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоКритериямToolStripMenuItem;
        private System.Windows.Forms.Label selectLabel;
    }
}

