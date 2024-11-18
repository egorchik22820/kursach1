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

namespace kursach
{
    public partial class AddProj : Form
    {
        private DataSet _projSet = new DataSet();
        private SqlDataAdapter _projAdapter;

        public AddProj()
        {
            InitializeComponent();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {

                string selectProjects = "select * from Projects;";

                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);
                _projAdapter.Fill(_projSet);
            }
            else MessageBox.Show("connection is shit");
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = _projSet.Tables[0].NewRow();

            newRow["ProjectName"] = Name_textBox.Text.ToString();
            newRow["StartDate"] = StartDate_textBox.Text.ToString();
            newRow["EndDate"] = EndDate_textBox.Text.ToString();
            newRow["Status"] = Status_textBox.Text.ToString();

            if (!string.IsNullOrEmpty(StartDate_textBox.Text) && !string.IsNullOrEmpty(EndDate_textBox.Text) &&
                !string.IsNullOrEmpty(Name_textBox.Text) && !string.IsNullOrEmpty(Status_textBox.Text) &&
                !string.IsNullOrWhiteSpace(StartDate_textBox.Text) && !string.IsNullOrWhiteSpace(Status_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Name_textBox.Text) && !string.IsNullOrWhiteSpace(EndDate_textBox.Text))
            {
                _projSet.Tables[0].Rows.Add(newRow);
                SaveData();
                MessageBox.Show("Проект добавлен!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}
