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
    public partial class Update_Module : Form
    {
        DataHandler dh = new DataHandler();
        Module mod = new Module();
        public Update_Module()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            string name = textBox2.Text;
            string des = textBox3.Text;
            string links = textBox4.Text;

            mod = new Module(code, name, des, links);
            dh.UpdateModule(mod);

            MessageBox.Show("Entered module data has been updated succesfully");

            Windows_GUI main = new Windows_GUI();
            main.Show();
            this.Close();
        }
    }
}
