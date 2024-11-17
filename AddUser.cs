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
        private DataSet _employeesSet = new DataSet();
        private DataSet _userSet = new DataSet();
        private DataSet _userTypeSet = new DataSet();

        private SqlDataAdapter _employeesadapter;
        private SqlDataAdapter _useradapter;
        private SqlDataAdapter _userTypeadapter;

        private List<UsersTypes> _usersTypesList = new List<UsersTypes>();

        public AddUser()
        {
            InitializeComponent();

            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {

                string selectUsers = "select * from [kursach].[dbo].[progUsers];";
                string selectTypes = "select * from TypesOfUsers;";
                string selectEmployees = "select * from Employees;";

                _employeesadapter = new SqlDataAdapter(selectEmployees, sqlConnection);
                _useradapter = new SqlDataAdapter(selectUsers, sqlConnection);
                _userTypeadapter = new SqlDataAdapter(selectTypes, sqlConnection);

                _employeesadapter.Fill(_employeesSet);
                _useradapter.Fill(_userSet);
                _userTypeadapter.Fill(_userTypeSet);


                foreach (DataRow typeRow in _userTypeSet.Tables[0].Rows)
                {
                    _usersTypesList.Add(new UsersTypes(typeRow["TypeName"].ToString(),
                        Convert.ToInt32(typeRow["TypeID"])));
                }

                UserType_ComboBox.DataSource = _usersTypesList;
            }
            else MessageBox.Show("connection is shit");
        }

        private void AddUser_Activated(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Open)
            //{
            //    DataSet _employeesSet = new DataSet();
            //    DataSet _userSet = new DataSet();
            //    DataSet _userTypeSet = new DataSet();

            //    string selectUsers = "select * from [kursach].[dbo].[progUsers];";
            //    string selectTypes = "select * from TypesOfUsers;";
            //    string selectEmployees = "select * from Employees;";

            //    _employeesadapter = new SqlDataAdapter(selectEmployees, sqlConnection);
            //    _useradapter = new SqlDataAdapter(selectUsers, sqlConnection);
            //    _userTypeadapter = new SqlDataAdapter(selectTypes, sqlConnection);

            //    _employeesadapter.Fill(_employeesSet);
            //    _useradapter.Fill(_userSet);
            //    _userTypeadapter.Fill(_userTypeSet);


            //    foreach (DataRow typeRow in _userTypeSet.Tables[0].Rows)
            //    {
            //        _usersTypesList.Add(new UsersTypes(typeRow["TypeName"].ToString(),
            //            Convert.ToInt32(typeRow["TypeID"])));
            //    }

            //    UserType_ComboBox.DataSource = _usersTypesList;
            //}


        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_userTypeadapter);
            _userTypeadapter.Update(_userTypeSet);

            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_useradapter);
            _useradapter.Update(_userSet);

            SqlCommandBuilder sqlCommandBuilder3 = new SqlCommandBuilder(_employeesadapter);
            _employeesadapter.Update(_employeesSet);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow newRow1 = _userSet.Tables[0].NewRow();
            DataRow newRow2 = _employeesSet.Tables[0].NewRow();


            newRow1["UserName"] = Login_textBox.Text.ToString();
            newRow1["UserPassword"] = Password_textBox.Text.ToString();
            newRow1["TypeID"] = UserType_ComboBox.SelectedIndex + 1;

            newRow2["FirstName"] = Name_textBox.Text.ToString();
            newRow2["LastName"] = LastName_textBox.Text.ToString();
            newRow2["Position"] = Position_textBox.Text.ToString();
            newRow2["UserID"] = (Convert.ToInt32(_userSet.Tables[0].Rows[_userSet.Tables[0].Rows.Count - 1]["UserID"]) + 1).ToString();
            newRow2["TeamID"] = 4.ToString();
            newRow2["PhoneNumber"] = Phone_textBox.Text.ToString();
            

            if (!string.IsNullOrEmpty(Login_textBox.Text) && !string.IsNullOrEmpty(Password_textBox.Text) &&
                !string.IsNullOrEmpty(Name_textBox.Text) && !string.IsNullOrEmpty(LastName_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Login_textBox.Text) && !string.IsNullOrWhiteSpace(Password_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Name_textBox.Text) && !string.IsNullOrWhiteSpace(LastName_textBox.Text))
            {
                _userSet.Tables[0].Rows.Add(newRow1);
                SaveData();
                _employeesSet.Tables[0].Rows.Add(newRow2);
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
