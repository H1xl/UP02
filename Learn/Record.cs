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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_26ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_26ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_26ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_26ip213DataSet1.Client);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Перевод часы + минуты в секунды
        int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60; 
        }
        // Перевод секунд в часы
        public int TimeSecondsToHours(int a)
        {
            return a / 3600;
        }
        // Перевод секунд в минуты
        public int TimeSecondsToMinutes(int a)
        {
            return a / 60;
        }

        // Рассчет конечного времени по началу и длительноси занятия
        private void endButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            sec = TimeInSeconds(ch, min);
            int dur = Convert.ToInt32(textBox3.Text);
            sec = sec + dur;
            textBox5.Text = Convert.ToString(TimeSecondsToHours(dur));
            sec = sec % 3600;
            textBox4.Text = Convert.ToString(TimeSecondsToMinutes(sec));
        }
    }
}
