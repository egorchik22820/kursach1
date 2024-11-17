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
    public partial class Projects : Form
    {
        private DataSet _projSet;
        //private DataSet _projResSet;
        //private DataSet _projFinSet;

        private SqlDataAdapter _projAdapter;
        //private SqlDataAdapter _projResAdapter;
        //private SqlDataAdapter _projFinAdapter;
        

        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectProjects = "select * from Projects;";
                //string selectProjResources = "select PR.ProjectResourceID, PR.ProjectID, PR.ResourceID, P.ProjectName as 'Проект', R.ResourceName as 'Ресурс', PR.Quantity as 'Кол-во', PR.TotalCost as 'Стоимость' from ProjectResources PR\r\njoin Projects P on P.ProjectID = PR.ProjectID\r\njoin Resources R on R.ResourceID = PR.ResourceID;";
                //string selectProjFin = ";";

                _projSet = new DataSet();
                //_projResSet = new DataSet();
                //_projFinSet = new DataSet();

                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);
                //_projResAdapter = new SqlDataAdapter(selectProjResources, sqlConnection);
                //_projFinAdapter = new SqlDataAdapter();

                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projAdapter.Fill(_projSet);

                projects_dataGridView.MultiSelect = false;
                projects_dataGridView.DataSource = _projSet.Tables[0];
                projects_dataGridView.Columns["ProjectID"].Visible = false;

            }
        }
    }
}
