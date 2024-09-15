using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

namespace _30042024
{
    public partial class Form4 : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private bool dataChanged = false;
        public Form4()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";
            connection = new OleDbConnection(connectionString);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 logForm = new Form1();
            logForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Сумма заказа")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Сумма заказа'.";
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Количество проданых книг")
            {
                int result;
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()) && !int.TryParse(e.FormattedValue.ToString(), out result))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Пожалуйста, введите численное значение для столбца 'Количество проданых книг'.";
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
        private void Form4_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}
