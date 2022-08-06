using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            groupBox1.BackColor = ColorTranslator.FromHtml("#5CDB95");
            button1.BackColor = ColorTranslator.FromHtml("#EDF5E1");
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            if (textBox1.Text == "user" && textBox2.Text == "123")
            {
                User newForm = new User();
                newForm.Show();
                this.Hide();
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "12345")
                {
                    Form1 newForm = new Form1();

                    newForm.Show();
                    this.Hide();

                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Некоректный ввод данных. Повторите попытку";
                }
            }
            
            //Application.Exit();

            // Password.Close();
        }

       
        private void Password_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
