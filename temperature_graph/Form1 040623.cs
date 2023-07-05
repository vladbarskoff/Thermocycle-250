using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace temperature_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";




            






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        List<string> x;
        List<int> y;

        List<string> x2;
        List<int> y2;

        // May 5, 2023|11:40|25

        int x_line_zoom = 1;
        int y_line_zoom = 5;



















        private void загрузитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //Инициализация массивов
                x = new List<string>();
                y = new List<int>();

                x2 = new List<string>();
                y2 = new List<int>();

                string line;
                string[] line2;
                string[] line3;

                string line_test_time;
                string line54;
                string[] line55;

               

                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                while ((line = streamReader.ReadLine()) != null)
                {

                    // 23 / 5 / 23 | 11:17:40 | 23 | 28 | 0:12@ 

                    line2 = line.Split('|'); //разбиваем строку на подстроки



                    line54 = line2[4];
                    line55 = line54.Split('@');
                    line_test_time = line55[0];

                  
                    string lineDate = line2[0] + " " + line2[1]; // date
    
                    string DMY = Convert.ToString(lineDate.Split('/'));
          


                    x.Add(Convert.ToString(lineDate));  // реальное время
                    y.Add(Convert.ToInt32(line2[3]));   // temp

                    x2.Add(Convert.ToString(line2[4]));  // тестовое время
                    y2.Add(Convert.ToInt32(line2[3]));  // temp


                }
                streamReader.Close();


                chart1.Titles.Add("График зависимости температуры в камере от реального времени");

                chart1.ChartAreas[0].CursorX.AutoScroll = true;
                chart1.ChartAreas[0].CursorY.AutoScroll = true;

                chart1.ChartAreas[0].AxisX.ScrollBar.Size = 20;


                chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;


                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(1, 6);

                chart1.ChartAreas[0].RecalculateAxesScale();

                ////////////////////////////////////////////////////////////////
                
                chart2.Titles.Add("График зависимости температуры в камере от тестового времени");

                chart2.ChartAreas[0].CursorX.AutoScroll = true;
                chart2.ChartAreas[0].CursorY.AutoScroll = true;

                chart2.ChartAreas[0].AxisX.ScrollBar.Size = 20;


                chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                chart2.ChartAreas[0].AxisX.ScrollBar.Enabled = true;


                chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                chart2.ChartAreas[0].AxisX.ScaleView.Zoom(1, 6);

                chart2.ChartAreas[0].RecalculateAxesScale();





                //Заполняем график "Реальное время" считанными значениями
                for (int i = 0; i < x.Count; i++)
                {
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisY.Interval = 5;
                    chart1.Series["Series1"].Points.AddXY(x[i], y[i]);
                }




                //Заполняем график "Тестовое время" считанными значениями
                for (int i = 0; i < x.Count; i++)
                {
                    chart2.ChartAreas[0].AxisX.Interval = 1;
                    chart2.ChartAreas[0].AxisY.Interval = 5;
                    chart2.Series["Series2"].Points.AddXY(x2[i], y2[i]);
                }


            }
        }



















        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutProgramm newForm = new aboutProgramm();
            newForm.Show();
        }





        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            chart1.ChartAreas[0].AxisY.Interval = (double)numericUpDown1.Value;
            chart2.ChartAreas[0].AxisY.Interval = (double)numericUpDown1.Value;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = (double)numericUpDown2.Value;
            chart2.ChartAreas[0].AxisX.Interval = (double)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // string pathImage = Environment.CurrentDirectory + "\\graph.png";
           // chart1.SaveImage(pathImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
           // MessageBox.Show("Графики сохранены!");



            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "Sample.jpg";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }  
            







        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "Sample.jpg";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chart2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chart2.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }















    }
}
