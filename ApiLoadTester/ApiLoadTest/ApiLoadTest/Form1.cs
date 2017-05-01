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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ApiLoadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = fdlg.FileName;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CustomerData customer = new CustomerData();
            //customer.FirstName = textBox6.Text;
            //customer.LastName = textBox5.Text;

            //// Create and XmlSerializer to serialize the data to a file
            //XmlSerializer xs = new XmlSerializer(typeof(CustomerData));
            //using (FileStream fs = new FileStream("Data.xml", FileMode.Create))
            //{
            //    xs.Serialize(fs, customer);
            //}

            string path = "Data.xml";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            //Adding columns to datatable
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                DataColumn column = new DataColumn(dataGridView1.Columns[i - 1].HeaderText);
                dt.Columns.Add(column);
            }
            //adding new rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow row1 = dt.NewRow();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    //if value exists add that value else add Null for that field
                    row1[i] = (row.Cells[i].Value == null ? DBNull.Value : row.Cells[i].Value);
                dt.Rows.Add(row1);
            }




            //for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            //{
            //    DataColumn column = new DataColumn(dataGridView2.Columns[i - 1].HeaderText);
            //    dt.Columns.Add(column);
            //}
            ////adding new rows
            //foreach (DataGridViewRow row in dataGridView2.Rows)
            //{
            //    DataRow row1 = dt.NewRow();
            //    for (int i = 0; i < dataGridView2.ColumnCount; i++)
            //        //if value exists add that value else add Null for that field
            //        row1[i] = (row.Cells[i].Value == null ? DBNull.Value : row.Cells[i].Value);
            //    dt.Rows.Add(row1);
            //}

            XmlFile customer = new XmlFile();
            customer.InputFile = textBox6.Text;
            customer.Column = textBox5.Text;


           

            
            




            //Copying from datatable to dataset
            ds.Tables.Add(dt);
          
            //writing new values to XML
            ds.WriteXml(path);
            MessageBox.Show("Successfully added ", "Success");
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
