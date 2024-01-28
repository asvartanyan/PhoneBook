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
    public partial class Sort2 : Form
    {
        public bool[] sortParams = new bool[11];
        public bool ascending = true;
        public bool descending = false;
        public Sort2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public bool GetAscending()
        {
            ascending = radioButtonAscending.Checked;
            return this.ascending;
        }
        public bool GetDescending()
        {
            descending = radioButtonDescending.Checked;
            return this.descending;
        }

        private void buttonClearAllFields_Click(object sender, EventArgs e)
        {
            bool[] clear = new bool[11];
            sortParams = clear;

            checkBoxFirstName.Checked = false;
            checkBoxMidName.Checked = false;
            checkBoxLastName.Checked = false;
            checkBoxCity.Checked = false;
            checkBoxStreet.Checked = false;
            checkBoxHouse.Checked= false;
            checkBoxApartment.Checked = false;
            checkBoxNumber.Checked = false;
            checkBoxPaired.Checked = false;
            checkBoxPaymentType.Checked = false;
            checkBoxYearOfSet.Checked = false;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            sortParams[0] = checkBoxFirstName.Checked;  
            sortParams[1] = checkBoxMidName.Checked;  
            sortParams[2] = checkBoxLastName.Checked;  
            sortParams[3] = checkBoxCity.Checked;  
            sortParams[4] = checkBoxStreet.Checked;  
            sortParams[5] = checkBoxHouse.Checked;  
            sortParams[6] = checkBoxApartment.Checked;  
            sortParams[7] = checkBoxNumber.Checked;  
            sortParams[8] = checkBoxPaired.Checked;  
            sortParams[9] = checkBoxPaymentType.Checked;  
            sortParams[10] = checkBoxYearOfSet.Checked;
            sortParamGet();
            GetAscending();
            GetDescending();
            this.Hide();
        }
        public bool[] sortParamGet()
        {
            return sortParams;
        }
    }
}
