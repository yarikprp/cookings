namespace kulinaria_app_v2.Forms
{
    partial class DishAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishAddForm));
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonDelProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.textBoxProdWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxDishImage = new System.Windows.Forms.PictureBox();
            this.comboBoxBase = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDishName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вес";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукт";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1019, 610);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewProducts.Location = new System.Drawing.Point(77, 377);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.Size = new System.Drawing.Size(485, 236);
            this.dataGridViewProducts.TabIndex = 38;
            // 
            // buttonDelProd
            // 
            this.buttonDelProd.Location = new System.Drawing.Point(599, 377);
            this.buttonDelProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelProd.Name = "buttonDelProd";
            this.buttonDelProd.Size = new System.Drawing.Size(100, 28);
            this.buttonDelProd.TabIndex = 37;
            this.buttonDelProd.Text = "Удалить";
            this.buttonDelProd.UseVisualStyleBackColor = true;
            this.buttonDelProd.Click += new System.EventHandler(this.buttonDelProd_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Location = new System.Drawing.Point(599, 324);
            this.buttonAddProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(100, 28);
            this.buttonAddProd.TabIndex = 36;
            this.buttonAddProd.Text = "Добавить";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // textBoxProdWeight
            // 
            this.textBoxProdWeight.Location = new System.Drawing.Point(391, 325);
            this.textBoxProdWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProdWeight.Name = "textBoxProdWeight";
            this.textBoxProdWeight.Size = new System.Drawing.Size(132, 22);
            this.textBoxProdWeight.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Вес";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(147, 325);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProducts.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Продукт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Добавить состав блюда";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(1020, 15);
            this.buttonChooseImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(100, 28);
            this.buttonChooseImage.TabIndex = 30;
            this.buttonChooseImage.Text = "Выбрать";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // pictureBoxDishImage
            // 
            this.pictureBoxDishImage.Location = new System.Drawing.Point(751, 14);
            this.pictureBoxDishImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDishImage.Name = "pictureBoxDishImage";
            this.pictureBoxDishImage.Size = new System.Drawing.Size(261, 207);
            this.pictureBoxDishImage.TabIndex = 29;
            this.pictureBoxDishImage.TabStop = false;
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Location = new System.Drawing.Point(185, 90);
            this.comboBoxBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.Size = new System.Drawing.Size(160, 24);
            this.comboBoxBase.TabIndex = 28;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(185, 49);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxType.TabIndex = 27;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(185, 132);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(132, 22);
            this.textBoxWeight.TabIndex = 26;
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Location = new System.Drawing.Point(185, 7);
            this.textBoxDishName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDishName.Name = "textBoxDishName";
            this.textBoxDishName.Size = new System.Drawing.Size(273, 22);
            this.textBoxDishName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Основа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название блюда";
            // 
            // DishAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 719);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonDelProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.textBoxProdWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonChooseImage);
            this.Controls.Add(this.pictureBoxDishImage);
            this.Controls.Add(this.comboBoxBase);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxDishName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DishAddForm";
            this.Text = "Добавление блюда";
            this.Load += new System.EventHandler(this.DishAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonDelProd;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.TextBox textBoxProdWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.PictureBox pictureBoxDishImage;
        private System.Windows.Forms.ComboBox comboBoxBase;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDishName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}