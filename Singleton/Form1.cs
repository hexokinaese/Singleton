using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonLibrary;

namespace Singleton
{
    public partial class Form1 : Form
    {
        private DBManager dbManager;

        public Form1()
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();       
        }    

        private void b_tactor_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("actor", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }

        private void b_tcity_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("city", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }

        private void b_tcategory_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("category", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }

        private void b_tfilm_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("film", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }

        private void b_tpayment_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("payment", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }

        private void b_tstore_Click(object sender, EventArgs e)
        {
            dbManager.SelectAll("store", dataGridView1);
            l_chosentable.Text = "Chosen table - " + ((Button)sender).Text;
        }
    }
}
