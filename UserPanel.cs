using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class UserPanel : Form
    {
        private DataSet _emloyeeSet = new DataSet();
        private SqlDataAdapter _emloyeeAdapter;

        private DataSet _selectSet = new DataSet();
        private SqlDataAdapter _selectAdapter;

        private DataSet _set1 = new DataSet();
        private DataSet _set2 = new DataSet();
        private DataSet _set3 = new DataSet();
        private DataSet _set4 = new DataSet();
        private DataSet _set5 = new DataSet();
        private DataSet _set6 = new DataSet();

        private SqlDataAdapter _adapter1;
        private SqlDataAdapter _adapter2;
        private SqlDataAdapter _adapter3;
        private SqlDataAdapter _adapter4;
        private SqlDataAdapter _adapter5;
        private SqlDataAdapter _adapter6;

        private int _userID;
        public UserPanel(int userID)
        {
            _userID = userID;
            InitializeComponent();
        }

        private void UserPanel_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                _set1 = new DataSet();
                _set2 = new DataSet();
                _set3 = new DataSet();
                _set4 = new DataSet();
                _set5 = new DataSet();
                _set6 = new DataSet();

                string select1 = "select * from Employees;";
                string select2 = "select * from progUsers;";
                string select3 = "select * from EmployeeTasks;";
                string select4 = "select * from Tasks;";
                string select5 = "select * from Projects;";
                string select6 = "select * from Teams;";

                _adapter1 = new SqlDataAdapter(select1, sqlConnection);
                _adapter1.Fill(_set1);
                _adapter2 = new SqlDataAdapter(select2, sqlConnection);
                _adapter2.Fill(_set2);
                _adapter3 = new SqlDataAdapter(select3, sqlConnection);
                _adapter3.Fill(_set3);
                _adapter4 = new SqlDataAdapter(select4, sqlConnection);
                _adapter4.Fill(_set4);
                _adapter5 = new SqlDataAdapter(select5, sqlConnection);
                _adapter5.Fill(_set5);
                _adapter6 = new SqlDataAdapter(select6, sqlConnection);
                _adapter6.Fill(_set6);

                _adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _adapter2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _adapter3.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _adapter4.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _adapter5.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _adapter6.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _emloyeeSet = new DataSet();
                string selectInfoEmployee = $"select E.FirstName + ' ' + E.LastName as 'ФИО', E.Position as 'Должность', E.PhoneNumber as 'Телефон' from Employees as E\r\nwhere E.UserID = {_userID};";
                string selectInfoUser = $"select U.UserName as 'Логин', U.UserPassword as 'Пароль', T.TypeName as 'Права' from progUsers as U\r\njoin TypesOfUsers as T on U.TypeID = T.TypeID\r\nwhere U.UserID = {_userID};";
                string selectInfoProj = $"select P.ProjectName as 'Проект', T.TaskDescription as 'Описание задачи', T.Status as 'Статус', ET.HoursWorked as 'Отработано часов', P.EndDate as 'Дедлайн' from EmployeeTasks as ET\r\njoin Tasks as T on ET.TaskID = T.TaskID\r\njoin Projects as P on T.ProjectID = P.ProjectID\r\njoin Employees as E on E.EmployeeID = ET.EmployeeID\r\nwhere E.UserID = {_userID};";
                string selectInfoTeams = $"--infoTeams\r\nselect T.TeamName as 'Бригада', E.FirstName + ' ' + E.LastName as 'Супервайзер', E.PhoneNumber as 'Телефон' from Teams as T\r\njoin Employees as E on T.SupervisorID = E.EmployeeID\r\nwhere E.UserID = {_userID};";
                _selectAdapter = new SqlDataAdapter(selectInfoEmployee + selectInfoUser + selectInfoProj + selectInfoTeams, sqlConnection);
                _selectAdapter.Fill(_emloyeeSet);

                ///для DataGrid ставлю MultiSelect на false, чтобы пользователь не мог выделять сразу несколько строк
                infoEmployee_dataGridView.MultiSelect = false;
                infoEmployee_dataGridView.DataSource = _emloyeeSet.Tables[0];

                infoEmployee_dataGridView.MultiSelect = false;
                infoUser_dataGridView.DataSource = _emloyeeSet.Tables[1];

                infoProj_dataGridView.MultiSelect = false;
                infoProj_dataGridView.DataSource = _emloyeeSet.Tables[2];

                infoTeams_dataGridView.MultiSelect = false;
                infoTeams_dataGridView.DataSource = _emloyeeSet.Tables[3];

                //var row1 = _set1.Tables[0].Rows["UserID"];

                //Name_textBox.Text = row1["ФИО"].ToString();

            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {

        }
    }
}
