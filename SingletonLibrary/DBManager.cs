using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SingletonLibrary
{
    public class DBManager
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private static DBManager instance;
        Logger logger;

        private DBManager()
        {
            logger = new Logger();
            con = new MySqlConnection(@"Server=localhost;Database=sakila;Uid=root;Pwd=Aezakmi!1");
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        private DBManager(string conStr)
        {
            con = new MySqlConnection(conStr);
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        public static DBManager GetInstance()
        {
            if (instance == null)
                instance = new DBManager();
            return instance;
        }

        public static DBManager GetInstance(string conStr)
        {
            if (instance == null)
                instance = new DBManager(conStr);
            return instance;
        }

        public void FillGrid(DataGridView dataGridView, MySqlDataReader MyR)
        {
            dataGridView.Columns.Clear();
            for (int i = 0; i < MyR.FieldCount; i++)
            {
                dataGridView.Columns.Add("Col" + i.ToString(), MyR.GetName(i));
            }

            while (MyR.Read())
            {
                string[] s = new string[MyR.FieldCount];
                for (int i = 0; i < MyR.FieldCount; i++)
                {
                    s[i] = MyR[i].ToString();
                }

                dataGridView.Rows.Add(s);
            }
        }

        public void SelectAll(string tablename, DataGridView dataGridView)
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from " + tablename;
                MySqlDataReader myR = cmd.ExecuteReader();
                FillGrid(dataGridView, myR);
                logger.Info(cmd.CommandText);
                logger.Save();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
