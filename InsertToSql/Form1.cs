using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InsertToSql
{
    public partial class Form1 : Form
    {
        ReadWriteCsv csv = new ReadWriteCsv();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = csv.ReadFile("C:\\Users\\70P7970\\Desktop\\New folder (2)\\abc.csv", 1);
            DataTable dt = csv.ConvertListToDatatable(data);
            csv.RenameFile("C:\\Users\\70P7970\\Desktop\\New folder (2)\\abc.csv", "abc_1.csv");
            getfilecsv();
        }
        public void getfilecsv()
        {
            string[] f = Directory.GetFiles("C:\\Users\\70P7970\\Desktop\\New folder (2)", "*.csv");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string filepath = "C:\\Users\\70P7970\\Desktop\\New folder (2)\\abc.txt";
        //    string newFilePath = Path.Combine(Path.GetDirectoryName(filepath), textBox1.Text + ".txt");
        //    try
        //    {
        //        File.Move(filepath, newFilePath);
        //        MessageBox.Show("OK");
        //        SqlBulkCopy abc = new SqlBulkCopy(newFilePath);

        //        List<string> list = new List<string>();

        //        abc.WriteToServer()
        //    }
        //    catch (Exception ex)
        //    {
        //       MessageBox.Show(ex.Message); 
        //    }
        //}
    }
}
