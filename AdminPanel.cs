﻿using Microsoft.Data.SqlClient;
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
    public partial class AdminPanel : Form
    {
        private DataSet _userSet = new DataSet();
        private DataSet _employeeSet = new DataSet();
        private DataSet _selectSet = new DataSet();

        private SqlDataAdapter _userAdapter;
        private SqlDataAdapter _employeeAdapter;
        private SqlDataAdapter _selectAdapter;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void AdminPanel_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                _userSet = new DataSet();
                _employeeSet = new DataSet();
                _selectSet = new DataSet();
                string selectEmployees = "select E.FirstName + ' ' + E.LastName as 'ФИО', E.Position as 'Должность', U.UserName as 'Логин', T.TypeName as 'Права', E.PhoneNumber as 'Телефон', E.UserID, E.EmployeeID from Employees as E\r\njoin progUsers as U on U.UserID = E.UserID\r\njoin TypesOfUsers as T on T.TypeID = U.TypeID;";
                string select1 = "select * from progUsers;";
                string select2 = "select * from Employees;";
                _userAdapter = new SqlDataAdapter(select1, sqlConnection);
                _employeeAdapter = new SqlDataAdapter(select2, sqlConnection);
                _selectAdapter = new SqlDataAdapter(selectEmployees, sqlConnection);

                _userAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _employeeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _selectAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _userAdapter.Fill(_userSet);
                _employeeAdapter.Fill(_employeeSet);
                _selectAdapter.Fill(_selectSet);



                //для DataGrid ставлю MultiSelect на false, чтобы пользователь не мог выделять сразу несколько строк
                users_dataGridView.MultiSelect = false;
                users_dataGridView.DataSource = _selectSet.Tables[0];
                users_dataGridView.Columns["UserID"].Visible = false;
                users_dataGridView.Columns["EmployeeID"].Visible = false;

            }

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (users_dataGridView.SelectedRows.Count > 0 &&
                users_dataGridView.SelectedRows[0].Index < users_dataGridView.RowCount - 1)
            {
                var selectedRowIndex = users_dataGridView.SelectedRows[0].Index;

                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    DataGridViewRow gridRow = users_dataGridView.Rows[selectedRowIndex];
                    DataTable table = (DataTable)users_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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


                    DataRow row = _employeeSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["EmployeeID"]));

                    users_dataGridView.Rows.RemoveAt(selectedRowIndex);

                    users_dataGridView.DataSource = _employeeSet.Tables[0];

                    int idForProgUsers = Convert.ToInt32(dataRow["UserID"]);

                    users_dataGridView.Rows.RemoveAt(_employeeSet.Tables[0].Rows.IndexOf(row));
                    SaveData();


                    DataRow rowU = _userSet.Tables[0].Rows.Find(idForProgUsers);

                    users_dataGridView.DataSource = _userSet.Tables[0];
                    users_dataGridView.Rows.RemoveAt(_userSet.Tables[0].Rows.IndexOf(rowU));

                }


                SaveData();
                users_dataGridView.DataSource = _selectSet.Tables[0];
            }
            else MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_employeeAdapter);
            _employeeAdapter.Update(_employeeSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_userAdapter);
            _userAdapter.Update(_userSet);
        }


        private void Edit_button_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = -1;
            if (users_dataGridView.SelectedRows.Count > 0 &&
                users_dataGridView.SelectedRows[0].Index < users_dataGridView.Rows.Count - 1)
            {
                selectedRowIndex = users_dataGridView.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Редактирование записи",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow gridRow = users_dataGridView.Rows[selectedRowIndex];
            DataTable table = (DataTable)users_dataGridView.DataSource; // Получаем DataTable, привязанный к DataGridView
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


            DataRow row = _employeeSet.Tables[0].Rows.Find(Convert.ToInt32(dataRow["EmployeeID"]));

            int idEmp = Convert.ToInt32(dataRow["EmployeeID"]);
            int idUser = Convert.ToInt32(dataRow["UserID"]);


            EditPage editPage = new EditPage(idEmp, idUser, _userSet, _employeeSet, _selectSet, _userAdapter, _employeeAdapter, _selectAdapter);
            editPage.ShowDialog();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            (users_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО like '%{Search_textBox.Text}%'";
        }

        private void openProj_button_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            this.Hide();
            projects.ShowDialog();
            this.Show();
        }

        private void openProjRes_button_Click(object sender, EventArgs e)
        {
            ProjResources res = new ProjResources();
            this.Hide();
            res.ShowDialog();
            this.Show();
        }

        private void openProjFinbutton_Click(object sender, EventArgs e)
        {
            ProjFin projFin = new ProjFin();
            this.Hide(); projFin.ShowDialog(); this.Show();
        }
    }
}
