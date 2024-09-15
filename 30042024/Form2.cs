using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

namespace _30042024
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private bool dataChanged = false;
        public Form2()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";
            connection = new OleDbConnection(connectionString);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Columns.Contains("ID_Zakazi"))
                {
                    dataTable.Columns["Дата заказа"].ColumnName = "Data_Zakaza";
                    dataTable.Columns["Список купленых книг"].ColumnName = "Spisok_Kuplenih_Knig";
                    dataTable.Columns["Сумма заказа"].ColumnName = "Summa_Zakaza";
                    connection.Open();
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                    connection.Close();
                    dataTable.Columns["Data_Zakaza"].ColumnName = "Дата заказа";
                    dataTable.Columns["Spisok_Kuplenih_Knig"].ColumnName = "Список купленых книг";
                    dataTable.Columns["Summa_Zakaza"].ColumnName = "Сумма заказа";
                    MessageBox.Show("Изменения успешно сохранены.");

                }
             else if (dataGridView1.Columns.Contains("ID_Rabotniki"))
                {
                    dataTable.Columns["Имя"].ColumnName = "Imya";
                    dataTable.Columns["Фамилия"].ColumnName = "Familiya";
                    dataTable.Columns["Отчество"].ColumnName = "Otchestvo";
                    dataTable.Columns["Смена"].ColumnName = "Smena";
                    dataTable.Columns["Статус"].ColumnName = "Status";
                    dataTable.Columns["Должность"].ColumnName = "Doljnost";
                    connection.Open();
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                    connection.Close();
                    dataTable.Columns["Imya"].ColumnName = "Имя";
                    dataTable.Columns["Familiya"].ColumnName = "Фамилия";
                    dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
                    dataTable.Columns["Smena"].ColumnName = "Смена";
                    dataTable.Columns["Status"].ColumnName = "Статус";
                    dataTable.Columns["Doljnost"].ColumnName = "Должность";
                    MessageBox.Show("Изменения успешно сохранены.");
                }
                else if (dataGridView1.Columns.Contains("ID_Prodaji"))
                {
                    dataTable.Columns["Дата продажи"].ColumnName = "Data_Prodaji";
                    dataTable.Columns["Цена продажи"].ColumnName = "Cena_Prodaji";
                    dataTable.Columns["Количество проданых книг"].ColumnName = "Kolichestvo_Prodanih_Knig";              
                    connection.Open();
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                    connection.Close();
                    dataTable.Columns["Data_Prodaji"].ColumnName = "Дата продажи";
                    dataTable.Columns["Cena_Prodaji"].ColumnName = "Цена продажи";
                    dataTable.Columns["Kolichestvo_Prodanih_Knig"].ColumnName = "Количество проданых книг";
                    MessageBox.Show("Изменения успешно сохранены.");
                }
                else if (dataGridView1.Columns.Contains("ID_Klienta"))
                {
                    dataTable.Columns["Имя"].ColumnName = "Imya";
                    dataTable.Columns["Фамилия"].ColumnName = "Familiya";
                    dataTable.Columns["Отчество"].ColumnName = "Otchestvo";
                    dataTable.Columns["Адрес"].ColumnName = "Adres";
                    dataTable.Columns["Номер телефона"].ColumnName = "Nomer_Telefona";
                    dataTable.Columns["Почта"].ColumnName = "Email"; 
                    connection.Open();
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                    connection.Close();
                    dataTable.Columns["Imya"].ColumnName = "Имя";
                    dataTable.Columns["Familiya"].ColumnName = "Фамилия";
                    dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
                    dataTable.Columns["Adres"].ColumnName = "Адрес";
                    dataTable.Columns["Nomer_Telefona"].ColumnName = "Номер телефона";
                    dataTable.Columns["Email"].ColumnName = "Почта";
                    MessageBox.Show("Изменения успешно сохранены.");
                }
                else if (dataGridView1.Columns.Contains("ID_Knigi"))
                {
                    dataTable.Columns["Название книги"].ColumnName = "Nazvanie_knigi";
                    dataTable.Columns["Автор"].ColumnName = "Avtor";
                    dataTable.Columns["Жанр"].ColumnName = "Janr";
                    dataTable.Columns["Издательство"].ColumnName = "Izdatelstvo";
                    dataTable.Columns["Год издания"].ColumnName = "God_izdaniya";
                    dataTable.Columns["Цена"].ColumnName = "Cena";
                    dataTable.Columns["Наличие в магазине"].ColumnName = "Nalichie_v_magazine";
                    connection.Open();
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                    connection.Close();
                    dataTable.Columns["Nazvanie_knigi"].ColumnName = "Название книги";
                    dataTable.Columns["Avtor"].ColumnName = "Автор";
                    dataTable.Columns["Janr"].ColumnName = "Жанр";
                    dataTable.Columns["Izdatelstvo"].ColumnName = "Издательство";
                    dataTable.Columns["God_izdaniya"].ColumnName = "Год издания";
                    dataTable.Columns["Cena"].ColumnName = "Цена";
                    dataTable.Columns["Nalichie_v_magazine"].ColumnName = "Наличие в магазине";
                    MessageBox.Show("Изменения успешно сохранены.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {        
            Form1 logForm = new Form1();
            logForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(655, 247);
            button2.Location = new Point(626, 266);
            this.Size = new Size(800, 353);

            dataAdapter = new OleDbDataAdapter("SELECT * FROM Rabotniki", connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            dataTable.Columns["Imya"].ColumnName = "Имя";
            dataTable.Columns["Familiya"].ColumnName = "Фамилия";
            dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
            dataTable.Columns["Smena"].ColumnName = "Смена";
            dataTable.Columns["Status"].ColumnName = "Статус";
            dataTable.Columns["Doljnost"].ColumnName = "Должность";
            connection.Close();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID_Rabotniki"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(344, 247);
            button2.Location = new Point(315, 265);
            this.Size = new Size(489, 353);

            dataAdapter = new OleDbDataAdapter("SELECT * FROM Zakazi", connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);

            dataTable.Columns["Data_Zakaza"].ColumnName = "Дата заказа";
            dataTable.Columns["Spisok_Kuplenih_Knig"].ColumnName = "Список купленых книг";
            dataTable.Columns["Summa_Zakaza"].ColumnName = "Сумма заказа";
            connection.Close();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID_Zakazi"].Visible = false;
            dataGridView1.Columns["ID_Klienta"].Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(344, 247);
            button2.Location = new Point(315, 265);
            this.Size = new Size(489, 353);

            dataAdapter = new OleDbDataAdapter("SELECT * FROM Prodaji", connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            dataTable.Columns["Data_Prodaji"].ColumnName = "Дата продажи";
            dataTable.Columns["Cena_Prodaji"].ColumnName = "Цена продажи";
            dataTable.Columns["Kolichestvo_Prodanih_Knig"].ColumnName = "Количество проданых книг";
            connection.Close();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID_Prodaji"].Visible = false;
            dataGridView1.Columns["ID_Knigi"].Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(655, 247);
            button2.Location = new Point(626, 266);
            this.Size = new Size(800, 353);

            dataAdapter = new OleDbDataAdapter("SELECT * FROM Klienti", connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            dataTable.Columns["Imya"].ColumnName = "Имя";
            dataTable.Columns["Familiya"].ColumnName = "Фамилия";
            dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
            dataTable.Columns["Adres"].ColumnName = "Адрес";
            dataTable.Columns["Nomer_Telefona"].ColumnName = "Номер телефона";
            dataTable.Columns["Email"].ColumnName = "Почта";
            connection.Close();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID_Klienta"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(755, 247);
            button2.Location = new Point(726, 266);
            this.Size = new Size(900, 353);

            dataAdapter = new OleDbDataAdapter("SELECT * FROM Books", connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            dataTable.Columns["Nazvanie_knigi"].ColumnName = "Название книги";
            dataTable.Columns["Avtor"].ColumnName = "Автор";
            dataTable.Columns["Janr"].ColumnName = "Жанр";
            dataTable.Columns["Izdatelstvo"].ColumnName = "Издательство";
            dataTable.Columns["God_izdaniya"].ColumnName = "Год издания";
            dataTable.Columns["Cena"].ColumnName = "Цена";
            dataTable.Columns["Nalichie_v_magazine"].ColumnName = "Наличие в магазине";
            connection.Close();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID_Knigi"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Цена")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Цена'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Сумма заказа")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Сумма заказа'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Год издания")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Год издания'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Цена продажи")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Цена продажи'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Номер телефона")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Номер телефона'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Количество проданых книг")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Количество проданых книг'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Смена")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Смена'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Дата продажи")
            {
                DateTime result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !DateTime.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите корректное значение даты для столбца 'Дата продажи'.";
                    e.Cancel = true;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Дата заказа")
            {
                DateTime result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !DateTime.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите корректное значение даты для столбца 'Дата заказа'.";
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }  
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataChanged)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (dataGridView1.Columns.Contains("ID_Zakazi"))
                        {
                            dataTable.Columns["Дата заказа"].ColumnName = "Data_Zakaza";
                            dataTable.Columns["Список купленых книг"].ColumnName = "Spisok_Kuplenih_Knig";
                            dataTable.Columns["Сумма заказа"].ColumnName = "Summa_Zakaza";
                            connection.Open();
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                            dataAdapter.Update(dataTable);
                            connection.Close();
                            dataTable.Columns["Data_Zakaza"].ColumnName = "Дата заказа";
                            dataTable.Columns["Spisok_Kuplenih_Knig"].ColumnName = "Список купленых книг";
                            dataTable.Columns["Summa_Zakaza"].ColumnName = "Сумма заказа";
                            MessageBox.Show("Изменения успешно сохранены.");

                        }
                        else if (dataGridView1.Columns.Contains("ID_Rabotniki"))
                        {
                            dataTable.Columns["Имя"].ColumnName = "Imya";
                            dataTable.Columns["Фамилия"].ColumnName = "Familiya";
                            dataTable.Columns["Отчество"].ColumnName = "Otchestvo";
                            dataTable.Columns["Смена"].ColumnName = "Smena";
                            dataTable.Columns["Статус"].ColumnName = "Status";
                            dataTable.Columns["Должность"].ColumnName = "Doljnost";
                            connection.Open();
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                            dataAdapter.Update(dataTable);
                            connection.Close();
                            dataTable.Columns["Imya"].ColumnName = "Имя";
                            dataTable.Columns["Familiya"].ColumnName = "Фамилия";
                            dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
                            dataTable.Columns["Smena"].ColumnName = "Смена";
                            dataTable.Columns["Status"].ColumnName = "Статус";
                            dataTable.Columns["Doljnost"].ColumnName = "Должность";
                            MessageBox.Show("Изменения успешно сохранены.");
                        }
                        else if (dataGridView1.Columns.Contains("ID_Prodaji"))
                        {
                            dataTable.Columns["Дата продажи"].ColumnName = "Data_Prodaji";
                            dataTable.Columns["Цена продажи"].ColumnName = "Cena_Prodaji";
                            dataTable.Columns["Количество проданых книг"].ColumnName = "Kolichestvo_Prodanih_Knig";
                            connection.Open();
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                            dataAdapter.Update(dataTable);
                            connection.Close();
                            dataTable.Columns["Data_Prodaji"].ColumnName = "Дата продажи";
                            dataTable.Columns["Cena_Prodaji"].ColumnName = "Цена продажи";
                            dataTable.Columns["Kolichestvo_Prodanih_Knig"].ColumnName = "Количество проданых книг";
                            MessageBox.Show("Изменения успешно сохранены.");
                        }
                        else if (dataGridView1.Columns.Contains("ID_Klienta"))
                        {
                            dataTable.Columns["Имя"].ColumnName = "Imya";
                            dataTable.Columns["Фамилия"].ColumnName = "Familiya";
                            dataTable.Columns["Отчество"].ColumnName = "Otchestvo";
                            dataTable.Columns["Адрес"].ColumnName = "Adres";
                            dataTable.Columns["Номер телефона"].ColumnName = "Nomer_Telefona";
                            dataTable.Columns["Почта"].ColumnName = "Email";
                            connection.Open();
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                            dataAdapter.Update(dataTable);
                            connection.Close();
                            dataTable.Columns["Imya"].ColumnName = "Имя";
                            dataTable.Columns["Familiya"].ColumnName = "Фамилия";
                            dataTable.Columns["Otchestvo"].ColumnName = "Отчество";
                            dataTable.Columns["Adres"].ColumnName = "Адрес";
                            dataTable.Columns["Nomer_Telefona"].ColumnName = "Номер телефона";
                            dataTable.Columns["Email"].ColumnName = "Почта";
                            MessageBox.Show("Изменения успешно сохранены.");
                        }
                        else if (dataGridView1.Columns.Contains("ID_Knigi"))
                        {
                            dataTable.Columns["Название книги"].ColumnName = "Nazvanie_knigi";
                            dataTable.Columns["Автор"].ColumnName = "Avtor";
                            dataTable.Columns["Жанр"].ColumnName = "Janr";
                            dataTable.Columns["Издательство"].ColumnName = "Izdatelstvo";
                            dataTable.Columns["Год издания"].ColumnName = "God_izdaniya";
                            dataTable.Columns["Цена"].ColumnName = "Cena";
                            dataTable.Columns["Наличие в магазине"].ColumnName = "Nalichie_v_magazine";
                            connection.Open();
                            OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                            dataAdapter.Update(dataTable);
                            connection.Close();
                            dataTable.Columns["Nazvanie_knigi"].ColumnName = "Название книги";
                            dataTable.Columns["Avtor"].ColumnName = "Автор";
                            dataTable.Columns["Janr"].ColumnName = "Жанр";
                            dataTable.Columns["Izdatelstvo"].ColumnName = "Издательство";
                            dataTable.Columns["God_izdaniya"].ColumnName = "Год издания";
                            dataTable.Columns["Cena"].ColumnName = "Цена";
                            dataTable.Columns["Nalichie_v_magazine"].ColumnName = "Наличие в магазине";
                            MessageBox.Show("Изменения успешно сохранены.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message);
                    }

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Отменить попытку закрытия формы
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataChanged = true;
        }
    }
}
