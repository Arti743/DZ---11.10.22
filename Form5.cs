using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PR3
{
    public partial class FormAdmin : Form
    {
        DataSet data;
        SqlDataAdapter adapter;
        //Подключение к SQL Server'у 
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=PR3; Integrated Security=True";
        string sql = "SELECT * FROM Administrators";

        public FormAdmin()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR3DataSet.Administrators". При необходимости она может быть перемещена или удалена.
            this.administratorsTableAdapter.Fill(this.pR3DataSet.Administrators);

        }
    }
}
