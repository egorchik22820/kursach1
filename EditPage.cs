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
    public partial class EditPage : Form
    {
        private DataSet _userSet;
        private DataSet _employeeSet;
        private DataSet _selectSet;

        private DataSet _typeSet = new DataSet();

        private SqlDataAdapter _userAdapter;
        private SqlDataAdapter _employeeAdapter;
        private SqlDataAdapter _selectAdapter;

        private SqlDataAdapter _typeAdapter;

        private int _itemID;
        private int _itemIDforUsers;
        private List<UsersTypes> _usersTypesList = new List<UsersTypes>();
        public EditPage()
        {
            InitializeComponent();
        }

        public EditPage(int itemID, int itemIDforUsers,
                        DataSet userSet, DataSet employeeSet, DataSet selectSet,
                        SqlDataAdapter userAdapter, SqlDataAdapter employeeAdapter, SqlDataAdapter selectAdapter)
        {
            InitializeComponent();

            _itemID = itemID;
            _itemIDforUsers = itemIDforUsers;

            _userSet = userSet;
            _employeeSet = employeeSet;
            _selectSet = selectSet;

            _userAdapter = userAdapter;
            _employeeAdapter = employeeAdapter;
            _selectAdapter = selectAdapter;

            var row1 = _userSet.Tables[0].Rows.Find(_itemIDforUsers);// хард код с индексами, пошли они нахуй, потом переделаю
            var row2 = _userSet.Tables[0].Rows.Find(_itemIDforUsers);

            var row3 = _employeeSet.Tables[0].Rows.Find(_itemID);

            Login_textBox.Text = row1["UserName"].ToString();
            Password_textBox.Text = row2["UserPassword"].ToString();

            Name_textBox.Text = row3["FirstName"].ToString();
            LastName_textBox.Text = row3["LastName"].ToString();
            Position_textBox.Text = row3["Position"].ToString();
            Telephone_textBox.Text = row3["PhoneNumber"].ToString();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectUsers = "select * from progUsers;";
                string selectTypes = "select * from TypesOfUsers;";
                string selectEmployees = "select * from Employees;";

                _typeAdapter = new SqlDataAdapter(selectTypes, sqlConnection);
                _userAdapter = new SqlDataAdapter(selectUsers, sqlConnection);
                _employeeAdapter = new SqlDataAdapter(selectEmployees, sqlConnection);

                _typeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _userAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _employeeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _typeAdapter.Fill(_typeSet);
                _userAdapter.Fill(_userSet);
                _employeeAdapter.Fill(_employeeSet);

                foreach (DataRow typeRow in _typeSet.Tables[0].Rows)
                {
                    _usersTypesList.Add(new UsersTypes(typeRow["TypeName"].ToString(),
                        Convert.ToInt32(typeRow["TypeID"])));
                }

                UserType_comboBox.DataSource = _usersTypesList;
            }
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_userAdapter);
            _userAdapter.Update(_userSet.Tables[0]);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_employeeAdapter);
            _employeeAdapter.Update(_employeeSet.Tables[0]);

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userAdapter);
            if (!string.IsNullOrEmpty(Login_textBox.Text) && !string.IsNullOrEmpty(Password_textBox.Text) &&
                !string.IsNullOrEmpty(Name_textBox.Text) && !string.IsNullOrEmpty(LastName_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Login_textBox.Text) && !string.IsNullOrWhiteSpace(Password_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Name_textBox.Text) && !string.IsNullOrWhiteSpace(LastName_textBox.Text))
            {
                var row1 = _userSet.Tables[0].Rows.Find(_itemIDforUsers);// хард код с индексами, пошли они нахуй, потом переделаю
                var row3 = _typeSet.Tables[0].Rows.Find(_itemIDforUsers);
                row1["Username"] = Login_textBox.Text;
                row1["UserPassword"] = Password_textBox.Text;
                row1["TypeID"] = (UserType_comboBox.SelectedItem as UsersTypes).TypeID.ToString();

                SaveData();

                var row2 = _employeeSet.Tables[0].Rows.Find(_itemID);
                row2["FirstName"] = Name_textBox.Text;
                row2["LastName"] = LastName_textBox.Text;
                row2["Position"] = Position_textBox.Text;
                row2["PhoneNumber"] = Telephone_textBox.Text;

                SaveData();

                Close();

            }
        }
    }
}
