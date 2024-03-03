namespace kulinaria_app_v2.Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.numericUpDownCarboh = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarboh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProt)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCarboh
            // 
            this.numericUpDownCarboh.Location = new System.Drawing.Point(195, 233);
            this.numericUpDownCarboh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCarboh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCarboh.Name = "numericUpDownCarboh";
            this.numericUpDownCarboh.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownCarboh.TabIndex = 21;
            // 
            // numericUpDownFats
            // 
            this.numericUpDownFats.Location = new System.Drawing.Point(195, 193);
            this.numericUpDownFats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownFats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFats.Name = "numericUpDownFats";
            this.numericUpDownFats.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownFats.TabIndex = 20;
            // 
            // numericUpDownProt
            // 
            this.numericUpDownProt.Location = new System.Drawing.Point(195, 151);
            this.numericUpDownProt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownProt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownProt.Name = "numericUpDownProt";
            this.numericUpDownProt.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownProt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Добавление продукта";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 112);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 22);
            this.textBoxName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Углеводы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Жиры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Белки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 321);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 395);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownCarboh);
            this.Controls.Add(this.numericUpDownFats);
            this.Controls.Add(this.numericUpDownProt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProductForm";
            this.Text = "Добавить продукт";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarboh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCarboh;
        private System.Windows.Forms.NumericUpDown numericUpDownFats;
        private System.Windows.Forms.NumericUpDown numericUpDownProt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
    }
}