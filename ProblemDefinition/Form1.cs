using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProblemDefinition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        TextBox txtMin;
        TextBox txtMax;
        Label lblIndis;

        OleDbConnection connection;
        string filePath;
        int row, col;
        public static double[] lowerBand;
        public static double[] upperBand;

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            // frm.Close();
            //Close();
            Hide();



        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            filePath = file.FileName;

            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            if (connection.DataSource == "")
                MessageBox.Show("Lütfen bir excel dosyası seçiniz.");
            else
            {
                connection.Open();

                OleDbDataAdapter da = new OleDbDataAdapter("select * from [Sayfa1$]", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                connection.Close();


                txtFilePath.Text = filePath;
                row = dt.Rows.Count;
                col = dt.Columns.Count;
                lowerBand = new double[row];
                upperBand = new double[row];
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (i == 0)
                            lowerBand[j] = Convert.ToDouble(dt.Rows[j][i]);
                        else if (i == 1)
                            upperBand[j] = Convert.ToDouble(dt.Rows[j][i]);
                        else
                            break;
                    }
                }

                Problem.low = lowerBand;
                Problem.high = upperBand;
                Problem.filePath = filePath;

                int a = 50, b = 100, c = 0, d = 65;
                for (int i = 0; i < row; i++)
                {
                    if (i == 0)
                    {
                        Label lblmax = new Label();
                        Label lblMin = new Label();

                        lblmax.Width = 75;
                        lblmax.Height = 30;
                        lblmax.Text = "Lowerband";
                        lblmax.Location = new System.Drawing.Point(a + 100, d);

                        lblMin.Width = 75;
                        lblMin.Height = 30;
                        lblMin.Text = "Upperband";
                        lblMin.Location = new System.Drawing.Point(a, d);

                        this.Controls.Add(lblmax);
                        this.Controls.Add(lblMin);
                    }
                    lblIndis = new Label();
                    lblIndis.Width = 50;
                    lblIndis.Height = 30;
                    lblIndis.Text = (i + 1) + ". değer";
                    lblIndis.Location = new System.Drawing.Point(c, b);
                    this.Controls.Add(lblIndis);

                    txtMin = new TextBox();
                    txtMin.Name = "txtMin" + i;
                    txtMin.Width = 75;
                    txtMin.Height = 20;
                    txtMin.Location = new System.Drawing.Point(a, b);
                    txtMin.Text = lowerBand[i].ToString();
                    this.Controls.Add(txtMin);

                    txtMax = new TextBox();
                    txtMax.Name = "txtMax" + i;
                    txtMax.Width = 75;
                    txtMax.Height = 20;
                    txtMax.Location = new System.Drawing.Point(a + 100, b);
                    txtMax.Text = upperBand[i].ToString();
                    this.Controls.Add(txtMax);

                    b += 30;

                }
            }
        }
    }
}
