using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Data;
using System.Reflection;
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        FileReaderWriter fileReaderWriter = new FileReaderWriter
        { currentFilePath = "DataNumbers.json" };
        string currentLog = "Any text";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             dataGridView1.MultiSelect = false;
             //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             textBoxStatus.AppendText(currentLog);
             fileReaderWriter.Read(ref currentLog);
             textBoxStatus.AppendText("\r\n" + currentLog);
             DataGridLoad();
            Abonent ab = new Abonent();
            string JsonData = JsonConvert.SerializeObject(ab);
            File.WriteAllText("test.json", JsonData);
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOkey = true;
            isOkey = checkNotesInDataGridView();
            if (isOkey == true)
            {
                DataGridToFile();
                fileReaderWriter.Write(ref currentLog);
                textBoxStatus.AppendText("\r\n" + currentLog);
                textBoxErrors.Text = string.Empty;
            }
            else
            {
                groupBoxErrors.Visible = true;
                groupBoxErrors.Show();
            }
        }
        private void DataGridLoad()
        {
            
            
            dataGridView1.DataSource = AbonentsManager.abonents;
            if(dataGridView1.Rows.Count==0)
            {
                AbonentsManager.Resize(1);
                DataGridLoad();
            }
        }
        private void DataGridToFile() 
        {
            AbonentsManager.abonents = dataGridView1.DataSource as Abonent[];
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Json files (*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            fileReaderWriter.currentFilePath = filename;
            fileReaderWriter.Read(ref currentLog);
            textBoxStatus.AppendText("\r\n" + currentLog);
            DataGridLoad();
           
            
            
        }
        
        private void InserttoolStripButton_Click(object sender, EventArgs e)
        {
            InsertParametrs();
        }
        public bool checkNotesInDataGridView()
        {
            Abonent[] abn = dataGridView1.DataSource as Abonent[];
            List<string> errors = new List<string>();
            bool isOkey = true;
            foreach(var item in abn)
            {
               errors.AddRange(item.CorrectInputValidation(isOkey));
            }
            foreach(var item in errors)
            {
                textBoxErrors.Text = Environment.NewLine;
                textBoxErrors.Text += item;
            }
            return isOkey;
        }

        private void SaveChngstoolStripButton1_Click(object sender, EventArgs e)
        {
            bool isOkey = true;
            isOkey = checkNotesInDataGridView();
            if (isOkey == true)
            {
                DataGridToFile();
                fileReaderWriter.Write(ref currentLog);
                textBoxStatus.AppendText("\r\n" + currentLog);
                textBoxErrors.Text = string.Empty;
            }
            else
            {
                groupBoxErrors.Visible = true;
                groupBoxErrors.Show();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = false;
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
          
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Selected = false;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index != 0)
            {
                dataGridView1.Rows[index - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[1];
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
          
            int index = dataGridView1.CurrentRow.Index;
            if (index != dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[index].Selected = false;
                dataGridView1.Rows[index + 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[index + 1].Cells[1];
            }
        }

        private void UpdatetoolStripButton4_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            dataGridView1.Visible = true;
            fileReaderWriter.Read(ref currentLog);
            DataGridLoad();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) //clear
        {
            AbonentsManager.abonents = new Abonent[1];
            dataGridView1.DataSource = AbonentsManager.abonents;
        }
        public void RemoveParametrs()
        {
            int selectedRowIndex = dataGridView1.CurrentRow.Index;
            if (AbonentsManager.abonents.Length > 1)
            {
                AbonentsManager.DelByIndex(selectedRowIndex);
                DataGridLoad();
                if (selectedRowIndex != 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[selectedRowIndex - 1].Cells[0];
            }
            else if (AbonentsManager.abonents.Length <= 1)
            {
                Abonent abns = new Abonent();
                AbonentsManager.abonents[0] = abns;
                DataGridLoad();
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
            }
        }
        private void RemovetoolStripButton3_Click(object sender, EventArgs e)
        {

            RemoveParametrs();
          
        }

        Abonent ToInsertAbonent = new Abonent();
        public void UpdateInsertInfo()
        {
            textBoxInfoToInsert.Clear();
            textBoxInfoToInsert.AppendText(ToInsertAbonent.firstName+"\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.middleName+"\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.lastName + "\r\n");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.city + "\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.street + "\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.house + "\r\n");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.number + "\t");
            textBoxInfoToInsert.AppendText(Convert.ToString(ToInsertAbonent.isPaired) + "\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.paymentType + "\t");
            textBoxInfoToInsert.AppendText(ToInsertAbonent.yearOfSet + "\r\n");
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.firstName = textBoxFirstName.Text;
                UpdateInsertInfo();
        }

        private void textBoxMidName_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.middleName = textBoxMidName.Text;
            UpdateInsertInfo();
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.lastName = textBoxLastName.Text;
            UpdateInsertInfo();
        }

        private void textBoxCity_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.city = textBoxCity.Text;
            UpdateInsertInfo();
        }

        private void textBoxStreet_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.street = textBoxStreet.Text;
            UpdateInsertInfo();
        }

        private void textBoxHouse_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.house = textBoxHouse.Text;
            UpdateInsertInfo();
        }

        private void textBoxApartment_Validated(object sender, EventArgs e)
        {
            ToInsertAbonent.apartment = textBoxApartment.Text;
            UpdateInsertInfo();
        }

        private void checkBoxPaired_Click(object sender, EventArgs e)
        {
            ToInsertAbonent.isPaired = checkBoxPaired.Checked;
            UpdateInsertInfo();
        }

        private void comboBoxPaymentType_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.paymentType = Convert.ToString(comboBoxPaymentType.SelectedItem);
            UpdateInsertInfo();
        }

        private void textBoxYear_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.yearOfSet = textBoxYear.Text;
            UpdateInsertInfo();
        }
        private void InsertToListValue(int typeOfInsert)
        {
            //проверка на ToInsertAbonent на null
            textBoxErorsLog.Clear();
            if (ToInsertAbonent.CorrectInputValidation().Count != 0)
            {
                foreach (var item in ToInsertAbonent.CorrectInputValidation())
                {
                    textBoxErorsLog.AppendText(item + "\r\n");
                }
                textBoxErorsLog.AppendText("Enter correct data!!!\r\n");
            }
            else
            {  
                switch(typeOfInsert)
                {
                    case 0:
                        {
                            AbonentsManager.AddToEnd(ToInsertAbonent);
                            currentLog = ToInsertAbonent.firstName + "\t" + ToInsertAbonent.middleName + "\t" + ToInsertAbonent.lastName + " was added to the end of the table";
                            break;
                        }
                    case 1:
                        {
                            AbonentsManager.AddToStart(ToInsertAbonent);
                            currentLog = ToInsertAbonent.firstName + "\t" + ToInsertAbonent.middleName + "\t" + ToInsertAbonent.lastName + " was added to the start of the table";
                            break;
                        }
                    case 2:
                        {
                            AbonentsManager.AddByIndex(Convert.ToInt32(labelIndex.Text), ToInsertAbonent);
                            currentLog = ToInsertAbonent.firstName + "\t" + ToInsertAbonent.middleName + "\t" + ToInsertAbonent.lastName + " was added to "+labelIndex.Text +" of the table";
                            break;
                        }
                }
              
                
                textBoxStatus.AppendText("\r\n" + currentLog);
                textBoxErorsLog.AppendText(currentLog + "\r\n");
                DataGridLoad();

               ToInsertAbonent = new Abonent();
               UpdateInsertInfo();
                FullNameFieldsClear();
                AdressFieldsClear();
                NumberFiledsClear();
            }
        }
        private void buttonInsertToEndValue_Click(object sender, EventArgs e)
        {
            InsertToListValue(0);
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            labelIndex.Text =  $"{index}";
        }

        private void buttonInsertToStart_Click(object sender, EventArgs e)
        {
            InsertToListValue(1);
        }
        private void FullNameFieldsClear()
        {
            textBoxFirstName.Clear();
            textBoxMidName.Clear();
            textBoxLastName.Clear();
            ToInsertAbonent.firstName = null;
            ToInsertAbonent.middleName = null;
            ToInsertAbonent.lastName = null;
            UpdateInsertInfo();
        }
        private void AdressFieldsClear()
        {
            textBoxCity.Clear();
            textBoxStreet.Clear();
            textBoxHouse.Clear();
            textBoxApartment.Clear();
            ToInsertAbonent.city = null;
            ToInsertAbonent.street = null;
            ToInsertAbonent.house = null;
            ToInsertAbonent.apartment = null;
            UpdateInsertInfo();

        }
        private void NumberFiledsClear()
        {
            checkBoxPaired.Checked = false;
            comboBoxPaymentType.Text = string.Empty;
            textBoxYear.Clear();
            textBoxNumber.Clear();
            ToInsertAbonent.isPaired = false;
            ToInsertAbonent.paymentType = null;
            ToInsertAbonent.yearOfSet = null;
            ToInsertAbonent.number = null;
            UpdateInsertInfo();
            textBoxInfoToInsert.Clear();
        }

        private void textBoxNumber_Leave(object sender, EventArgs e)
        {
            ToInsertAbonent.number = textBoxNumber.Text;
            UpdateInsertInfo();
        }

        private void iconButtonClearFullNameFields_Click(object sender, EventArgs e)
        {
            FullNameFieldsClear();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AdressFieldsClear();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            NumberFiledsClear();
        }

        private void buttonClearAllFields_Click(object sender, EventArgs e)
        {
            FullNameFieldsClear();
            AdressFieldsClear();
            NumberFiledsClear();
            textBoxInfoToInsert.Clear();
        }

        private void buttonInsertByIndex_Click(object sender, EventArgs e)
        {
            InsertToListValue(2);
        }

        Abonent[] abonentsSearch = new Abonent[0];
        Abonent filterAbonent = new Abonent();
        private void buttonClearAllSearchFields_Click(object sender, EventArgs e)
        {
            filterAbonent = new Abonent();
            textBoxApartment2.Clear();
            textBoxCity2.Clear();
            textBoxFirstName2.Clear();
            textBoxHouse2.Clear();
            textBoxLastName2.Clear();
            textBoxMidName2.Clear();
            textBoxNumber2.Clear();
            textBoxStreet2.Clear();
            textBoxYear2.Clear();
            comboBoxPaymentType2.Text = string.Empty;
            checkBoxPaired2.Checked = false;
            Abonent[] clearabn = new Abonent[0];
            dataGridView2Search.DataSource = clearabn;
        }
       
        public void ReadFieldsFilter()
        {
            
            filterAbonent.firstName = textBoxFirstName2.Text=="" ? null: textBoxFirstName2.Text;
            filterAbonent.lastName = textBoxLastName2.Text == "" ? null : textBoxLastName2.Text;
            filterAbonent.middleName = textBoxMidName2.Text=="" ? null: textBoxMidName2.Text;
            filterAbonent.city = textBoxCity2.Text=="" ? null : textBoxCity2.Text;
            filterAbonent.street = textBoxStreet2.Text == "" ? null : textBoxStreet2.Text;
            filterAbonent.house = textBoxHouse2.Text == "" ? null : textBoxHouse2.Text;
            filterAbonent.apartment = textBoxApartment2.Text == "" ? null : textBoxApartment2.Text;
            filterAbonent.number = textBoxNumber2.Text == "" ? null : textBoxNumber2.Text;
            filterAbonent.isPaired = checkBoxPaired2.Checked;
            filterAbonent.paymentType = comboBoxPaymentType2.Text == "" ? null : comboBoxPaymentType2.Text;
            filterAbonent.yearOfSet = textBoxYear2.Text == "" ? null : textBoxYear2.Text;
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            ReadFieldsFilter();
            AbonentsManager am = new AbonentsManager();
                dataGridView2Search.DataSource = am.Filter(filterAbonent);
                filterAbonent = new Abonent();
          
        }

        private void insertToEndListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertParametrs();
        }
        public void InsertParametrs()
        {

            bool isBeforeSelectInsert = radioButtonUpSelected.Checked;
            bool isAfterSelectInsert = radioButtonDownSelected.Checked;
            int? selectedRowIndex = dataGridView1.CurrentRow.Index;
            Abonent abn = new Abonent();
            int n = (int)selectedRowIndex;
            if (selectedRowIndex != 0 && selectedRowIndex != null)
            {
                int k = (int)selectedRowIndex;
                if (isBeforeSelectInsert)
                {
                    AbonentsManager.AddByIndex(k, abn);
                }
                else if (isAfterSelectInsert)
                {
                    AbonentsManager.AddByIndex((k + 1), abn);
                }
                else
                {
                    AbonentsManager.AddToEnd(abn);
                }

            }
            else
            {
                if (isBeforeSelectInsert)
                {
                    AbonentsManager.AddToStart(abn);
                }
                else if (isAfterSelectInsert)
                {
                    AbonentsManager.AddToEnd(abn);
                }
                else
                {
                    AbonentsManager.AddToEnd(abn);
                }
            }
            dataGridView1.Rows[n].Selected = true;
            DataGridLoad();
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertParametrs();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveParametrs();
        }

        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void clearTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbonentsManager.abonents = new Abonent[1];
            dataGridView1.DataSource = AbonentsManager.abonents;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExitDialog ext = new ExitDialog())
            {
                ext.LoadPath(fileReaderWriter.currentFilePath);
                ext.ShowDialog(this);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ExitDialog ext = new ExitDialog())
            {
                ext.LoadPath(fileReaderWriter.currentFilePath);
                ext.ShowDialog(this);
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            textBoxAbout1.Text += "Вартанян Андрей Сергеевич \r\nГруппа М-35 \r\n";
            textBox1.Text += "Написать программу для работы со списком абонентов\r\nТелефонный каталог\r\nФункционал:\r\nЧтение\\Запись файла\r\nВставить\\Удалить запись\r\nСортировка записей в списке по одному\\многим полю(ям)\r\nПоиск с фильтрацией\r\n";
        }

        private void byOneFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Sort1 s1 = new Sort1())
            {
                s1.ShowDialog(this);
                s1.Focus();
                s1.Validate();
                int? indexColumnToSort = s1.indexCTS();
                bool isAscending = s1.isAscen();
                bool isDescending = s1.isDescendin;
                AbonentsManager am = new AbonentsManager();
                dataGridView1.DataSource = am.SortOneField(indexColumnToSort,isAscending,isDescending);
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
                currentLog = "\r\nList was sorted by the field: " + s1.Log() + "\r\n";
                textBoxStatus.AppendText(currentLog);
                
            }
        }

        private void buttonSort1Field_Click(object sender, EventArgs e)
        {

          
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Sort2 s2 = new Sort2())
            {
                s2.ShowDialog(this);
                s2.Focus();
                s2.Validate();
                bool[] sortParams = s2.sortParamGet();
                bool ascending = s2.GetAscending();
                bool descending = s2.GetDescending();
                AbonentsManager am = new AbonentsManager();
                dataGridView1.DataSource = am.MultiSort(sortParams,ascending,descending);
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
                currentLog = "\r\nList was sorted by by several fields\r\n";
                textBoxStatus.AppendText(currentLog);
            }    
        }

        private void buttonErrorsOk_Click(object sender, EventArgs e)
        {
            textBoxErrors.Text = string.Empty;
            groupBoxErrors.Visible = false;
        }

        //   private void NumberFiledsClear
    }
}
