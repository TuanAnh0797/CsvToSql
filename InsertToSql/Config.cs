using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertToSql
{
    internal class Config
    {
        
            public string ConnectionString { get; set; }
            public Watch_Folder WatchFolder { get; set; }

            public History_Folder HistoryFolder { get; set; }


        public class Watch_Folder
        {
            public string VP { get; set; }
            public string GAS { get; set; }
            public string WI1WITH { get; set; }
            public string WI1START { get; set; }
            public string IP { get; set; }
            public string DF { get; set; }
            public string TEMP { get; set; }
            public string IOT { get; set; }
            public string WI2 { get; set; }
            public string PAN { get; set; }
            public string CAMBACK { get; set; }
            public string CAMFRONT { get; set; }
        }
        public class History_Folder
        {
            public string VP { get; set; }
            public string GAS { get; set; }
            public string WI1WITH { get; set; }
            public string WI1START { get; set; }
            public string IP { get; set; }
            public string DF { get; set; }
            public string TEMP { get; set; }
            public string IOT { get; set; }
            public string WI2 { get; set; }
            public string PAN { get; set; }
            public string CAMBACK { get; set; }
            public string CAMFRONT { get; set; }
        }

    }
}
