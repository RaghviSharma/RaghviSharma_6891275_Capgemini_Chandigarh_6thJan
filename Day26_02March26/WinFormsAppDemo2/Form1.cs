using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsAppDemo2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            "Data Source=RAGHVISHARMA\\SQLEXPRESS;Initial Catalog=RaghviShDB;Integrated Security=True");

        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;
        DataRow rec;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== FORM LOAD =====
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Employeetb", con);

                ds = new DataSet();

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                da.Fill(ds, "Employeetb");

                dataGridView1.DataSource = ds.Tables["Employeetb"];

                builder = new SqlCommandBuilder(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== INSERT =====
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].NewRow();

                rec[0] = IDtb.Text;
                rec[1] = nameTB.Text;
                rec[2] = designTB.Text;
                rec[3] = dojTB.Text;
                rec[4] = salaryTB.Text;
                rec[5] = deptnoTB.Text;

                ds.Tables[0].Rows.Add(rec);

                MessageBox.Show("Inserted into Dataset");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== FIND =====
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId=" + IDtb.Text)[0];

                nameTB.Text = rec[1].ToString();
                designTB.Text = rec[2].ToString();
                dojTB.Text = rec[3].ToString();
                salaryTB.Text = rec[4].ToString();
                deptnoTB.Text = rec[5].ToString();

                MessageBox.Show("Record Found");
            }
            catch
            {
                MessageBox.Show("Record Not Found");
            }
        }

        // ===== UPDATE =====
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                rec[1] = nameTB.Text;
                rec[2] = designTB.Text;
                rec[3] = dojTB.Text;
                rec[4] = salaryTB.Text;
                rec[5] = deptnoTB.Text;

                MessageBox.Show("Updated in Dataset");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== DELETE =====
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                rec = ds.Tables[0].Select("EmpId=" + IDtb.Text)[0];
                rec.Delete();

                MessageBox.Show("Deleted from Dataset");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== UPDATE DATABASE =====
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.HasChanges())
                {
                    da.Update(ds, "Employeetb");
                    MessageBox.Show("Database Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No Changes to Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== CLEAR =====
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        // ===== CLOSE =====
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }
    }
}