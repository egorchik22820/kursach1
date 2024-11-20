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
    public partial class AddProjRes : Form
    {
        private DataSet _projSet = new DataSet();
        private SqlDataAdapter _projAdapter;

        private DataSet _projResSet = new DataSet();
        private SqlDataAdapter _projResAdapter;

        private DataSet _resSet = new DataSet();
        private SqlDataAdapter _resAdapter;

        private List<ProjectsClass> _projList = new List<ProjectsClass>();
        private List<Resources> _resList = new List<Resources>();
        public AddProjRes()
        {
            InitializeComponent();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectProjects = "select * from Projects;";
                string selectProjRes = "select * from ProjectResources;";
                string selectRes = "select * from Resources;";



                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);
                _projAdapter.Fill(_projSet);

                _projResAdapter = new SqlDataAdapter(selectProjRes, sqlConnection);
                _projResAdapter.Fill(_projResSet);

                _resAdapter = new SqlDataAdapter(selectRes, sqlConnection);
                _resAdapter.Fill(_resSet);

                foreach (DataRow typeRow in _projSet.Tables[0].Rows)
                {
                    _projList.Add(new ProjectsClass(typeRow["ProjectName"].ToString(),
                        Convert.ToInt32(typeRow["ProjectID"])));
                }

                foreach (DataRow typeRow in _resSet.Tables[0].Rows)
                {
                    _resList.Add(new Resources(typeRow["ResourceName"].ToString(),
                        Convert.ToInt32(typeRow["ResourceID"])));
                }

                ProjectName_comboBox.DataSource = _projList;
                Resource_comboBox.DataSource= _resList;

            }
            else MessageBox.Show("connection is shit");
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet);

            SqlCommandBuilder sqlCommandBuilder3 = new SqlCommandBuilder(_resAdapter);
            _resAdapter.Update(_resSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_projResAdapter);
            _projResAdapter.Update(_projResSet);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            DataRow newRow = _projResSet.Tables[0].NewRow();

            newRow["ProjectID"] = (ProjectName_comboBox.SelectedItem as ProjectsClass).ProjID.ToString();
            newRow["ResourceID"] = (Resource_comboBox.SelectedItem as Resources).ResourceID.ToString();

            newRow["Quantity"] = Quantity_textBox.Text.ToString();
            newRow["TotalCost"] = Amount_textBox.Text.ToString();

            if (!string.IsNullOrEmpty(Quantity_textBox.Text) && !string.IsNullOrEmpty(Amount_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Quantity_textBox.Text)&& !string.IsNullOrWhiteSpace(Amount_textBox.Text))
            {
                _projResSet.Tables[0].Rows.Add(newRow);
                SaveData();
                MessageBox.Show("Пополнение завершено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}
