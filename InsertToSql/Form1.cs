using Newtonsoft.Json;
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
        //ReadWriteCsv csv_VP = new ReadWriteCsv();
        //ReadWriteCsv csv_GAS = new ReadWriteCsv();
        //ReadWriteCsv csv_WI1WITH = new ReadWriteCsv();
        //ReadWriteCsv csv_WI1START = new ReadWriteCsv();
        //ReadWriteCsv csv_IP = new ReadWriteCsv();
        //ReadWriteCsv csv_DF = new ReadWriteCsv();
        //ReadWriteCsv csv_TEMP = new ReadWriteCsv();
        //ReadWriteCsv csv_IOT = new ReadWriteCsv();
        //ReadWriteCsv csv_PAN = new ReadWriteCsv();
        //ReadWriteCsv csv_CAMBACK = new ReadWriteCsv();
        //ReadWriteCsv csv_CAMFRONT = new ReadWriteCsv();
        Config myconfig;
        string currentdirec = "";

        public Form1()
        {
            InitializeComponent();
            try
            {
                currentdirec = Directory.GetCurrentDirectory() + "//config.json";
                string contentconfig = "";
                using (FileStream fs = new FileStream(currentdirec, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        contentconfig = sr.ReadToEnd();
                    }
                }
                myconfig = JsonConvert.DeserializeObject<Config>(contentconfig);
                innitwatchfile();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void innitwatchfile()
        {
            //1.VP
            fsw_VP.Path = myconfig.WatchFolder.VP;
            fsw_VP.EnableRaisingEvents = true;

            //2.GAS

            //3.WI1WITH

            //4.WITH1START

            //5.IP

            //6.DF

            //7.TEMP

            //8.IOT

            //9.PAN

            //10.CAMBACK

            //11.CAMFRONT


        }
        public List<string> ReadFile(string FilePath, int skipline)
        {
            List<string> datacsv = new List<string>();
            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        datacsv.Add(sr.ReadLine());
                    }
                }
                for (int i = 0; i < skipline; i++)
                {
                    datacsv.RemoveAt(i);
                }
            }
            return datacsv;
        }
        public DataTable ConvertListToDatatable(List<string> datacsv)
        {
            DataTable dt = new DataTable();
            int numbercolumn = datacsv[0].Split(',').Length;
            for (int i = 0; i < numbercolumn; i++)
            {
                dt.Columns.Add();
            }
            foreach (string datacsvrow in datacsv)
            {
                DataRow dr = dt.NewRow();
                string[] datarow = datacsvrow.Split(',');
                for (int i = 0; i < numbercolumn; i++)
                {
                    dr[i] = datarow[i].Trim();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public void RenameFile(string filepath, string newname)
        {
            string newFilePath = Path.Combine(Path.GetDirectoryName(filepath), newname);
            File.Move(filepath, newFilePath);
        }
        public void SaveSql(string nametable, DataTable data)
        {
            using (SqlConnection connection = new SqlConnection(myconfig.ConnectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = nametable;
                    bulkCopy.WriteToServer(data);
                }
                connection.Close();
            }
        }
        public void savelog(string filepath, string content)
        {
            using (StreamWriter sw = new StreamWriter(filepath, true, Encoding.UTF8))
            {
                string datetimenow = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                sw.WriteLine(datetimenow+": "+ content);
            }
        }

        private void fsw_VP_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                string currentname = e.Name.Split('.')[0];
                List<string> datacsv = ReadFile(e.FullPath,0);
                DataTable dt = ConvertListToDatatable(datacsv);
                //SaveSql("DataVP", dt);
                RenameFile(e.FullPath, currentname_);
            }
            catch (Exception ex)
            {
                savelog(currentdirec + "//log_VP.txt", ex.Message);
            }
        }

        
    }
}
