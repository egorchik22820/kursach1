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
    public partial class AdminPanel : Form
    {
        private DataSet _userSet = new DataSet();
        private DataSet _deleteUserSet = new DataSet();
        private SqlDataAdapter _userAdapter;
        private SqlDataAdapter _deleteUserAdapter;
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
                string selectUsers = "SELECT u.userName, t.TypeName \r\nFROM [kursach].[dbo].[progUsers] AS u \r\nINNER JOIN TypesOfUsers AS t ON u.TypeID = t.TypeID;";
                _userAdapter = new SqlDataAdapter(selectUsers, sqlConnection);
                _userAdapter.Fill(_userSet);

                

                //для DataGrid ставлю MultiSelect на false, чтобы пользователь не мог выделять сразу несколько строк
                users_dataGridView.MultiSelect = false;
                users_dataGridView.DataSource = _userSet.Tables[0];
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
                    users_dataGridView.Rows.RemoveAt(selectedRowIndex);
                }


                SaveData();
            }
            else MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userAdapter);
            _userAdapter.Update(_userSet);
        }

        private void DeleteData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_deleteUserAdapter);
            _deleteUserAdapter.Update(_deleteUserSet);
        }
    }
}
