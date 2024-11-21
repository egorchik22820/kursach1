using Microsoft.Data.SqlClient;
using System.Data;
//using Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

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

            //SqlCommandBuilder sqlCommandBuilder3 = new SqlCommandBuilder(_selectAdapter);
            //_selectAdapter.Update(_selectSet.Tables[0]);
            //_selectSet.AcceptChanges();

            //_selectSet.Clear();
            //_selectAdapter.Fill(_selectSet);



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
                    System.Data.DataTable table = (System.Data.DataTable)projectsFin_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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
            var selectedRowIndex = -1;
            if (projectsFin_dataGridView.SelectedRows.Count > 0 &&
                projectsFin_dataGridView.SelectedRows[0].Index < projectsFin_dataGridView.Rows.Count - 1)
            {
                selectedRowIndex = projectsFin_dataGridView.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактирование записи",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedRowIndex = projectsFin_dataGridView.SelectedRows[0].Index;
            DataGridViewRow gridRow = projectsFin_dataGridView.Rows[selectedRowIndex];
            System.Data.DataTable table = (System.Data.DataTable)projectsFin_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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

            int id = Convert.ToInt32(dataRow["FinanceID"]);

            EditProjFin editProjFin = new EditProjFin(id,
                                                        _projFinSet, _projFinAdapter,
                                                        _projSet, _projAdapter);
            editProjFin.Show();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            (projectsFin_dataGridView.DataSource as System.Data.DataTable).DefaultView.RowFilter = $"Проект like '%{Search_textBox.Text}%'";
        }

        public void ExportToExcel(DataGridView grid)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            XlReferenceStyle RefStyle = Excel.ReferenceStyle;
            Excel.Visible = true;
            Workbook wb = null;
            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"Экспорт данных.xls";
            try
            {
                wb = Excel.Workbooks.Add(Type.Missing);//Add(TemplatePath); // !!! 
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            Worksheet ws = wb.Worksheets.get_Item(1) as Worksheet;
            for (int j = 2; j < grid.Columns.Count; ++j)
            {
                (ws.Cells[1, j - 1] as Microsoft.Office.Interop.Excel.Range).Value2 = grid.Columns[j].HeaderText;
                for (int i = 0; i < grid.Rows.Count; ++i)
                {
                    object Val = grid.Rows[i].Cells[j].Value;
                    if (Val != null)
                        (ws.Cells[i + 2, j - 1] as Microsoft.Office.Interop.Excel.Range).Value2 = Val.ToString();
                }
            }
            ws.Columns.EntireColumn.AutoFit();
            Excel.ReferenceStyle = RefStyle;
            ReleaseExcel(Excel as Object);
        }

        private void ReleaseExcel(object excel)
        {
            // Уничтожение объекта Excel.
            Marshal.ReleaseComObject(excel);
            // Вызываем сборщик мусора для немедленной очистки памяти
            GC.GetTotalMemory(true);
        }

        private void Export_button_Click(object sender, EventArgs e)
        {
            ExportToExcel(projectsFin_dataGridView);




        }

    }
    
    
}
