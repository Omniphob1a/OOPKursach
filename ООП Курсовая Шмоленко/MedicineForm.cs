using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ООП_Курсовая_Шмоленко
{
    public partial class MedicineForm : Form
    {
        DataBase? _data;
        Medicament? _lastMedicament;
        private List<Order> orders = new List<Order>();
        public MedicineForm()
        {
            InitializeComponent();
            Block(true);
            labelFilterCount.Visible = false;
            openFileDialog1.Filter = String.Format("База данных|*{0}", DataBase.rash);
            openFileDialog1.DefaultExt = DataBase.rash;
            saveFileDialog1.Filter = String.Format("База данных|*{0}", DataBase.rash);
            saveFileDialog1.DefaultExt = DataBase.rash;
            BlockEdit(true);
            textBoxFilterValue.Enabled = false;
            MessageBox.Show("Шмоленко; 22ВП1; Предметная область: Аптека");
        }

        void Block(bool val)
        {
            tabControl1.Enabled = !val;
            dataGridView1.Enabled = !val;
            открытьToolStripMenuItem.Enabled = val;
            создатьToolStripMenuItem.Enabled = val;
            удалитьToolStripMenuItem.Enabled = !val;
            сохранитьToolStripMenuItem.Enabled = !val;
            labelFilter.Enabled = !val;
            labelFilterCount.Enabled = !val;
            labelFilterValue.Enabled = !val;
            comboBoxFilter.Enabled = !val;
            MedicineToolStripMenuItem.Enabled = !val;
            buttonDelete.Enabled = !val;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();

            string medicineName = Regex.Replace(textBoxAddName.Text, @"\s+", " ");
            string disease = Regex.Replace(textBoxAddDisease.Text, @"\s+", " ");
            string name = Regex.Replace(textBoxAddNameMedicine.Text, @"\s+", " ");

            // Проверка на корректные данные
            if (string.IsNullOrEmpty(medicineName) || string.IsNullOrEmpty(disease) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(numericUpDownAddQuantity.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка с значением");
                return;
            }

            int price = Convert.ToInt32(numericUpDownAddPrice.Value);

            // Проверка на корректность количества
            if (!int.TryParse(numericUpDownAddQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Некорректное количество", "Ошибка с количеством");
                return;
            }

            // Добавление в хранилище
            _data.GetMedicaments().Add(new Medicament(medicineName, disease, price, name, quantity)); // Здесь quantity передается как int

            // Добавление в DataGridView
            dataGridView1.Rows.Add(medicineName, disease, price, name, quantity); // Добавление новой строки с количеством

            UpDate(); // Обновление интерфейса
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();
            if (_lastMedicament == null) throw new ArgumentNullException();

            string Medicine = Regex.Replace(textBoxEditMedicine.Text, @"\s+", " ");
            string Disease = Regex.Replace(textBoxEditDisease.Text, @"\s+", " ");
            string Name = Regex.Replace(textBoxEditNameMedicine.Text, @"\s+", " ");

            // Проверка на корректность количества
            if (string.IsNullOrEmpty(Medicine) || string.IsNullOrEmpty(Disease) ||
                string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(numericUpDownEditQuantity.Text))
            {
                MessageBox.Show("Одно из полей не содержит данных", "Ошибка с значением");
                return;
            }

            int Price = Convert.ToInt32(numericUpDownEditPrice.Value);
            int Quantity = Convert.ToInt32(numericUpDownEditQuantity.Text); // Получаем количество

            // Удаление старого клиента и добавление нового
            _data.GetMedicaments().Remove(_lastMedicament);
            _lastMedicament = null;

            _data.GetMedicaments().Add(new Medicament(Medicine, Disease, Price, Name, Quantity));
            UpDate();
            dataGridView1_SelectionChanged(sender, e);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            _data = new DataBase();
            try
            {
                _data.load(openFileDialog1.FileName);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Открыт неккоректный файл", "Ошибка");
                return;
            }
            Block(false);
            UpDate();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data = new DataBase();
            Block(false);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();
            dataGridView1.Rows.Clear();
            _data = null;
            Block(true);

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            _data.save(saveFileDialog1.FileName);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();
            if (dataGridView1.CurrentCell != null)
            {
                BlockEdit(false);
                textBoxEditMedicine.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                textBoxEditDisease.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                numericUpDownEditPrice.Value = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                textBoxEditNameMedicine.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                foreach (Medicament Medicament in _data.GetMedicaments())
                {
                    if (Medicament._Medicine == Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value) &&
                        Medicament._Disease == Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value) &&
                        Medicament._Price == Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value) &&
                        Medicament._Name == Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value))
                    {
                        _lastMedicament = Medicament;
                    }

                }
            }
            else
            {
                _lastMedicament = null;
                BlockEdit(true);
            }
        }
        void BlockEdit(bool val)
        {
            label4.Enabled = !val;
            label5.Enabled = !val;
            label8.Enabled = !val;
            label9.Enabled = !val;
            textBoxEditNameMedicine.Enabled = !val;
            textBoxEditDisease.Enabled = !val;
            textBoxEditMedicine.Enabled = !val;
            numericUpDownEditPrice.Enabled = !val;
            buttonEdit.Enabled = !val;
            buttonDelete.Enabled = !val;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_data == null) throw new ArgumentNullException();
            if (_lastMedicament == null) throw new ArgumentNullException();
            _data.GetMedicaments().Remove(_lastMedicament);
            _lastMedicament = null;
            //
            dataGridView1.CurrentCell.Dispose();
            UpDate();
            dataGridView1_SelectionChanged(sender, e);
        }
        void UpDate()
        {
            if (_data == null) throw new ArgumentNullException();
            dataGridView1.Rows.Clear();
            foreach (Medicament Medicament in _data.GetMedicaments())
            {
                // Передаем всю необходимую информацию, включая количество
                dataGridView1.Rows.Add(Medicament._Medicine, Medicament._Disease, Medicament._Price, Medicament._Name, Medicament._Quantity); // Используем Medicament.Quantity
            }
            labelFilterCount.Visible = false;
            textBoxFilterValue.Text = "";
        }

        private void textBoxFilterValue_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (_data == null) throw new ArgumentNullException();
            int count = 0;
            switch (comboBoxFilter.Text)
            {
                case "Название лекарства":
                    foreach (Medicament Medicament in _data.GetMedicaments())
                    {
                        if (Medicament._Medicine.Contains(Convert.ToString(textBoxFilterValue.Text)))
                        {
                            dataGridView1.Rows.Add(Medicament._Medicine, Medicament._Disease, Medicament._Price, Medicament._Name);
                            count++;
                        }

                    }
                    break;
                case "Болезнь":
                    foreach (Medicament Medicament in _data.GetMedicaments())
                    {
                        if (Medicament._Disease.Contains(Convert.ToString(textBoxFilterValue.Text)))
                        {
                            dataGridView1.Rows.Add(Medicament._Medicine, Medicament._Disease, Medicament._Price, Medicament._Name);
                            count += 1;
                        }

                    }
                    break;
                case "Цена":
                    foreach (Medicament Medicament in _data.GetMedicaments())
                    {
                        if (Convert.ToString(Medicament._Price).Contains(Convert.ToString(textBoxFilterValue.Text)))
                        {
                            dataGridView1.Rows.Add(Medicament._Medicine, Medicament._Disease, Medicament._Price, Medicament._Name);
                            count++;
                        }

                    }
                    break;
                case "Название компании":
                    foreach (Medicament Medicament in _data.GetMedicaments())
                    {
                        if (Medicament._Name.Contains(Convert.ToString(textBoxFilterValue.Text)))
                        {
                            dataGridView1.Rows.Add(Medicament._Medicine, Medicament._Disease, Medicament._Price, Medicament._Name);
                            count++;
                        }

                    }
                    break;

            }
            labelFilterCount.Visible = true;
            labelFilterCount.Text = "Выведено " + count + " из " + _data.GetMedicaments().Count;

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilterValue.Enabled = true;
            textBoxFilterValue.Text = "";
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                string medicineName = Convert.ToString(selectedRow.Cells[0].Value);
                int availableQuantity = Convert.ToInt32(selectedRow.Cells[4].Value); // Предполагается, что количество в 5-м столбце (индекс 4)

                // Запрос у пользователя на ввод количества для покупки
                string input = Microsoft.VisualBasic.Interaction.InputBox($"Введите количество для покупки {medicineName}:", "Покупка лекарства", "1");

                if (int.TryParse(input, out int quantity) && quantity > 0)
                {
                    if (quantity <= availableQuantity)
                    {
                        // Уменьшаем количество в DataGridView
                        selectedRow.Cells[4].Value = availableQuantity - quantity;

                        // Имитация процесса покупки
                        MessageBox.Show($"Вы купили {quantity} единиц {medicineName}!", "Покупка завершена");
                    }
                    else
                    {
                        MessageBox.Show("Недостаточное количество в наличии.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Некорректное количество.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выберите лекарство для покупки.", "Ошибка");
            }
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                var selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                string medicineName = Convert.ToString(selectedRow.Cells[0].Value);
                int availableQuantity = Convert.ToInt32(selectedRow.Cells[2].Value);

                // Запрос количества у пользователя
                string input = Microsoft.VisualBasic.Interaction.InputBox("Введите количество для заказа:", "Заказ лекарства", "1");
                if (int.TryParse(input, out int quantity) && quantity > 0 && quantity <= availableQuantity)
                {
                    orders.Add(new Order { Medicine = medicineName, Quantity = quantity });
                    MessageBox.Show($"Заказано {quantity} единиц {medicineName}.", "Заказ принят");
                }
                else
                {
                    MessageBox.Show("Некорректное количество или недостаточно на складе.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выберите лекарство для заказа.", "Ошибка");
            }
        }
    }
}
