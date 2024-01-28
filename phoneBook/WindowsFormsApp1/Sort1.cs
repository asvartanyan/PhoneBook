using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sort1 : Form
    {
        public int? indexColumnToSort = null;
        public bool isAscending = true;
        public bool isDescendin = false;
        public string log = string.Empty;

        public Sort1()
        {
            InitializeComponent();
        }

        private void buttonSort1Field_Click(object sender, EventArgs e)
        {
           

        }
        public int? indexCTS()
        {

            return this.indexColumnToSort;
        }
        public bool isAscen()
        {
            isAscending = radioButton1.Checked;
            return this.isAscending;
        }
        public bool isDescen()
        {
            isDescendin = radioButton2.Checked;
            return this.isDescendin;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string Log()
        {
            log = Convert.ToString(comboBox1.SelectedItem);
            return this.log;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            indexColumnToSort = (int?)comboBox1.SelectedIndex;
            this.Hide();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
