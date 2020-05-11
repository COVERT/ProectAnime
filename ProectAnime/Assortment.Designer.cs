namespace ProectAnime
{
    partial class Assortment
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFigurka = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMaska = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxRazmerV = new System.Windows.Forms.TextBox();
            this.textBoxRazmerH = new System.Windows.Forms.TextBox();
            this.textBoxCloor = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelrazmerV = new System.Windows.Forms.Label();
            this.labelrazmerH = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelCloor = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Манга",
            "Фигурки",
            "Маски"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 27);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 28;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader13});
            this.listViewBook.FullRowSelect = true;
            this.listViewBook.GridLines = true;
            this.listViewBook.HideSelection = false;
            this.listViewBook.Location = new System.Drawing.Point(154, 12);
            this.listViewBook.MultiSelect = false;
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(644, 85);
            this.listViewBook.TabIndex = 39;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            this.listViewBook.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "название ";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "количество";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "цена";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Id поставщика";
            this.columnHeader13.Width = 111;
            // 
            // listViewFigurka
            // 
            this.listViewFigurka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewFigurka.FullRowSelect = true;
            this.listViewFigurka.GridLines = true;
            this.listViewFigurka.HideSelection = false;
            this.listViewFigurka.Location = new System.Drawing.Point(154, 12);
            this.listViewFigurka.MultiSelect = false;
            this.listViewFigurka.Name = "listViewFigurka";
            this.listViewFigurka.Size = new System.Drawing.Size(644, 85);
            this.listViewFigurka.TabIndex = 40;
            this.listViewFigurka.UseCompatibleStateImageBehavior = false;
            this.listViewFigurka.View = System.Windows.Forms.View.Details;
            this.listViewFigurka.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "название ";
            this.columnHeader6.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "количество";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "цена";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "высота";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ширина";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Id поставщика";
            this.columnHeader11.Width = 94;
            // 
            // listViewMaska
            // 
            this.listViewMaska.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listViewMaska.FullRowSelect = true;
            this.listViewMaska.GridLines = true;
            this.listViewMaska.HideSelection = false;
            this.listViewMaska.Location = new System.Drawing.Point(154, 12);
            this.listViewMaska.MultiSelect = false;
            this.listViewMaska.Name = "listViewMaska";
            this.listViewMaska.Size = new System.Drawing.Size(644, 85);
            this.listViewMaska.TabIndex = 41;
            this.listViewMaska.UseCompatibleStateImageBehavior = false;
            this.listViewMaska.View = System.Windows.Forms.View.Details;
            this.listViewMaska.Visible = false;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "название ";
            this.columnHeader14.Width = 74;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "количество";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "цена";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "цвет";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Id поставщика";
            this.columnHeader18.Width = 102;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(713, 116);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 44;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(632, 116);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(551, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 45;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(12, 119);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 46;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 159);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 47;
            // 
            // textBoxRazmerV
            // 
            this.textBoxRazmerV.Location = new System.Drawing.Point(12, 199);
            this.textBoxRazmerV.Name = "textBoxRazmerV";
            this.textBoxRazmerV.Size = new System.Drawing.Size(100, 20);
            this.textBoxRazmerV.TabIndex = 48;
            // 
            // textBoxRazmerH
            // 
            this.textBoxRazmerH.Location = new System.Drawing.Point(12, 239);
            this.textBoxRazmerH.Name = "textBoxRazmerH";
            this.textBoxRazmerH.Size = new System.Drawing.Size(100, 20);
            this.textBoxRazmerH.TabIndex = 49;
            // 
            // textBoxCloor
            // 
            this.textBoxCloor.Location = new System.Drawing.Point(12, 315);
            this.textBoxCloor.Name = "textBoxCloor";
            this.textBoxCloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCloor.TabIndex = 51;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 12);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 13);
            this.labelType.TabIndex = 52;
            this.labelType.Text = "категория";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 53;
            this.labelName.Text = "название";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 103);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 13);
            this.labelQuantity.TabIndex = 54;
            this.labelQuantity.Text = "количество";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(12, 143);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(31, 13);
            this.labelprice.TabIndex = 55;
            this.labelprice.Text = "цена";
            // 
            // labelrazmerV
            // 
            this.labelrazmerV.AutoSize = true;
            this.labelrazmerV.Location = new System.Drawing.Point(12, 183);
            this.labelrazmerV.Name = "labelrazmerV";
            this.labelrazmerV.Size = new System.Drawing.Size(89, 13);
            this.labelrazmerV.TabIndex = 56;
            this.labelrazmerV.Text = "высота фигурки";
            // 
            // labelrazmerH
            // 
            this.labelrazmerH.AutoSize = true;
            this.labelrazmerH.Location = new System.Drawing.Point(12, 223);
            this.labelrazmerH.Name = "labelrazmerH";
            this.labelrazmerH.Size = new System.Drawing.Size(91, 13);
            this.labelrazmerH.TabIndex = 57;
            this.labelrazmerH.Text = "Ширина фигурки";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(12, 262);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(63, 13);
            this.labelProvider.TabIndex = 58;
            this.labelProvider.Text = "поставщик";
            // 
            // labelCloor
            // 
            this.labelCloor.AutoSize = true;
            this.labelCloor.Location = new System.Drawing.Point(12, 300);
            this.labelCloor.Name = "labelCloor";
            this.labelCloor.Size = new System.Drawing.Size(30, 13);
            this.labelCloor.TabIndex = 59;
            this.labelCloor.Text = "цвет";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(12, 276);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProvider.TabIndex = 60;
            // 
            // Assortment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.labelCloor);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.labelrazmerH);
            this.Controls.Add(this.labelrazmerV);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxCloor);
            this.Controls.Add(this.textBoxRazmerH);
            this.Controls.Add(this.textBoxRazmerV);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMaska);
            this.Controls.Add(this.listViewFigurka);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.comboBoxType);
            this.Name = "Assortment";
            this.Text = "Assortment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView listViewFigurka;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listViewMaska;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxRazmerV;
        private System.Windows.Forms.TextBox textBoxRazmerH;
        private System.Windows.Forms.TextBox textBoxCloor;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelrazmerV;
        private System.Windows.Forms.Label labelrazmerH;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelCloor;
        private System.Windows.Forms.ComboBox comboBoxProvider;
    }
}