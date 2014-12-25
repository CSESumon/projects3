using CSVLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyExpense_App
{
    public partial class totalExpenseViewListBox : Form
    {
        public totalExpenseViewListBox()
        {
            InitializeComponent();
        }

        private void categoryViewlabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryEntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private string path = @"F:\Lab Test-17-12-14\DailyExpense.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {

            string amount = amountEntryTextBox.Text;
            string category = categoryEntryComboBox.Text;
            string particuler = particulerEntryTextBox.Text;

            FileStream afFileStream = new FileStream(path, FileMode.Append);
            CsvFileWriter acCsvFileWriter = new CsvFileWriter(afFileStream);

            List<string> aList = new List<string>();

            aList.Add(amount);
            aList.Add(category);
            aList.Add(particuler);

            acCsvFileWriter.WriteRow(aList);
            afFileStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            
        }

        

        private void showSummaryViewButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
