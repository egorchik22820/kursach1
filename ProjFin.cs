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
        private bool _isEditing = false;

        private DataSet _projFinSet;
        private SqlDataAdapter _projFinAdapter;

        private DataSet _projSet;
        private SqlDataAdapter _projAdapter;

        private DataSet _selectSet;
        private SqlDataAdapter _selectAdapter;
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
                string selectProjects = "select * from Projects;";

                _projFinSet = new DataSet();
                _projSet = new DataSet();
                _selectSet = new DataSet();

                _selectAdapter = new SqlDataAdapter(selectProjectFinances, sqlConnection);
                _projFinAdapter = new SqlDataAdapter(selectTable, sqlConnection);
                _projAdapter = new SqlDataAdapter(selectProjects, sqlConnection);

                _projFinAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _projAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _projFinAdapter.Fill(_projFinSet);
                _projAdapter.Fill(_projSet);
                _selectAdapter.Fill(_selectSet);

                projectsFin_dataGridView.MultiSelect = false;
                projectsFin_dataGridView.DataSource = _selectSet.Tables[0];
                projectsFin_dataGridView.Columns["FinanceID"].Visible = false;
                projectsFin_dataGridView.Columns["ProjectID"].Visible = false;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddProgFin addProgFin = new AddProgFin();
            addProgFin.Show();
        }

        private void SaveData()
        {
            

            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_projAdapter);
            _projAdapter.Update(_projSet.Tables[0]);
            _projSet.AcceptChanges();

            _projSet.Clear();
            _projAdapter.Fill(_projSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_projFinAdapter);
            _projFinAdapter.Update(_projFinSet.Tables[0]);
            _projFinSet.AcceptChanges();

            _projFinSet.Clear();
            _projFinAdapter.Fill(_projFinSet);

            SqlCommandBuilder sqlCommandBuilder3 = new SqlCommandBuilder(_selectAdapter);
            _selectAdapter.Update(_selectSet.Tables[0]);
            _selectSet.AcceptChanges();

            _selectSet.Clear();
            _selectAdapter.Fill(_selectSet);



        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (projectsFin_dataGridView.SelectedRows.Count > 0 && projectsFin_dataGridView.SelectedRows[0].Index < projectsFin_dataGridView.RowCount - 1)
            {

                var selectedRowIndex = projectsFin_dataGridView.SelectedRows[0].Index;

                // Показать диалоговое окно подтверждения
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow gridRow = projectsFin_dataGridView.Rows[selectedRowIndex];
                    DataTable table = (DataTable)projectsFin_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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



                    DataRow row = _projFinSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["FinanceID"]));

                    // Удаление выбранной строки
                    projectsFin_dataGridView.Rows.RemoveAt(selectedRowIndex);

                    projectsFin_dataGridView.DataSource = _projFinSet.Tables[0];
                    projectsFin_dataGridView.Rows.RemoveAt(_projFinSet.Tables[0].Rows.IndexOf(row));
                }

                SaveData();
                projectsFin_dataGridView.DataSource = _selectSet.Tables[0];

            }
            else
            {
                // Если строка не выбрана, показать сообщение
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = projectsFin_dataGridView.SelectedRows[0].Index;
            DataGridViewRow gridRow = projectsFin_dataGridView.Rows[selectedRowIndex];
            DataTable table = (DataTable)projectsFin_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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


            DataRow row = _projFinSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["FinanceID"]));

            int idForProgUsers = Convert.ToInt32(dataRow["FinanceID"]);

            EditProjFin editProjFin = new EditProjFin(idForProgUsers,
                                                        _projFinSet, _projFinAdapter,
                                                        _projSet, _projAdapter);
            editProjFin.Show();
        }

        
    }
}
