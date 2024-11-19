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
    public partial class AddProgFin : Form
    {
        private DataSet _projFinSet = new DataSet();
        private SqlDataAdapter _projFinAdapter;

        private DataSet _projSet = new DataSet();
        private SqlDataAdapter _projAdapter;

        private List<ProjectsClass> _projectsList = new List<ProjectsClass>();
        public AddProgFin()
        {
            InitializeComponent();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectProjects = "select * from Projects;";
                string selectProjFin = "select * from ProjectFinances;";



                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);
                _projAdapter.Fill(_projSet);

                _projFinAdapter = new SqlDataAdapter(selectProjFin, sqlConnection);
                _projFinAdapter.Fill(_projFinSet);

                foreach (DataRow typeRow in _projSet.Tables[0].Rows)
                {
                    _projectsList.Add(new ProjectsClass(typeRow["ProjectName"].ToString(),
                        Convert.ToInt32(typeRow["ProjectID"])));
                }

                ProjectName_comboBox.DataSource = _projectsList;

            }
            else MessageBox.Show("connection is shit");

        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_projFinAdapter);
            _projFinAdapter.Update(_projFinSet);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            DataRow newRow = _projFinSet.Tables[0].NewRow();

            newRow["ProjectID"] = ProjectName_comboBox.SelectedIndex + 1;
            newRow["ExpenseDescription"] = Describtion_textBox.Text.ToString();
            newRow["Amount"] = Amount_textBox.Text.ToString();
            newRow["Date"] = Date_textBox.Text.ToString();

            if (!string.IsNullOrEmpty(Describtion_textBox.Text) && !string.IsNullOrEmpty(Date_textBox.Text) &&
                !string.IsNullOrEmpty(Amount_textBox.Text) && !string.IsNullOrWhiteSpace(Describtion_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Date_textBox.Text) && !string.IsNullOrWhiteSpace(Amount_textBox.Text))
            {
                _projFinSet.Tables[0].Rows.Add(newRow);
                SaveData();
                MessageBox.Show("Трата добавлена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}
