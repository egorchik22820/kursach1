using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        //private DataSet _tasksSet;
        //private DataSet _employeeTasksSet;

        private SqlDataAdapter _projAdapter;
        //private SqlDataAdapter _projResAdapter;
        //private SqlDataAdapter _projFinAdapter;
        //private SqlDataAdapter _tasksAdapter;
        //private SqlDataAdapter _employeeTasksAdapter;


        public Projects()
        {
            InitializeComponent();

            // Подписываемся на событие
            projects_dataGridView.CellEndEdit += new DataGridViewCellEventHandler(projects_dataGridView_CellEndEdit);
        }

        private void Projects_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectProjects = "select * from Projects;";
                //string selectProjResources = "select * from ProjectResources;";
                //string selectProjFin = "select * from ProjectFinances;";
                //string selectTasks = "select * from Tasks;";
                //string selectEmployeeTasks = "select * from EmployeeTasks;";

                _projSet = new DataSet();
                //_projResSet = new DataSet();
                //_projFinSet = new DataSet();
                //_tasksSet = new DataSet();
                //_employeeTasksSet = new DataSet();

                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);
                //_projResAdapter = new SqlDataAdapter(selectProjResources, sqlConnection);
                //_projFinAdapter = new SqlDataAdapter(selectProjFin, sqlConnection);
                //_tasksAdapter = new SqlDataAdapter(selectTasks, sqlConnection);
                //_employeeTasksAdapter = new SqlDataAdapter(selectEmployeeTasks, sqlConnection);

                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //_projResAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //_projFinAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //_tasksAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //_employeeTasksAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;


                _projAdapter.Fill(_projSet);
                //_projResAdapter.Fill(_projResSet);
                //_projFinAdapter.Fill(_projFinSet);
                //_tasksAdapter.Fill(_tasksSet);
                //_employeeTasksAdapter.Fill(_employeeTasksSet);

                projects_dataGridView.MultiSelect = false;
                projects_dataGridView.DataSource = _projSet.Tables[0];
                projects_dataGridView.Columns["ProjectID"].Visible = false;

                // Подписываемся на событие
                //projects_dataGridView.CellEndEdit += new DataGridViewCellEventHandler(projects_dataGridView_CellEndEdit);

            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddProj addProj = new AddProj();
            addProj.Show();
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet.Tables[0]);
            _projSet.AcceptChanges();

            _projSet.Clear();
            _projAdapter.Fill(_projSet);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (projects_dataGridView.SelectedRows.Count > 0 && projects_dataGridView.SelectedRows[0].Index < projects_dataGridView.RowCount - 1)
            {

                var selectedRowIndex = projects_dataGridView.SelectedRows[0].Index;

                // Показать диалоговое окно подтверждения
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаление выбранной строки
                    projects_dataGridView.Rows.RemoveAt(selectedRowIndex);
                }

                SaveData();

            }
            else
            {
                // Если строка не выбрана, показать сообщение
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {

        }

        private void projects_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)// коряво работает
        {
            try
            {
                // Сохраняем изменения в базе данных
                //_projAdapter.Update(_projSet);

                SaveData();
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message);
            }
        }
    }
}
