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
    public partial class ProjResources : Form
    {
        private DataSet _projResSet;
        private SqlDataAdapter _projResAdapter;

        public ProjResources()
        {
            InitializeComponent();
        }

        private void ProjResources_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectTable = "select * from ProjectResources;";
                string selectProjResources = "select PR.ProjectResourceID, PR.ProjectID, PR.ResourceID, P.ProjectName as 'Проект', R.ResourceName as 'Ресурс', PR.Quantity as 'Кол-во', PR.TotalCost as 'Стоимость' from ProjectResources PR\r\njoin Projects P on P.ProjectID = PR.ProjectID\r\njoin Resources R on R.ResourceID = PR.ResourceID;";

                _projResSet = new DataSet();

                _projResAdapter = new SqlDataAdapter(selectProjResources + selectTable, sqlConnection);

                _projResAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projResAdapter.Fill(_projResSet);

                projectsRes_dataGridView.MultiSelect = false;
                projectsRes_dataGridView.DataSource = _projResSet.Tables[0];
                projectsRes_dataGridView.Columns["ProjectResourceID"].Visible = false;
                projectsRes_dataGridView.Columns["ProjectID"].Visible = false;
                projectsRes_dataGridView.Columns["ResourceID"].Visible = false;
            }
        }
    }
}
