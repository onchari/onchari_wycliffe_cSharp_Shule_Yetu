using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shule_Yenu
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
           
            InitializeComponent();
            comboBox_level.SelectedIndex = 0;
            populate();


        }

        

        private void Login_area_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult daDialogResult = MessageBox.Show("Are you sure you intend to cancel login?",
                "Login Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (daDialogResult == DialogResult.No)
            {
                
            }
            else
            {
                Application.Exit();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox_level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void populate()
        {
            string connectiontring = @"data source=DESKTOP-06IKRA6\ANKO_CHIF;initial catalog=alloys_academy;integrated security=True;";
            SqlConnection mySqlConnection = new SqlConnection(connectiontring);
            mySqlConnection.Open();
            string sql_query = "Select * from login_categories";
            SqlCommand mySqlCommand = new SqlCommand(sql_query, mySqlConnection);
            SqlDataReader myDataReader = null;
            myDataReader = mySqlCommand.ExecuteReader();
            ArrayList myArrayList = new ArrayList();
            while (myDataReader.Read())
            {
                string k = myDataReader["category_name"].ToString();
                myArrayList.Add(k);
            }

            foreach (string cat in myArrayList)
            {
                comboBox_level.Items.Add(cat);
                //Console.WriteLine(cat);
            }
            mySqlConnection.Close();
        }











    }
    }

