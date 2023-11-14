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
            
            String[] stud_info = {"Student Number: " + textBox1.Text, "Full Name: " + textBox3.Text
            + " " + textBox4.Text + " " + textBox2.Text + " ", "Program: " + comboBox1.Text, "Gender: " +
            comboBox2.Text, "Age: " + textBox5.Text, "Birthdate: " + dateTimePicker1.Text,
            "Contact Number: " + textBox6.Text};

            string doccPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(doccPath, textBox1.Text + ".txt")))
            {
                foreach (string s in stud_info)
                {
                    outputFile.WriteLine(s);
                }
               
                MessageBox.Show("Successfuly created!!!");
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord reg = new FrmStudentRecord();
            reg.ShowDialog();
        }
    }
}
