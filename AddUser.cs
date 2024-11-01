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
    public partial class AddUser : Form
    {
        private DataSet _userSet = new DataSet();
        private DataSet _typeSet = new DataSet();
        private SqlDataAdapter _userAdapter;
        private SqlDataAdapter _typeAdapter;
        private List<UsersTypes> _usersTypesList = new List<UsersTypes>();

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectUsers = "select * from progUsers;";
                string selectTypes = "select * from TypesOfUsers;";

                _typeAdapter = new SqlDataAdapter(selectTypes, sqlConnection);
                _userAdapter = new SqlDataAdapter(selectUsers, sqlConnection);

                _typeAdapter.Fill(_typeSet);
                _userAdapter.Fill(_userSet);

                foreach (DataRow typeRow in _typeSet.Tables[0].Rows)
                {
                    _usersTypesList.Add(new UsersTypes(typeRow["TypeName"].ToString(),
                        Convert.ToInt32(typeRow["TypeID"])));
                }

                UserType_ComboBox.DataSource = _usersTypesList;
            }


        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userAdapter);
            _userAdapter.Update(_userSet);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = _userSet.Tables[0].NewRow();


            newRow["UserName"] = Name_textBox.Text.ToString();
            newRow["UserPassword"] = Password_textBox.Text.ToString();
            newRow["TypeID"] = UserType_ComboBox.SelectedIndex + 1;

            if (!string.IsNullOrEmpty(Name_textBox.Text) &&
                !string.IsNullOrEmpty(Password_textBox.Text))
            {
                _userSet.Tables[0].Rows.Add(newRow);
                SaveData();
                MessageBox.Show("Пользователь добавлен!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }




        }
    }
}
