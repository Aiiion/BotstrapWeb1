using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{
    public partial class Form1 : Form
    {
        t4dbEntities DB;
        public Form1()
        {
            InitializeComponent();
            DB = new t4dbEntities();
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Experience temp = new Experience()
            { Company = textBox1.Text, Position = textBox2.Text, Duration = textBox3.Text };
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            refresh();

        }
        public void refresh()
        {
            listBox1.Items.Clear();
            foreach (Experience item in DB.Experiences)
            {
                listBox1.Items.Add(item);
                listBox1.DisplayMember = "Company";

            }
        }
    }
}
