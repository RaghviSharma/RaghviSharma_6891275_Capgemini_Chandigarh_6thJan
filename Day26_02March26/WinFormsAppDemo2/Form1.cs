using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsAppDemo2
{
	public partial class Form1 : Form
	{
		// ✅ Correct Connection String
		SqlConnection con = new SqlConnection(
			"Data Source=RAGHVISHARMA\\SQLEXPRESS;" +
			"Initial Catalog=RaghviShDB;" +
			"Integrated Security=True;" +
			"TrustServerCertificate=True;");

		public Form1()
		{
			InitializeComponent();

			// ✅ Ensure Load event runs
			this.Load += Form1_Load;
		}

		// ✅ LOAD DATA INTO GRIDVIEW
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				con.Open();

				string query = "SELECT * FROM Employeetb";

				SqlDataAdapter da = new SqlDataAdapter(query, con);

				DataTable dt = new DataTable();

				da.Fill(dt);

				dataGridView1.DataSource = dt;

				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}