using System;
using System.Windows.Forms;
namespace _30042024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Изменения");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Добро пожаловать!");
                Form2 adminForm = new Form2();
                adminForm.Show();
                this.Hide();
            }
        else if (username == "user" && password == "user123")
            {
                MessageBox.Show("Добро пожаловать!");
                Form3 userForm = new Form3();
                userForm.Show();
                this.Hide();
            }
          else if (username == "user2" && password == "user123")
            {
                MessageBox.Show("Добро пожаловать!");
                Form4 menForm = new Form4();
                menForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправлиьный логин или пароль. Попробуйте еще раз.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0'; // Пароль отображается в виде открытого текста
            else
                textBox2.PasswordChar = '*'; // Пароль скрыт
        }
    }
   
}
