using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursach
{
    public partial class Autorization : Form
    {
        private DataSet _userSet = new DataSet();
        private SqlDataAdapter _adapter;


        public Autorization()
        {
            InitializeComponent();

            this.AcceptButton = button1;
        }

        private void Autorization_Activated(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (connection.State == System.Data.ConnectionState.Open)
            {
                string selectQuery = "SELECT * FROM progUsers;";
                _adapter = new SqlDataAdapter(selectQuery, connection);
                _adapter.Fill(_userSet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in _userSet.Tables[0].Rows)
            {
                if (row["UserName"].ToString() == Login_textBox.Text && row["UserPassword"].ToString() == Password_textBox.Text)
                {
                    if (row["TypeID"].ToString() == "1")
                    {
                        OpenNextForm();
                        return;
                    }
                    else
                    {
                        UserPanel userPanel = new UserPanel();
                        this.Hide();
                        userPanel.ShowDialog();
                        this.Show();
                        return;
                    }
                    

                }
            }
            MessageBox.Show("no");
        }


        private void OpenNextForm()
        {
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Show();
        }
    }
}
