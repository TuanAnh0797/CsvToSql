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
using System.Threading.Tasks;
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
        bool is_VP_run = false;
        bool is_GAS_run = false;
        bool is_WI1WITH_run = false;
        bool is_WI1START_run = false;
        bool is_IP_run = false;
        bool is_DF_run = false;
        bool is_WI2_run = false;
        bool is_PAN_run = false;

        Config myconfig;
        string currentdirec = "";

        public Form1()
        {
            InitializeComponent();
            try
            {
                currentdirec = Directory.GetCurrentDirectory();
                string fileconfig = currentdirec + "\\config.json";
                string contentconfig = "";
                using (FileStream fs = new FileStream(fileconfig, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        contentconfig = sr.ReadToEnd();
                    }
                }
                myconfig = JsonConvert.DeserializeObject<Config>(contentconfig);
                InnitWatchFile();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void InnitWatchFile()
        {
            //1.VP
            Time_VP.Start();
            //2.GAS
            Timer_GAS.Start();
            //3.WI1WITH
            Timer_WI1WITH.Start();
            //4.WITH1START
            Timer_WI1START.Start();
            //5.IP
            Timer_IP.Start();
            //6.DF
            Timer_DF.Start();
            //7.TEMP

            //8.IOT

            //9.WI2
            Timer_WI2.Start();
            //10.PAN
            Timer_PAN.Start();
            //11.CAMBACK

            //12.CAMFRONT


        }
       
        public void CoppyFile(string historyfolder,string sourcefile, string namefile)
        {
            string strdate = DateTime.Now.ToString("ddMMyyyy");
            if (Directory.Exists(historyfolder + "\\"+ strdate))
            {
                File.Copy(sourcefile, historyfolder + "\\" + strdate + "\\"+namefile,true);
            }
            else
            {
                Directory.CreateDirectory(historyfolder + "\\" + strdate);
                File.Copy(sourcefile, historyfolder + "\\" + strdate + "\\" + namefile,true);
            }
           
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
                if (datacsv.Count > skipline)
                {
                    for (int i = 0; i < skipline; i++)
                    {
                        datacsv.RemoveAt(i);
                    }
                }
            }
            return datacsv;
        }
        public DataTable ConvertListToDatatable(List<string> datacsv)
        {
            DataTable dt = new DataTable();
            if (datacsv.Count > 0)
            {
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
        public void SaveLog(string filepath, string content)
        {
            using (StreamWriter sw = new StreamWriter(filepath, true, Encoding.UTF8))
            {
                string datetimenow = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
                sw.WriteLine(datetimenow+": "+ content);
            }
        }

        public async Task GetAllFile(string pathfolder, string HistoryFoler, string FileLog)
        {
            try
            {
                await Task.Factory.StartNew(() =>
                {
                    foreach (string filePath in Directory.EnumerateFiles(pathfolder, "*.csv", SearchOption.AllDirectories))
                    {
                        try
                        {
                            List<string> datacsv = ReadFile(filePath, 1);
                            DataTable data = ConvertListToDatatable(datacsv);
                            //SaveSql("", data);
                            CoppyFile(HistoryFoler, filePath, Path.GetFileName(filePath));
                            File.Delete(filePath);
                        }
                        catch (Exception ex)
                        {
                            SaveLog(currentdirec + $"\\Log\\{FileLog}", filePath +": "+ ex.Message);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                SaveLog(currentdirec + $"\\Log\\{FileLog}", ex.Message);
            }
        }

        private async void Time_VP_Tick(object sender, EventArgs e)
        {
            if (!is_VP_run)
            {
                is_VP_run = true;
                string logfile = "VP_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.VP, currentdirec + "\\History\\" + myconfig.HistoryFolder.VP, logfile);
                is_VP_run = false;
            }
        }

        private async void Timer_GAS_Tick(object sender, EventArgs e)
        {
            if (!is_GAS_run)
            {
                is_GAS_run = true;
                string logfile = "GAS_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.GAS, currentdirec + "\\History\\" + myconfig.HistoryFolder.GAS, logfile);
                is_GAS_run = false;
            }
        }

        private async void Timer_WI1WITH_Tick(object sender, EventArgs e)
        {
            if (!is_WI1WITH_run)
            {
                is_WI1WITH_run = true;
                string logfile = "WI1WITH_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.WI1WITH, currentdirec + "\\History\\" + myconfig.HistoryFolder.WI1WITH, logfile);
                is_WI1WITH_run = false;
            }
        }

        private async void Timer_WI1START_Tick(object sender, EventArgs e)
        {
            if (!is_WI1START_run)
            {
                is_WI1START_run = true;
                string logfile = "WI1START_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.WI1START, currentdirec + "\\History\\" + myconfig.HistoryFolder.WI1START, logfile);
                is_WI1START_run = false;
            }
        }

        private async void Timer_IP_Tick(object sender, EventArgs e)
        {
            if (!is_IP_run)
            {
                is_IP_run = true;
                string logfile = "IP_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.IP, currentdirec + "\\History\\" + myconfig.HistoryFolder.IP, logfile);
                is_IP_run = false;
            }
        }

        private async void Timer_DF_Tick(object sender, EventArgs e)
        {
            if (!is_DF_run)
            {
                is_DF_run = true;
                string logfile = "DF_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.DF, currentdirec + "\\History\\" + myconfig.HistoryFolder.DF, logfile);
                is_DF_run = false;
            }
        }

        private async void Timer_WI2_Tick(object sender, EventArgs e)
        {
            if (!is_WI2_run)
            {
                is_WI2_run = true;
                string logfile = "WI2_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.WI2, currentdirec + "\\History\\" + myconfig.HistoryFolder.WI2, logfile);
                is_WI2_run = false;
            }
        }

        private async void Timer_PAN_Tick(object sender, EventArgs e)
        {
            if (!is_PAN_run)
            {
                is_PAN_run = true;
                string logfile = "PAN_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                await GetAllFile(myconfig.WatchFolder.PAN, currentdirec + "\\History\\" + myconfig.HistoryFolder.PAN, logfile);
                is_PAN_run = false;
            }
        }
    }
}
