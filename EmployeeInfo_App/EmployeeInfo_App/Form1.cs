using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee aEmployee = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployee.id = idTextBox.Text;
            aEmployee.name = nameTextBox.Text;
            aEmployee.salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show(aEmployee.id + " \n" + aEmployee.name + " \n" + aEmployee.salary);

            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();

        }

       
        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployee.id;
            nameTextBox.Text = aEmployee.name;
            salaryTextBox.Text = Convert.ToString(aEmployee.salary);
        }
    }
}
