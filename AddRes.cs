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
    public partial class AddRes : Form
    {
        private DataSet _resSet;
        private SqlDataAdapter _resAdapter;
        public AddRes()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(_resAdapter);
            _resAdapter.Update(_resSet);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            DataRow newRow = _resSet.Tables[0].NewRow();

            

            if (!string.IsNullOrEmpty(Name_textBox.Text) && !string.IsNullOrEmpty(Unit_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Name_textBox.Text) && !string.IsNullOrWhiteSpace(Unit_textBox.Text) &&
                !string.IsNullOrEmpty(Cost_textBox.Text) && !string.IsNullOrWhiteSpace(Cost_textBox.Text))
            {

                newRow["ResourceName"] = Name_textBox.Text.ToString();
                newRow["Unit"] = Unit_textBox.Text.ToString();
                newRow["CostPerUnit"] = Cost_textBox.Text.ToString();

                _resSet.Tables[0].Rows.Add(newRow);
                SaveData();
                MessageBox.Show("Пополнение завершено!");
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void AddRes_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EGOR\SQLEXPRESS;Initial Catalog=kursach;Integrated Security=True;Encrypt=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                string selectRes = "select * from Resources;";


                _resSet = new DataSet();
                _resAdapter = new SqlDataAdapter(selectRes, sqlConnection);
                _resAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _resAdapter.Fill(_resSet);

                Res_dataGridView.MultiSelect = false;
                Res_dataGridView.DataSource = _resSet.Tables[0];
                Res_dataGridView.Columns["ResourceID"].Visible = false;
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Res_dataGridView.SelectedRows.Count > 0 && Res_dataGridView.SelectedRows[0].Index < Res_dataGridView.RowCount - 1)
            {

                var selectedRowIndex = Res_dataGridView.SelectedRows[0].Index;

                // Показать диалоговое окно подтверждения
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Удаление выбранной строки
                    Res_dataGridView.Rows.RemoveAt(selectedRowIndex);

                }

                SaveData();

            }
            else
            {
                // Если строка не выбрана, показать сообщение
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            (Res_dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ResourceName like '%{Search_textBox.Text}%'";
        }
    }
}
