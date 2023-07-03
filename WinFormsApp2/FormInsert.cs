using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormInsert : Form
    {
        public ListBox parent;

        public FormInsert(ref ListBox parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Items.Add(textBox1.Text);
            //очищаем поле ввода
            textBox1.Clear();
            //передаем фокус
            textBox1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //после нажатия клавиши Enter активируем кнопку OK
                button1.Select();
                //перехватываем нажатие клавиши, удаляем системный звук
                e.Handled = true;
            }
        }
    }
}
