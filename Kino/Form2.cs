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
using System.IO;
namespace Kino
{
    public partial class Form2 : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KinoDatabase;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        private string selectedNimi;
        public Form2()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_Click;
            NaitaAndmed();
        }

        public void NaitaAndmed()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT * FROM film", conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("andmete viga " + ex.Message);
            }

        }

        private void LisaFilm_btn_Click(object sender, EventArgs e)
        {
            if (FilmiNimi_txb.Text.Trim() != string.Empty && Aasta_txb.Text.Trim() != string.Empty)
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {

                            byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KinoDatabase;"))
                            {
                                conn.Open();

                                using (SqlCommand cmd = new SqlCommand("INSERT INTO film (nimi, poster, aasta) VALUES (@nimi, @poster, @aasta)", conn))
                                {
                                    cmd.Parameters.AddWithValue("@nimi", FilmiNimi_txb.Text); 
                                    cmd.Parameters.AddWithValue("@poster", imageBytes);  
                                    cmd.Parameters.AddWithValue("@aasta", DateTime.Parse(Aasta_txb.Text));  

                                    cmd.ExecuteNonQuery();
                                }

                            }
                            NaitaAndmed();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kõik väljad tuleb täita");
            }
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedNimi = selectedRow.Cells["nimi"].Value?.ToString(); 
                FilmiNimi_txb.Text = selectedRow.Cells["nimi"].Value?.ToString();
                Aasta_txb.Text = selectedRow.Cells["aasta"].Value.ToString();

                pictureBox1.Size = new Size(215, 163);
                if (selectedRow.Cells["poster"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells["poster"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                        pictureBox1.Image = new Bitmap(image, new Size(215, 163));
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void KustutaFilm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if (ID != 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM film WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    if (dataGridView1.SelectedRows[0].Cells["poster"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])dataGridView1.SelectedRows[0].Cells["poster"].Value;
                        string imagePath = Path.Combine(@"C:\Path\To\ImageDirectory", $"{ID}.jpg");
                        if (File.Exists(imagePath))
                        {
                            File.Delete(imagePath);
                        }
                    }

                    NaitaAndmed();
                    MessageBox.Show("kustutatud edukalt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("viga" + ex.Message);
            }
        }

        private void UuendaFilm_btn_Click(object sender, EventArgs e)
        {
            if (FilmiNimi_txb.Text.Trim() != string.Empty && Aasta_txb.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE film SET nimi = @nimi, aasta = @aasta WHERE nimi = @nimi", conn);
                    cmd.Parameters.AddWithValue("@nimi", FilmiNimi_txb.Text);
                    cmd.Parameters.AddWithValue("@aasta", Aasta_txb.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                    MessageBox.Show("Andmete värskendamine õnnestus");
                    FilmiNimi_txb.Text = "";
                    Aasta_txb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("täitke kõik väljad");
            }
        }
    }
}