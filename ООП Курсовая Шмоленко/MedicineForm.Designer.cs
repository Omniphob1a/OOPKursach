namespace ООП_Курсовая_Шмоленко
{
    partial class MedicineForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            MedicineToolStripMenuItem = new ToolStripMenuItem();
            labelFilter = new Label();
            comboBoxFilter = new ComboBox();
            textBoxFilterValue = new TextBox();
            labelFilterValue = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            numericUpDownAddQuantity = new NumericUpDown();
            label1 = new Label();
            buttonAdd = new Button();
            label15 = new Label();
            textBoxAddNameMedicine = new TextBox();
            label14 = new Label();
            numericUpDownAddPrice = new NumericUpDown();
            label11 = new Label();
            textBoxAddDisease = new TextBox();
            label10 = new Label();
            textBoxAddName = new TextBox();
            tabPage2 = new TabPage();
            numericUpDownEditQuantity = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            buttonEdit = new Button();
            textBoxEditNameMedicine = new TextBox();
            numericUpDownEditPrice = new NumericUpDown();
            textBoxEditDisease = new TextBox();
            textBoxEditMedicine = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonDelete = new Button();
            labelFilterCount = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonBuy = new Button();
            buttonOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddPrice).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditPrice).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column6, Column4 });
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(612, 317);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Название лекарства";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Болезнь";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Цена";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Название компании";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Количество";
            Column4.Name = "Column4";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, MedicineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, создатьToolStripMenuItem, удалитьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(133, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(133, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // MedicineToolStripMenuItem
            // 
            MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem";
            MedicineToolStripMenuItem.Size = new Size(12, 20);
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(24, 31);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(95, 15);
            labelFilter.TabIndex = 3;
            labelFilter.Text = "Фильтровать по";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.AutoCompleteCustomSource.AddRange(new string[] { "Название", "Болезнь", "Цена" });
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Название лекарства", "Болезнь", "Цена", "Название компании" });
            comboBoxFilter.Location = new Point(125, 26);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(133, 23);
            comboBoxFilter.TabIndex = 4;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // textBoxFilterValue
            // 
            textBoxFilterValue.Location = new Point(340, 28);
            textBoxFilterValue.Name = "textBoxFilterValue";
            textBoxFilterValue.Size = new Size(109, 23);
            textBoxFilterValue.TabIndex = 5;
            textBoxFilterValue.TextChanged += textBoxFilterValue_TextChanged;
            // 
            // labelFilterValue
            // 
            labelFilterValue.AutoSize = true;
            labelFilterValue.Location = new Point(276, 31);
            labelFilterValue.Name = "labelFilterValue";
            labelFilterValue.Size = new Size(58, 15);
            labelFilterValue.TabIndex = 6;
            labelFilterValue.Text = "значение";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(630, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(234, 261);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDownAddQuantity);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonAdd);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(textBoxAddNameMedicine);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(numericUpDownAddPrice);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(textBoxAddDisease);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBoxAddName);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(226, 233);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавить";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAddQuantity
            // 
            numericUpDownAddQuantity.Location = new Point(114, 40);
            numericUpDownAddQuantity.Name = "numericUpDownAddQuantity";
            numericUpDownAddQuantity.Size = new Size(103, 23);
            numericUpDownAddQuantity.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 40;
            label1.Text = "Количество";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(4, 206);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(214, 23);
            buttonAdd.TabIndex = 38;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 14);
            label15.Name = "label15";
            label15.Size = new Size(117, 15);
            label15.TabIndex = 26;
            label15.Text = "Название лекарства";
            // 
            // textBoxAddNameMedicine
            // 
            textBoxAddNameMedicine.Location = new Point(6, 176);
            textBoxAddNameMedicine.Name = "textBoxAddNameMedicine";
            textBoxAddNameMedicine.Size = new Size(211, 23);
            textBoxAddNameMedicine.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 72);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 27;
            label14.Text = "Болезнь";
            // 
            // numericUpDownAddPrice
            // 
            numericUpDownAddPrice.Location = new Point(114, 98);
            numericUpDownAddPrice.Name = "numericUpDownAddPrice";
            numericUpDownAddPrice.Size = new Size(104, 23);
            numericUpDownAddPrice.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 100);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 30;
            label11.Text = "Цена";
            // 
            // textBoxAddDisease
            // 
            textBoxAddDisease.Location = new Point(114, 69);
            textBoxAddDisease.Name = "textBoxAddDisease";
            textBoxAddDisease.Size = new Size(103, 23);
            textBoxAddDisease.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 158);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 31;
            label10.Text = "Название компании";
            // 
            // textBoxAddName
            // 
            textBoxAddName.Location = new Point(129, 11);
            textBoxAddName.Name = "textBoxAddName";
            textBoxAddName.Size = new Size(89, 23);
            textBoxAddName.TabIndex = 32;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(numericUpDownEditQuantity);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(buttonEdit);
            tabPage2.Controls.Add(textBoxEditNameMedicine);
            tabPage2.Controls.Add(numericUpDownEditPrice);
            tabPage2.Controls.Add(textBoxEditDisease);
            tabPage2.Controls.Add(textBoxEditMedicine);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(226, 233);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Изменить";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownEditQuantity
            // 
            numericUpDownEditQuantity.Location = new Point(116, 42);
            numericUpDownEditQuantity.Name = "numericUpDownEditQuantity";
            numericUpDownEditQuantity.Size = new Size(104, 23);
            numericUpDownEditQuantity.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 41;
            label3.Text = "Название компании";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 40;
            label2.Text = "Количество";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(6, 202);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(214, 23);
            buttonEdit.TabIndex = 38;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxEditNameMedicine
            // 
            textBoxEditNameMedicine.Location = new Point(6, 173);
            textBoxEditNameMedicine.Name = "textBoxEditNameMedicine";
            textBoxEditNameMedicine.Size = new Size(214, 23);
            textBoxEditNameMedicine.TabIndex = 37;
            // 
            // numericUpDownEditPrice
            // 
            numericUpDownEditPrice.Location = new Point(116, 99);
            numericUpDownEditPrice.Name = "numericUpDownEditPrice";
            numericUpDownEditPrice.Size = new Size(104, 23);
            numericUpDownEditPrice.TabIndex = 36;
            // 
            // textBoxEditDisease
            // 
            textBoxEditDisease.Location = new Point(116, 70);
            textBoxEditDisease.Name = "textBoxEditDisease";
            textBoxEditDisease.Size = new Size(104, 23);
            textBoxEditDisease.TabIndex = 33;
            // 
            // textBoxEditMedicine
            // 
            textBoxEditMedicine.Location = new Point(129, 12);
            textBoxEditMedicine.Name = "textBoxEditMedicine";
            textBoxEditMedicine.Size = new Size(91, 23);
            textBoxEditMedicine.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 180);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 31;
            label4.Text = "Название компании";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 101);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 30;
            label5.Text = "Цена";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 73);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 27;
            label8.Text = "Болезнь";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 15);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 26;
            label9.Text = "Название лекарства";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Location = new Point(634, 298);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(230, 22);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelFilterCount
            // 
            labelFilterCount.AutoSize = true;
            labelFilterCount.Location = new Point(466, 31);
            labelFilterCount.Name = "labelFilterCount";
            labelFilterCount.Size = new Size(38, 15);
            labelFilterCount.TabIndex = 9;
            labelFilterCount.Text = "label3";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonBuy
            // 
            buttonBuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBuy.Location = new Point(630, 326);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(116, 47);
            buttonBuy.TabIndex = 10;
            buttonBuy.Text = "Купить";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOrder.Location = new Point(752, 326);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(108, 47);
            buttonOrder.TabIndex = 11;
            buttonOrder.Text = "Заказ";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 384);
            Controls.Add(buttonOrder);
            Controls.Add(buttonBuy);
            Controls.Add(labelFilterCount);
            Controls.Add(buttonDelete);
            Controls.Add(tabControl1);
            Controls.Add(labelFilterValue);
            Controls.Add(textBoxFilterValue);
            Controls.Add(comboBoxFilter);
            Controls.Add(labelFilter);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(892, 423);
            Name = "MedicineForm";
            Text = "Аптека";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddPrice).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEditPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Label labelFilter;
        private ComboBox comboBoxFilter;
        private TextBox textBoxFilterValue;
        private Label labelFilterValue;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonDelete;
        private Label labelFilterCount;
        private Button buttonAdd;
        private Label label15;
        private TextBox textBoxAddNameMedicine;
        private Label label14;
        private NumericUpDown numericUpDownAddPrice;
        private Label label11;
        private TextBox textBoxAddDisease;
        private Label label10;
        private TextBox textBoxAddName;
        private Button buttonEdit;
        private TextBox textBoxEditNameMedicine;
        private NumericUpDown numericUpDownEditPrice;
        private TextBox textBoxEditDisease;
        private TextBox textBoxEditMedicine;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem MedicineToolStripMenuItem;
        private Button buttonBuy;
        private Button buttonOrder;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownAddQuantity;
        private NumericUpDown numericUpDownEditQuantity;
    }
}
