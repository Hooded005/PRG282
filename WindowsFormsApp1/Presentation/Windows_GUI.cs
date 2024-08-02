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
    public partial class Windows_GUI : Form
    {
        DataHandler dh = new DataHandler();
        Student s = new Student();
        Module m = new Module();
        public Windows_GUI()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dh.ReadFromStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = dh.ReadFromModules();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student_Info si = new Student_Info();
            si.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Student_Info usi = new Update_Student_Info();
            usi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModuleInfo mi = new ModuleInfo();
            mi.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_Module um = new Update_Module();
            um.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dh.searchStudent(id);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            dh.deleteStudent(id);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dh.ReadFromStudents();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = dh.searchModule(id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = textBox6.Text;
            dh.deleteModule(id);
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = dh.ReadFromModules();
        }
    }
}
