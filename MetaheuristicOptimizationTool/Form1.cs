using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ProblemDefinition;
using Cost;
using MetaheuristicOptimizationTool.GeneticAlgorithm;
using MetaheuristicOptimizationTool.SOS;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace MetaheuristicOptimizationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProblemDefinition.Form1 problem;
        DataTable table = new DataTable();
        DataRow row;
        double[] low;
        double[] high;
        int NumofExp, nd;
        Stopwatch sw = new Stopwatch();

        double average, ort = 0, ss = 0;
        double bf;
        int m = 0;

        private void btnProblem_Click(object sender, EventArgs e)
        {
            problem = new ProblemDefinition.Form1();
            problem.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtFilePath.Text = Problem.getFilePath() + "";

            if (txtFilePath.Text == "")
            {
                MessageBox.Show("Lütfen veri seti yükleyin!");
            }
            else
            {
                panel1.Enabled = true;
                btnOk.Enabled = false;

                low = Problem.lowerBand();
                high = Problem.upperBand();
                nd = low.Length;


            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            problem.Show();
        }

        private void btnCreateFunc_Click(object sender, EventArgs e)
        {
            grpProblem.BackColor = Color.Transparent;
            grpProblem.Enabled = false;
            grpCost.BackColor = Color.LightGreen;
            grpCost.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            grpProblem.Enabled = false;
            grpProblem.BackColor = Color.Transparent;

            grpAlgorithms.BackColor = Color.LightGreen;
            grpAlgorithms.Enabled = true;
        }

        private void btnFonkOlustur_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string filePath = file.FileName;

            textBox1.Text = filePath;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpProblem.Enabled = false;
            grpProblem.BackColor = Color.Transparent;
            grpCost.Enabled = false;
            grpCost.BackColor = Color.Transparent;

            grpAlgorithms.BackColor = Color.LightGreen;
            grpAlgorithms.Enabled = true;
        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            int j = 0, i = 0;

            //başlıkları yazdırıyoruz…
            for (j = 0; j < dgwFitnessInf.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgwFitnessInf.Columns[j].HeaderText;
            }

            StartRow++;

            //datagridview içeriğini yazdırıyoruz…
            for (i = 0; i < dgwFitnessInf.Rows.Count; i++)
            {
                for (j = 0; j < dgwFitnessInf.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dgwFitnessInf[j, i].Value == null ? "" : dgwFitnessInf[j, i].Value;
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            panel1.Enabled = false;
            grpProblem.BackColor = Color.LightGreen;
            grpCost.Enabled = false;
            grpAlgorithms.Enabled = false;

            cmbAlgorithms.Items.Add("Genetic Algorithm");
            cmbAlgorithms.Items.Add("SOS Algorithm");
            // cmbAlgorithms.Items.Add("BAT Algorithm");

            cmbFunction.Items.Add("Griewank");
            cmbFunction.Items.Add("Booth");
            cmbFunction.Items.Add("Matyas");
            cmbFunction.Items.Add("Beale");
            cmbFunction.Items.Add("Sphere");
            cmbFunction.Items.Add("Schaffer");
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbAlgorithms.Text == "" || cmbFunction.Text == "" || txtExperiments.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
            }
            else
            {
                table.Columns.Clear();
                table.Rows.Clear();
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label11.Text = "";



                table.Columns.Add("En iyi çözüm", typeof(double));
                for (int i = 0; i < nd; i++) { table.Columns.Add("Çözüm adayı " + (i + 1), typeof(double)); }
                table.Columns.Add("İşlem süresi", typeof(double));
                table.Columns.Add("Deney sayısı", typeof(int));
                table.Columns.Add("Min en iyi çözüm", typeof(double));
                table.Columns.Add("Max en iyi çözüm", typeof(double));
                table.Columns.Add("En iyi çözümlerin ortalaması", typeof(double));
                table.Columns.Add("Standart sapma", typeof(double));
                dgwFitnessInf.DataSource = table;

                NumofExp = int.Parse(txtExperiments.Text);
                sw.Start();
                switch (cmbAlgorithms.Text)
                {
                    case "Genetic Algorithm":

                        for (int i = 0; i < NumofExp; i++)
                        {
                            Genetic gen = new Genetic();
                            double globalMin = gen.geneticStart(cmbFunction.Text);
                            if (gen.getDeger() == -1)
                            { MessageBox.Show("Fonksiyonun parametre sayısı ile değişkenlerinizin sayısı uyuşmuyor!"); break; }
                            else
                            {
                                double[][] randPop = gen.getRandPop();
                                MinBul min = new TekMinBul(gen.getFitness());
                                int minindex = min.minBul();
                                sw.Stop();

                                row = table.NewRow();

                                row["En iyi çözüm"] = globalMin;
                                for (int h = 0; h < nd; h++) { row["Çözüm adayı " + (h + 1)] = randPop[minindex][h]; }
                                row["İşlem süresi"] = sw.ElapsedMilliseconds;

                                table.Rows.Add(row);
                                dgwFitnessInf.DataSource = table;
                            }

                        }
                        break;

                    case "SOS Algorithm":

                        for (int i = 0; i < NumofExp; i++)
                        {
                            Sos sos = new Sos();
                            double globalMin = sos.sosStart(cmbFunction.Text);

                            if (sos.getDeger() == -1)
                            {
                                MessageBox.Show("Fonksiyonun parametre sayısı ile değişkenlerinizin sayısı uyuşmuyor!"); break;
                            }
                            else
                            {

                                double[][] randPop = sos.getRandPop();
                                MinBul min = new TekMinBul(sos.getFitness());
                                int minindex = min.minBul();
                                sw.Stop();

                                row = table.NewRow();

                                row["En iyi çözüm"] = globalMin;
                                for (int h = 0; h < nd; h++) { row["Çözüm adayı " + (h + 1)] = randPop[minindex][h]; }
                                row["İşlem süresi"] = sw.ElapsedMilliseconds;

                                table.Rows.Add(row);
                                dgwFitnessInf.DataSource = table;
                            }
                        }
                        break;
                }

                try
                {
                    double[] bfs = new double[dgwFitnessInf.Rows.Count - 1];
                    foreach (DataGridViewRow row in dgwFitnessInf.Rows)
                    {
                        ort += Convert.ToDouble(row.Cells[0].Value);
                        bf = Convert.ToDouble(row.Cells[0].Value);
                        if (m == dgwFitnessInf.Rows.Count - 1) { break; }
                        bfs[m] = bf;
                        m++;
                    }
                    average = ort / dgwFitnessInf.Rows.Count;
                    for (int i = 0; i < dgwFitnessInf.Rows.Count - 1; i++)
                    {
                        ss += Math.Pow((bfs[i] - average), 2);
                    }
                    ss = ss / (dgwFitnessInf.Rows.Count - 2);

                    label3.Text = bfs.Min() + "";
                    label4.Text = bfs.Max() + "";
                    label5.Text = (average) + "";
                    label11.Text = ss + "";

                    row["Deney sayısı"] = txtExperiments.Text;
                    row["Min en iyi çözüm"] = bfs.Min();
                    row["Max en iyi çözüm"] = bfs.Max();
                    row["En iyi çözümlerin ortalaması"] = average;
                    row["Standart sapma"] = ss;
                    pnlInfo.Visible = true;
                    btnStart.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen probleminize uygun bir fonksiyon seçiniz."); ;
                }



            }
        }

    }
}
