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
    public partial class ProjFin : Form
    {
        private DataSet _projFinSet;
        private SqlDataAdapter _projFinAdapter;
        public ProjFin()
        {
            InitializeComponent();
        }

        private void ProjFin_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectTable = "select * from ProjectFinances;";
                string selectProjectFinances = "select PF.FinanceID, PF.ProjectID, P.ProjectName as 'Проект', PF.ExpenseDescription as 'Описание', PF.Amount as 'Стоимость', PF.Date as 'Дата' from ProjectFinances PF\r\njoin Projects P on P.ProjectID = PF.ProjectID;";

                _projFinSet = new DataSet();

                _projFinAdapter = new SqlDataAdapter(selectProjectFinances + selectTable, sqlConnection);

                _projFinAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projFinAdapter.Fill(_projFinSet);

                projectsFin_dataGridView.MultiSelect = false;
                projectsFin_dataGridView.DataSource = _projFinSet.Tables[0];
                projectsFin_dataGridView.Columns["FinanceID"].Visible = false;
                projectsFin_dataGridView.Columns["ProjectID"].Visible = false;
            }
        }
    }
}
