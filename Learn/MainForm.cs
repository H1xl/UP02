using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Переход к окну редактирования услуг
        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        // Переход к окну записи пользователей на услуги
        private void RecordButton_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Show();
            this.Hide();
        }

        // Переход к окну просмотра записанных на услуги пользователей
        private void ViewButton_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_26ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_26ip213DataSet.Service);

            EditButton.Enabled = false;
            RecordButton.Enabled = false;
            ViewButton.Enabled = false;
        }

        // Авторизация администратора
        private void kodButton_Click(object sender, EventArgs e)
        {
            if(kodBox.Text == "0000")
            {
                EditButton.Enabled = true;
                RecordButton.Enabled = true;
                ViewButton.Enabled = true;

                MessageBox.Show("Успешный вход!");
            } 
            else
            {
                MessageBox.Show("Неверный код!");
            }
        }

        private void kodBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
