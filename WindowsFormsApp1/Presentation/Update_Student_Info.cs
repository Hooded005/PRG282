using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Logic;

namespace WindowsFormsApp1
{
    public partial class Update_Student_Info : Form
    {
        DataHandler dh = new DataHandler();
        Student s = new Student();
        public Update_Student_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sNumber = int.Parse(textBox1.Text);
            string sName = textBox2.Text;
            string sSurname = textBox3.Text;
            string sDOB = dateTimePicker1.Text.Replace('/', '-');
            string sGender = comboBox1.Text;
            string sPhone = textBox5.Text;
            string sAddress = textBox4.Text;
            string sModule = textBox6.Text;

            s = new Student(sNumber, sName, sSurname, sDOB, sGender, sPhone, sAddress, sModule);
            dh.UpdateStudent(s);

            MessageBox.Show("Entered student data has been updated successfully");

            Windows_GUI main = new Windows_GUI();
            main.Show();
            this.Close();
        }
    }
}
