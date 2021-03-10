using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOA避雷器
{
     public class Model      
     {
        static string strpath = Application.StartupPath;

        static string _connectionString = "data source=" + strpath + "\\SQLite\\MOALightningArrester";

        public static string ConnectionString
        {
            get { return Model._connectionString; }
            set { Model._connectionString = value; }
        }

    }
}
