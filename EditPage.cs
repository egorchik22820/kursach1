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
        private DataSet _typeSet = new DataSet();
        private SqlDataAdapter _userAdapter;
        private SqlDataAdapter _typeAdapter;
        private int _itemID;
        private List<UsersTypes> _usersTypesList = new List<UsersTypes>();
        public EditPage()
        {
            InitializeComponent();
        }

        public EditPage(int itemID, DataSet userSet, SqlDataAdapter userAdapter)
        {
            InitializeComponent();

            _itemID = itemID;
            _userSet = userSet;
            _userAdapter = userAdapter;

            var row1 = _userSet.Tables[0].Rows[_itemID];
            var row2 = _userSet.Tables[0].Rows[_itemID];
            Login_textBox.Text = row1["UserName"].ToString();
            Password_textBox.Text = row2["UserPassword"].ToString();

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

                UserType_comboBox.DataSource = _usersTypesList;
            }
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userAdapter);
            _userAdapter.Update(_userSet.Tables[0]);

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_userAdapter);
            if (!string.IsNullOrEmpty(Login_textBox.Text) && !string.IsNullOrWhiteSpace(Login_textBox.Text) &&
                !string.IsNullOrEmpty(Password_textBox.Text) && !string.IsNullOrWhiteSpace(Password_textBox.Text))
            {
                var row = _userSet.Tables[0].Rows[_itemID];
                row["Username"] = Login_textBox.Text;
                row["UserPassword"] = Password_textBox.Text;
                row["TypeID"] = UserType_comboBox.SelectedIndex + 1;

                SaveData();

                Close();

            }
        }
    }
}
