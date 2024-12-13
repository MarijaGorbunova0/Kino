using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form3 : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KinoDatabase;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        Form1 login;
        public Form3()
        {
            InitializeComponent();
        }
        private void LoginControl()
        {
            try

            {
                using (conn)
                {
                    conn.Open();
                    string GetUsernimi = LoginKasutajanimi_lbl.Text;
                    string GetUserparool = Loginsalasona_lbl.Text;

                    string query = "SELECT parool FROM Konto WHERE kasutajanimi = @GetUsernimi";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GetUsernimi", GetUsernimi);

                        var storedPassword = cmd.ExecuteScalar();

                        if (GetUsernimi == "admin" && storedPassword.ToString() == GetUserparool)
                        {
                            MessageBox.Show("Edukalt");
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                        else if(storedPassword != null && storedPassword.ToString() == GetUserparool)
                        {
                            MessageBox.Show("Edukalt kasutaja");
                            Form4 form4 = new Form4();
                            form4.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vale kasutajanimi või salasõna");
                        }

                           
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga" + ex.Message);
            }
        }

        private void LogiSisse_btn_Click(object sender, EventArgs e)
        {
            LoginControl();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
