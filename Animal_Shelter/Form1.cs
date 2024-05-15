using Npgsql;
using System;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Animal_Shelter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void RunSqlCommand(string sqlCommand)
		{

			string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=Animal_Shelter";
			using var connection = new NpgsqlConnection(connectionString);
			try
			{
				NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlCommand, connection);
				DataSet dataSet = new DataSet();
				adapter.Fill(dataSet);

				if (dataSet.Tables.Count > 0)
				{
					dataGridView1.DataSource = dataSet.Tables[0];
				}
				else
				{
					MessageBox.Show(" hata oluþtu.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("hata oluþtu: " + ex.Message);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Database Baðlantýlarý
			string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=Animal_Shelter";

			using var connection = new NpgsqlConnection(connectionString);

			//Zatenm açýk mý kontrolð koy
			connection.Open();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			//Hayvanlarý getirme butonu
			RunSqlCommand("SELECT * FROM Animals");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Bütün Çalýþanlarý getiren 
			RunSqlCommand("SELECT * FROM Employees");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Saðlýk Kayýtlarý Getiren
			RunSqlCommand("Select * from medicalrecords;");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			// Sahiplendirilen Hayvanlarý Getir
			RunSqlCommand("Select aa.name , adp.firstname from adoptions ad, adopters adp, animals aa Where aa.animalid = ad.animalid and adp.adopterid = ad.adopterid Order by ad.adoptiondate;\r\n");
		}
	}
}