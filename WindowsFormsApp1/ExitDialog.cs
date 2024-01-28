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
    public partial class ExitDialog : Form
    {
        string c_path = "";
        public ExitDialog()
        {
            InitializeComponent();
        }

        public void LoadPath(string path)
        {
            c_path = path;
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            
            FileReaderWriter frw = new FileReaderWriter();
            frw.currentFilePath = c_path;
            string str = string.Empty;
            frw.Write(ref str);
            Application.Exit();
          
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void ExitDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
