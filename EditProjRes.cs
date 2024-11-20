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
using System.Windows.Forms.VisualStyles;

namespace kursach
{
    public partial class EditProjRes : Form
    {
        private int _idRes;
        private int _idProjRes;

        private DataSet _projResSet;
        private SqlDataAdapter _projResAdapter;

        private DataSet _projSet;
        private SqlDataAdapter _projAdapter;

        private DataSet _resSet;
        private SqlDataAdapter _resAdapter;

        private List<ProjectsClass> _projectsList = new List<ProjectsClass>();
        private List<Resources> _resList = new List<Resources>();
        public EditProjRes(int idProjRes, int idRes,
                            DataSet projResSet, SqlDataAdapter projResAdapter,
                            DataSet projSet, SqlDataAdapter projAdapter,
                            DataSet resSet, SqlDataAdapter resAdapter)
        {
            InitializeComponent();

            _idRes = idRes;
            _idProjRes = idProjRes;

            _projResSet = projResSet;
            _projSet = projSet;
            _resSet = resSet;

            _resAdapter = resAdapter;
            _projAdapter = projAdapter;
            _projResAdapter = projResAdapter;

            var row1 = _resSet.Tables[0].Rows.Find(idRes);// хард код с индексами, пошли они нахуй, потом переделаю
            var row2 = _resSet.Tables[0].Rows.Find(idRes);

            var row3 = _projResSet.Tables[0].Rows.Find(idProjRes);

            Quantity_textBox.Text = row3["Quantity"].ToString();
            Amount_textBox.Text = row3["TotalCost"].ToString();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectTable = "select * from ProjectResources;";
                string selectProj = "select * from Projects;";
                string selectRes = "select * from Resources;";


                _projResSet = new DataSet();
                _projSet = new DataSet();
                _resSet = new DataSet();

                _projResAdapter = new SqlDataAdapter(selectTable, sqlConnection);
                _resAdapter = new SqlDataAdapter(selectRes, sqlConnection);
                _projAdapter = new SqlDataAdapter(selectProj, sqlConnection);

                _projResAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _resAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projResAdapter.Fill(_projResSet);
                _resAdapter.Fill(_resSet);
                _projAdapter.Fill(_projSet);

                foreach (DataRow typeRow in _projSet.Tables[0].Rows)
                {
                    _projectsList.Add(new ProjectsClass(typeRow["ProjectName"].ToString(),
                        Convert.ToInt32(typeRow["ProjectID"])));
                }

                foreach (DataRow typeRow in _resSet.Tables[0].Rows)
                {
                    _resList.Add(new Resources(typeRow["ResourceName"].ToString(),
                        Convert.ToInt32(typeRow["ResourceID"])));
                }

                ProjectName_comboBox.DataSource = _projectsList;
                Resource_comboBox.DataSource = _resList;
            }
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projResAdapter);
            _projResAdapter.Update(_projResSet.Tables[0]);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_projResAdapter);
            if (!string.IsNullOrEmpty(Quantity_textBox.Text) && !string.IsNullOrEmpty(Amount_textBox.Text) && 
                !string.IsNullOrWhiteSpace(Quantity_textBox.Text) && !string.IsNullOrWhiteSpace(Amount_textBox.Text))
            {
                var row1 = _resSet.Tables[0].Rows.Find(_idRes);// хард код с индексами, пошли они нахуй, потом переделаю
                var row2 = _resSet.Tables[0].Rows.Find(_idRes);
                var row3 = _projResSet.Tables[0].Rows.Find(_idProjRes);

                row3["ResourceID"] = (Resource_comboBox.SelectedItem as Resources).ResourceID.ToString();
                row3["ProjectID"] = (ProjectName_comboBox.SelectedItem as ProjectsClass).ProjID.ToString();
                row3["Quantity"] = Quantity_textBox.Text.ToString();
                row3["TotalCost"] = Amount_textBox.Text.ToString();

                SaveData();
                Close();

            }
        }
    }
}
