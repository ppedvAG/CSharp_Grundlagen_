using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Extention_ADONET_Sample
{
    public partial class Form1 : Form
    {

        private string connectionString = "Data Source=SURFACE-KW4;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SURFACE-KW4;Initial Catalog=AdventureWorks2017;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DataTable resultTable = new DataTable("Products");

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                string sqlStatement = "Select TOP (1000) * FROM [AdventureWorks2017].[Production].[Product]";
                
                
                //Schnellere Variante ist mit einem SQLDataReader = sequenzielles Lesen (ohne Metadaten)
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;

                resultTable.WriteXml("Product1.xml");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }

            #region XMLSerializer
            XmlSerializer ser = new XmlSerializer(typeof(DataTable));

            TextWriter writer = new StreamWriter("Product2.xml");
            ser.Serialize(writer, resultTable);
            writer.Close();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable resultTable = new DataTable("Products");

            string path = @"C:\Meine Kurse\CSharp_Grundlagenkurs_2020_03_03\CSharp_Grundlagen_03032020\CSharp_Grundlagen_03_03_2020\Extention_ADONET_Sample\bin\Debug\Product2.xml";
            resultTable.ReadXml(path);

            dataGridView1.DataSource = resultTable;
        }
    }
}
