using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atletikaVB
{
    public partial class atletikaVB2017 : Form
    {
        public atletikaVB2017()
        {
            InitializeComponent();
        }
        private void atletikaVB2017_Load(object sender, EventArgs e)
        {
            
        }

        private void AranyNemzetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AranyNemzetListBox.Items.Clear();
            try
            {

            }
            catch
            {

            }
        }

        private void VersenySzamTextBox_TextChanged(object sender, EventArgs e)
        {
            AranyNemzetListBox.Items.Clear();
            try
            {
               
            }
            catch
            {

            }        
        }
    }
}
