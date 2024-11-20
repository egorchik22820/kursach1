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

        private DataSet _resSet;
        private SqlDataAdapter _resAdapter;

        private DataSet _projSet;
        private SqlDataAdapter _projAdapter;

        private DataSet _selectSet;
        private SqlDataAdapter _selectAdapter;

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
                string selectProj = "select * from Projects;";
                string selectRes = "select * from Resources;";


                _projResSet = new DataSet();
                _projSet = new DataSet();
                _resSet = new DataSet();
                _selectSet = new DataSet();

                _projResAdapter = new SqlDataAdapter(selectTable, sqlConnection);
                _resAdapter = new SqlDataAdapter(selectRes, sqlConnection);
                _projAdapter = new SqlDataAdapter(selectProj, sqlConnection);
                _selectAdapter = new SqlDataAdapter(selectProjResources, sqlConnection);

                _projResAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _resAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _selectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projResAdapter.Fill(_projResSet);
                _resAdapter.Fill(_resSet);
                _projAdapter.Fill(_projSet);
                _selectAdapter.Fill(_selectSet);

                projectsRes_dataGridView.MultiSelect = false;
                projectsRes_dataGridView.DataSource = _selectSet.Tables[0];
                projectsRes_dataGridView.Columns["ProjectResourceID"].Visible = false;
                projectsRes_dataGridView.Columns["ProjectID"].Visible = false;
                projectsRes_dataGridView.Columns["ResourceID"].Visible = false;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddProjRes addProjRes = new AddProjRes();
            addProjRes.Show();
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet.Tables[0]);
            _projSet.AcceptChanges();

            _projSet.Clear();
            _projAdapter.Fill(_projSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_resAdapter);
            _resAdapter.Update(_resSet.Tables[0]);
            _resSet.AcceptChanges();

            _resSet.Clear();
            _resAdapter.Fill(_resSet);

            SqlCommandBuilder sqlCommandBuilder3 = new SqlCommandBuilder(_projResAdapter);
            _projResAdapter.Update(_projResSet.Tables[0]);
            _projResSet.AcceptChanges();

            _projResSet.Clear();
            _projResAdapter.Fill(_projResSet);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (projectsRes_dataGridView.SelectedRows.Count > 0 && projectsRes_dataGridView.SelectedRows[0].Index < projectsRes_dataGridView.RowCount - 1)
            {

                var selectedRowIndex = projectsRes_dataGridView.SelectedRows[0].Index;

                // Показать диалоговое окно подтверждения
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow gridRow = projectsRes_dataGridView.Rows[selectedRowIndex];
                    DataTable table = (DataTable)projectsRes_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
                    DataRow dataRow = table.NewRow(); // Создаем новый DataRow

                    // Копируем данные из DataGridViewRow в DataRow
                    foreach (DataGridViewCell cell in gridRow.Cells)
                    {
                        // Проверяем, есть ли соответствующий столбец в таблице данных
                        if (table.Columns.Contains(cell.OwningColumn.Name))
                        {
                            dataRow[cell.OwningColumn.Name] = cell.Value ?? DBNull.Value;
                        }
                    }



                    DataRow row = _projResSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["ProjectResourceID"]));

                    // Удаление выбранной строки
                    projectsRes_dataGridView.Rows.RemoveAt(selectedRowIndex);

                    projectsRes_dataGridView.DataSource = _projResSet.Tables[0];
                    projectsRes_dataGridView.Rows.RemoveAt(_projResSet.Tables[0].Rows.IndexOf(row));
                }

                SaveData();
                projectsRes_dataGridView.DataSource = _selectSet.Tables[0];

            }
            else
            {
                // Если строка не выбрана, показать сообщение
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = -1;
            if (projectsRes_dataGridView.SelectedRows.Count > 0 &&
                projectsRes_dataGridView.SelectedRows[0].Index < projectsRes_dataGridView.Rows.Count - 1)
            {
                selectedRowIndex = projectsRes_dataGridView.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактирование записи",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedRowIndex = projectsRes_dataGridView.SelectedRows[0].Index;
            DataGridViewRow gridRow = projectsRes_dataGridView.Rows[selectedRowIndex];
            DataTable table = (DataTable)projectsRes_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
            DataRow dataRow = table.NewRow(); // Создаем новый DataRow

            // Копируем данные из DataGridViewRow в DataRow
            foreach (DataGridViewCell cell in gridRow.Cells)
            {
                // Проверяем, есть ли соответствующий столбец в таблице данных
                if (table.Columns.Contains(cell.OwningColumn.Name))
                {
                    dataRow[cell.OwningColumn.Name] = cell.Value ?? DBNull.Value;
                }
            }

            //int index = _employeeSet.Tables[0].Rows.IndexOf(_userSet.Tables[0].Rows[4]);


            DataRow row = _projResSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["ProjectResourceID"]));

            int idProjRes = Convert.ToInt32(dataRow["ProjectResourceID"]);
            int idRes = Convert.ToInt32(dataRow["ResourceID"]);

            EditProjRes editProjFin = new EditProjRes(idProjRes, idRes,
                                                        _projResSet, _projResAdapter,
                                                        _projSet, _projAdapter,
                                                        _resSet, _resAdapter);
            editProjFin.Show();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            (projectsRes_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Проект like '%{Search_textBox.Text}%'";
        }

        private void AddRes_button_Click(object sender, EventArgs e)
        {
            AddRes addRes = new AddRes();
            this.Hide();
            addRes.ShowDialog();
            this.Show();
        }
    }
}
