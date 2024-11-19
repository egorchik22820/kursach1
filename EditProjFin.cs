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
    public partial class EditProjFin : Form
    {
        private int _itemID; 

        private DataSet _projFinSet;
        private SqlDataAdapter _projFinAdapter;

        private DataSet _projSet;
        private SqlDataAdapter _projAdapter;

        private List<ProjectsClass> _projectsList = new List<ProjectsClass>();
        public EditProjFin(int itemID,
                            DataSet projFinSet, SqlDataAdapter projFinAdapter,
                           DataSet projSet, SqlDataAdapter projAdapter)
        {
            InitializeComponent();

            _itemID = itemID;

            _projFinSet = projFinSet;
            _projFinAdapter = projFinAdapter;

            _projSet = projSet;
            _projAdapter = projAdapter;

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectTable = "select * from ProjectFinances;";
                string selectProjectFinances = "select PF.FinanceID, PF.ProjectID, P.ProjectName as 'Проект', PF.ExpenseDescription as 'Описание', PF.Amount as 'Стоимость', PF.Date as 'Дата' from ProjectFinances PF\r\njoin Projects P on P.ProjectID = PF.ProjectID;";
                string selectProjects = "select * from Projects;";

                _projFinSet = new DataSet();
                _projSet = new DataSet();


                _projFinAdapter = new SqlDataAdapter(selectTable, sqlConnection);
                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);

                _projFinAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projFinAdapter.Fill(_projFinSet);
                _projAdapter.Fill(_projSet);

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
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projFinAdapter);
            _projFinAdapter.Update(_projFinSet.Tables[0]);

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_projFinAdapter);
            if (!string.IsNullOrEmpty(Describtion_textBox.Text) && !string.IsNullOrEmpty(Amount_textBox.Text) &&
                !string.IsNullOrEmpty(Date_textBox.Text) && !string.IsNullOrWhiteSpace(Describtion_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Amount_textBox.Text) && !string.IsNullOrWhiteSpace(Date_textBox.Text))
            {

                //int index = _projFinSet.Tables[0].Rows.IndexOf(_projFinSet.Tables[0].Rows[4]);

                var row1 = _projFinSet.Tables[0].Rows.Find(_itemID);// хард код с индексами, пошли они нахуй, потом переделаю
                row1["ExpenseDescription"] = Describtion_textBox.Text.ToString();
                row1["Date"] = Date_textBox.Text.ToString();
                row1["Amount"] = Amount_textBox.Text.ToString();
                row1["ProjectID"] = ProjectName_comboBox.SelectedIndex + 1;

                SaveData();

                Close();

            }
        }
    }
}
