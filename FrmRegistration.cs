using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String[] strings = {"Student Number: " + textBox1.Text + "\nFull Name: " + textBox3.Text
            + "" + textBox4.Text + " " + textBox2.Text + " " + "\nProgram: " + comboBox1.Text + "\nGender: " +
            comboBox2.Text + "\nAge: " + textBox5.Text + "\nBirthdate: " + dateTimePicker1.Text +
            "\nContact Number: " + textBox6.Text};

            string doccPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(doccPath, textBox1.Text + ".txt")))
            {
                foreach (string s in strings)
                {
                    outputFile.WriteLine(s);
                }

                MessageBox.Show("Successfuly created!!!");
                Close();
            }






        }
    }
}
