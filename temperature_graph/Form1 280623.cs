using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

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


        string poop;
        Int32 quantity;

        // переменные для отчёта
        int appa;
        string global_test_time;
        string global_no_line_time;
        string mean_warm_thermo_time;
        string[] warm_time_line3;
        string array_warm_time_line3;
        int difference_WTL3;

        int max_time_WTL3;
        int min_time_WTL3 ;


        int length_power1;
        int length_power2;

        int length_warm_temp_1;
        int length_warm_temp_2;

        string amma11;
        string amma12;
        string amma21;
        string amma22;

        int tempo11;
        int tempo12;
        int tempo21;
        int tempo22;

        int diff_tempo1;
        int diff_tempo2;

        int speed_warm_test_1;
        double seco_power1;
        double double_seco_power1;


        int speed_warm_test_2;
        double seco_power2;
        double double_seco_power2;

        string diff_amma1;
        string diff_amma2;
        string ultra_diff_amma;





        //////////////////////////




        int length_cool1;
        int length_cool_temp_1;
        string gumma11;
        string gumma12;
        string diff_gumma1;
        int diff_cooler1;
        int cooler11;
        int cooler21;
        double seco_cool1;
        int speed_cool_test_1;
        double double_seco_cool1;


        ArrayList myList = new ArrayList();

        int coop1;
        int coop2;

        int number_name_of_test;
        string name_of_test;

        int info_global_test_time;
        int info_max_temp_warming;
        int info_hold_warm_time;
        int info_cold_warm_time;

        int flag_report_arrived = 0;

        string info_date_start_test;
        string info_time_start_test;
        string info_date_end_test;
        string info_time_end_test;

        string cool_mount;
        // переменные для отчёта







        List<string> x;
        List<int> y;

        List<string> x2;
        List<int> y2;

        List<string> x3;
        List<int> y3;

        List<string> x4;
        List<int> y4;

        List<string> x5;
        List<int> y5;

        List<string> x6;
        List<int> y6;

        List<string> x7;
        List<int> y7;

        List<string> x8;
        List<int> y8;

        List<string> x9;
        List<int> y9;

        List<string> x10;
        List<int> y10;

        List<string> x11;
        List<int> y11;

        List<string> x12;
        List<int> y12;

        List<string> x13;
        List<int> y13;

        List<string> x14;
        List<int> y14;

        List<string> x15;
        List<int> y15;

        // May 5, 2023|11:40|25


        int flag_open_data = 0;




        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            //var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                   // yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                   // var yMin = yAxis.ScaleView.ViewMinimum;
                   // var yMax = yAxis.ScaleView.ViewMaximum;
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                   // var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                   // var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                  //  yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }






        private void chart2_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            //var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    // yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    // var yMin = yAxis.ScaleView.ViewMinimum;
                    // var yMax = yAxis.ScaleView.ViewMaximum;
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    // var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    // var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    //  yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }





        
        private void chart3_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            //var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    // yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    // var yMin = yAxis.ScaleView.ViewMinimum;
                    // var yMax = yAxis.ScaleView.ViewMaximum;
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    // var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    // var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    //  yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }


        






















        private void загрузитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {




            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {



                // очистка памяти от всех графиков перез загрузкой нового графика
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();

                    chart1.Titles.Clear();
                }

                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();

                    chart2.Titles.Clear();
                }

                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();

                    chart3.Titles.Clear();
                }
                // очистка памяти от всех графиков перез загрузкой нового графика


                flag_open_data = 0;         // флаг, извещающим о том, что файл с данными пока НЕ загружен 
                flag_report_arrived = 0;    // флаг, извещающим о том, что отчёт пока НЕ сформирован 

                //Инициализация массивов
                x = new List<string>();
                y = new List<int>();

                x2 = new List<string>();
                y2 = new List<int>();

                x3 = new List<string>();
                y3 = new List<int>();

                x4 = new List<string>();
                y4 = new List<int>();

                x5 = new List<string>();
                y5 = new List<int>();

                x6 = new List<string>();
                y6 = new List<int>();

                x7 = new List<string>();
                y7 = new List<int>();

                x8 = new List<string>();
                y8 = new List<int>();

                x9 = new List<string>();
                y9 = new List<int>();

                x10 = new List<string>();
                y10 = new List<int>();

                x11 = new List<string>();
                y11 = new List<int>();

                x12 = new List<string>();
                y12 = new List<int>();

                x13 = new List<string>();
                y13 = new List<int>();

                x14 = new List<string>();
                y14 = new List<int>();

                x15 = new List<string>();
                y15 = new List<int>();

                string line;
                string[] line2;
                

                string line_test_time;
                string line54;
                string[] line55;

                string quest;
                string ask;
                int cook;
                

                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                while ((line = streamReader.ReadLine()) != null)
                {

                    // 23 / 5 / 23 | 11:17:40 | 23 | 28 | 0:12:15 | 1 | 0 | 0:12:15 | 4@ 

                    line2 = line.Split('|'); //разбиваем строку на подстроки

                    //quest = line2[8];
                    //ask = Convert.ToString(quest);

                   

                    //line54 = line2[4];
                    //line55 = line54.Split('@');
                    //line_test_time = line55[0];


                    string lineDate = line2[0] + " " + line2[1]; // date
    
                    string DMY = Convert.ToString(lineDate.Split('/'));
          


                    x.Add(Convert.ToString(lineDate));  // реальное время
                    y.Add(Convert.ToInt32(line2[3]));   // temp

                    x2.Add(Convert.ToString(line2[4]));  // тестовое время
                    y2.Add(Convert.ToInt32(line2[3]));  // temp

                    x3.Add(Convert.ToString(line2[4]));  // тестовое время
                    y3.Add(Convert.ToInt32(line2[6]));  // режим работы

                    x4.Add(Convert.ToString(line2[4]));  // тестовое время
                 // y4.Add(Convert.ToInt32(line2[8]));  // режим работы

                    x5.Add(Convert.ToString(line2[7]));  // время отсутствия сети питания
                 // y5.Add(Convert.ToInt32(line2[6]));  // режим работы

                    x6.Add(Convert.ToString(line2[4]));  // тестовое время
                    y6.Add(Convert.ToInt32(line2[8]));  // номер цикла

                    x7.Add(Convert.ToString(line2[4]));  // тестовое время
                    y7.Add(Convert.ToInt32(line2[6]));  // режим работы

                    x8.Add(Convert.ToString(line2[4]));  // тестовое время
                    y8.Add(Convert.ToInt32(line2[3]));  // температура внутри камеры

                 // x9.Add(Convert.ToString(line2[10]));  // название выбранного режима испытаний
                    y9.Add(Convert.ToInt32(line2[10]));  // название выбранного режима испытаний

                 // x10.Add(Convert.ToString(line2[10]));  // название выбранного режима испытаний
                    y10.Add(Convert.ToInt32(line2[11]));  // заданное общее время теста

                 // x11.Add(Convert.ToString(line2[10]));  // название выбранного режима испытаний
                    y11.Add(Convert.ToInt32(line2[12]));  // заданное максимальная температура нагрева

                 // x12.Add(Convert.ToString(line2[10]));  // название выбранного режима испытаний
                    y12.Add(Convert.ToInt32(line2[13]));  // заданное время поддержания нагрева

                 // x13.Add(Convert.ToString(line2[10]));  // название выбранного режима испытаний
                    y13.Add(Convert.ToInt32(line2[14]));  // заданное время поддержания продувки

                    x14.Add(Convert.ToString(line2[0]));  // дата испытаний
                 // y14.Add(Convert.ToInt32(line2[14]));  // заданное время поддержания продувки

                    x15.Add(Convert.ToString(line2[1]));  // время испытаний
                 // y15.Add(Convert.ToInt32(line2[14]));  // заданное время поддержания продувки

                    /*


                    */
                    // poop = ask[0];
                }
                streamReader.Close();


                

                //chart1.Titles.Add("График зависимости температуры в камере от реального времени");
                chart1.Titles.Add(new Title(
                                            "График зависимости температуры в камере от реального времени",
                                            Docking.Top,
                                            new Font("Verdana", 12f, FontStyle.Bold),
                                            Color.Black
                                            )
                );

                chart1.ChartAreas[0].AxisX.Title = "Реальное время";
                chart1.ChartAreas[0].AxisY.Title = "Температура";


                chart1.ChartAreas[0].CursorX.AutoScroll = true;
                chart1.ChartAreas[0].CursorY.AutoScroll = true;

                chart1.ChartAreas[0].AxisX.ScrollBar.Size = 20;
                chart1.ChartAreas[0].AxisY.ScrollBar.Size = 20;

                chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;    // false
                chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

                chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;    // false
                chart1.ChartAreas[0].AxisY.ScrollBar.Enabled = true;


                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(1, 6);
                chart1.ChartAreas[0].AxisY.ScaleView.Zoom(1, 6);

                chart1.ChartAreas[0].RecalculateAxesScale();

                chart1.MouseWheel += chart1_MouseWheel; //////////////////////////////////////////////////////////////////////////////////////////////////////////

                ////////////////////////////////////////////////////////////////

                //chart2.Titles.Add("График зависимости температуры в камере от тестового времени");
                chart2.Titles.Add(new Title(
                             "График зависимости температуры в камере от тестового времени",
                             Docking.Top,
                             new Font("Verdana", 12f, FontStyle.Bold),
                             Color.Black
                           )
                );

                chart2.ChartAreas[0].AxisX.Title = "Тестовое время";
                chart2.ChartAreas[0].AxisY.Title = "Температура";

                chart2.ChartAreas[0].CursorX.AutoScroll = true;
                chart2.ChartAreas[0].CursorY.AutoScroll = true;

                chart2.ChartAreas[0].AxisX.ScrollBar.Size = 20;
                chart2.ChartAreas[0].AxisY.ScrollBar.Size = 20;

                chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                chart2.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

                chart2.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
                chart2.ChartAreas[0].AxisY.ScrollBar.Enabled = true;


                chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                chart2.ChartAreas[0].AxisX.ScaleView.Zoom(1, 6);
                chart2.ChartAreas[0].AxisY.ScaleView.Zoom(1, 6);

                chart2.ChartAreas[0].RecalculateAxesScale();

                chart2.MouseWheel += chart2_MouseWheel;

                ////////////////////////////////////////////////////////////////
                
                //chart3.Titles.Add("График режимов работы в течение тестового времени");
                chart3.Titles.Add(new Title(
                                             "Диаграммы режимов работы",
                                             Docking.Top,
                                             new Font("Verdana", 12f, FontStyle.Bold),
                                             Color.Black
                                           )
                );

                chart3.ChartAreas[0].AxisX.Title = "Тестовое время";
                chart3.ChartAreas[0].AxisY.Title = "Режим работы";

                chart3.ChartAreas[0].CursorX.AutoScroll = true;
                //chart3.ChartAreas[0].CursorY.AutoScroll = true;

                chart3.ChartAreas[0].AxisX.ScrollBar.Size = 20;
                //chart3.ChartAreas[0].AxisY.ScrollBar.Size = 20;

                chart3.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                chart3.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

                //chart3.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
                //chart3.ChartAreas[0].AxisY.ScrollBar.Enabled = true;


                chart3.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
               // chart3.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                chart3.ChartAreas[0].AxisX.ScaleView.Zoom(1, 6);
               // chart3.ChartAreas[0].AxisY.ScaleView.Zoom(1, 6);

                chart3.ChartAreas[0].RecalculateAxesScale();

                chart3.MouseWheel += chart3_MouseWheel;
                


















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

                    if (y3[i] == 0) // НАГРЕВ
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Red;

                    }

                    if (y3[i] == 1) // ПОДДЕРЖАНИЕ НАГРЕВА
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Orange;
                    }

                    if (y3[i] == 2) // ПРОДУВКА
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Blue;
                    }

                    if (y3[i] == 3) // ПОДДЕРЖАНИЕ ПРОДУВКИ
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Aqua;
                    }

                    if (y3[i] == 4) // ожидание напряжения в сети питания
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Black;
                    }

                    if (y3[i] == 5) // испытание на нагрев
                    {
                        chart2.Series["Series2"].Points[i].Color = Color.Pink;
                    }
                }

              

                
                //Заполняем график "Диаграмма режимов работы" считанными значениями
                for (int i = 0; i < x.Count; i++)
                {

                    chart3.ChartAreas[0].AxisX.Interval = 1;
                    chart3.ChartAreas[0].AxisY.Interval = 1;





                    if (y3[i] == 0) // нагрев
                    {
                        
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Red;

                    }

                    if (y3[i] == 1) // поддержание нагрева
                    {
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Orange;
                    }

                    if (y3[i] == 2) // продувка
                    {
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Blue;
                    }

                    if (y3[i] == 3) // поддержание продувки
                    {
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Aqua;
                    }


                    if (y3[i] == 4) // ожидание напряжения в сети питания
                    {
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Black;





                    }


                    if (y3[i] == 5) // испытание на нагрев
                    {
                        chart3.Series["Series3"].Points.AddXY(x3[i], y3[i]);
                        chart3.Series["Series3"].Points[i].Color = Color.Pink;
                    }




                }


                flag_open_data = 1; // флаг, извещающим о том, что файл с данными загружен 






/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // рассчитываем среднее время НАГРЕВА в режиме "ТЕРМОЦИКЛИРОВАНИЕ"
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                List<string> power1 = new List<string>();
                List<string> power2 = new List<string>();

                List<int> warm_temp_1 = new List<int>();
                List<int> warm_temp_2 = new List<int>();


                for (int i = 0; i < x.Count; i++)
                {
                    if ((y7[i] == 0) && (y6[i] == 0))
                    {
                        power1.Add(x7[i]);
                        warm_temp_1.Add(y8[i]);
                    }

                    if ((y7[i] == 5) && (y6[i] == 0))
                    {
                        power1.Add(x7[i]);
                        warm_temp_1.Add(y8[i]);
                    }
                }


                for (int i = 0; i < x.Count; i++)
                {
                    if ((y7[i] == 0) && (y6[i] == 1))
                    {
                        power2.Add(x7[i]);
                        warm_temp_2.Add(y8[i]);
                    }
                }



                length_power1 = power1.Count;
                length_power2 = power2.Count;

                length_warm_temp_1 = warm_temp_1.Count;
                length_warm_temp_2 = warm_temp_2.Count;


                amma11 = power1[0];



                
                info_max_temp_warming = y11[0];  // заданная максимальная температура нагрева
                for (int i = 0; i < power1.Count; i++)
                {
                    if (y8[i] == info_max_temp_warming) 
                    {
                        cool_mount = power1[i];
                    }
                }

                if (y7[0] == 5)
                {
                    amma12 = cool_mount;
                }
                else
                {
                    amma12 = power1[length_power1 - 1];
                }
                    

                tempo11 = warm_temp_1[0];
                tempo21 = warm_temp_1[length_warm_temp_1 - 1];

                DateTime dateTime_min1 = DateTime.Parse(amma11);
                DateTime dateTime_max1 = DateTime.Parse(amma12);
                TimeSpan diff_time_power1 = dateTime_max1 - dateTime_min1;


                diff_amma1 = Convert.ToString(dateTime_max1 - dateTime_min1);
                diff_tempo1 = tempo21 - tempo11;




               

                seco_power1 = Convert.ToDouble(diff_time_power1.TotalMinutes);
                double_seco_power1 = Convert.ToDouble(diff_tempo1 / seco_power1);
                speed_warm_test_1 = Convert.ToInt32(double_seco_power1);

         







                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // рассчитываем среднее время ПРОДУВКИ в режиме "ТЕРМОЦИКЛИРОВАНИЕ"
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                List<string> cool1 = new List<string>();
                List<int> cool_temp_1 = new List<int>();
            


                for (int i = 0; i < x.Count; i++)
                {
                    if ((y7[i] == 2) && (y6[i] == 0))
                    {
                        cool1.Add(x7[i]);
                        cool_temp_1.Add(y8[i]);
                    }

                    if ((y7[i] == 5) && (y6[i] == 0))
                    {
                        cool1.Add("0:1");
                        cool_temp_1.Add(0);
                    }
                }





                length_cool1 = cool1.Count;
           

                length_cool_temp_1 = cool_temp_1.Count;
           

                gumma11 = cool1[0];
                gumma12 = cool1[length_cool1 - (length_cool1 / 2)];

                cooler11 = cool_temp_1[0];
                cooler21 = cool_temp_1[length_cool_temp_1 - 1];

                DateTime dateTime_min3 = DateTime.Parse(gumma11);
                DateTime dateTime_max3 = DateTime.Parse(gumma12);
                TimeSpan diff_time_cool1 = dateTime_min3 - dateTime_max3;


                diff_gumma1 = Convert.ToString(dateTime_min3 - dateTime_max3);
                diff_cooler1 = cooler21 - cooler11;



                seco_cool1 = Convert.ToDouble(diff_time_cool1.TotalMinutes);
                double_seco_cool1 = Convert.ToDouble(diff_cooler1 / seco_cool1);

                if ((y7[0] == 5))
                {
                    speed_cool_test_1 = Convert.ToInt32(0);
                }
                else
                {
                    speed_cool_test_1 = Convert.ToInt32(double_seco_cool1);
                }
                


















                // формирование данных для отчёта
                for (int i = 0; i < x.Count; i++)
                {


                    // количество циклов
                    appa = y6[x.Count - 1];
                    appa += 1;



                    // фактически затраченное тестовое время
                    global_test_time = x4[x.Count - 1];



                    // общее время отсутствия сети питания
                    global_no_line_time = x5[x.Count - 1];



                    // название выбранного режима истпыния (0 - НАГРЕВ    1 - ТЕРМОЦИКЛИРОВАНИЕ)
                    number_name_of_test = y9[0];
                    if (number_name_of_test == 0)
                    {
                        name_of_test = "НАГРЕВ";
                    }
                    if (number_name_of_test == 1)
                    {
                        name_of_test = "ТЕРМОЦИКЛИРОВАНИЕ";
                    }


                    // заданное общее время теста
                    info_global_test_time = y10[0];



                    // заданная максимальная температура нагрева
                    info_max_temp_warming = y11[0];



                    // заданное время поддержания нагрева
                    info_hold_warm_time = y12[0];



                    // заданное время поддержания продувки
                    info_cold_warm_time = y13[0];




                    // дата начала испытания
                    info_date_start_test = x14[0];
                    // время начала испытания
                    info_time_start_test = x15[0];
                    // дата окончания испытания
                    info_date_end_test = x14[x.Count - 1];
                    // время окончания испытания
                    info_time_end_test = x15[x.Count - 1];


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
            chart3.ChartAreas[0].AxisY.Interval = (double)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = (double)numericUpDown2.Value;
            chart2.ChartAreas[0].AxisX.Interval = (double)numericUpDown2.Value;
            chart3.ChartAreas[0].AxisX.Interval = (double)numericUpDown2.Value;
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





        private void button3_Click(object sender, EventArgs e)
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
                            chart3.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chart3.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
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







        private void button4_Click(object sender, EventArgs e)
        {

            if (flag_open_data == 1)
            {
                textBox6.Text = Convert.ToString(appa);                     // количество фактически выполненных циклов
                textBox7.Text = Convert.ToString(global_test_time);         // время, фактически затраченное на испытание
                textBox8.Text = Convert.ToString(global_no_line_time);      // общее время отсутствия сети питания
                textBox9.Text = Convert.ToString(speed_warm_test_1);        // средняя скорость нагрева
                textBox10.Text = Convert.ToString(speed_cool_test_1);       // средняя скорость охлаждения при продувке

                textBox1.Text = Convert.ToString(name_of_test);             // название выбранного режима теста
                textBox2.Text = Convert.ToString(info_global_test_time);    // общее заданное время испытания
                textBox3.Text = Convert.ToString(info_max_temp_warming);    // заданное значение максимальной температуры нагрева
                textBox4.Text = Convert.ToString(info_hold_warm_time);      // заданное время поддержания нагрева
                textBox5.Text = Convert.ToString(info_cold_warm_time);      // заданное время поддержания продувки

                textBox11.Text = Convert.ToString(info_date_start_test);    // дата начала испытания
                textBox13.Text = Convert.ToString(info_time_start_test);    // время начала испытания

                textBox12.Text = Convert.ToString(info_date_end_test);      // дата окончания испытания
                textBox14.Text = Convert.ToString(info_time_end_test);      // время окончания испытания

                if (name_of_test == "НАГРЕВ")
                {
                    label30.Visible = false;
                    label36.Visible = true;
                }

                if (name_of_test == "ТЕРМОЦИКЛИРОВАНИЕ")
                {
                    label30.Visible = true;
                    label36.Visible = false;
                }

                flag_report_arrived = 1;
            }
            else
            {
                MessageBox.Show("Нет данных! Загрузите файл!");
            }



        }

        





        // СОХРАНИТЬ ОТЧЁТ
        private void button5_Click(object sender, EventArgs e)
        {

            if ((flag_open_data == 1) && (flag_report_arrived == 1))
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);

                    streamWriter.WriteLine("Дата и время начала испытания: " + textBox11.Text + " | " + textBox13.Text);
                    streamWriter.WriteLine("Дата и время окончания испытания: " + textBox12.Text + " | " + textBox14.Text);

                    streamWriter.WriteLine("Тип испытания: " + textBox1.Text);
                    streamWriter.WriteLine("Заданная длительность испытания: " + textBox2.Text + " ( в часах)");
                    streamWriter.WriteLine("Заданная максимальная температура: " + textBox3.Text + " градусов Цельсия");
                    streamWriter.WriteLine("Заданное время поддержания нагрева: " + textBox4.Text + " (в минутах)");
                    streamWriter.WriteLine("Заданное время поддержания продувки (охлаждения): " + textBox5.Text + " (в минутах)");

                    streamWriter.WriteLine("Количество выполненных циклов: " + textBox6.Text);
                    streamWriter.WriteLine("Фактическое время испытания: " + textBox7.Text + " (ЧЧЧ:ММ:СС)");
                    streamWriter.WriteLine("Длительность отключения сети питания: " + textBox8.Text + " (ЧЧЧ:ММ)");
                    streamWriter.WriteLine("Средняя скорость нагрева: " + textBox9.Text + " (градусов в минуту)");
                    streamWriter.WriteLine("Средняя скорость охлаждения (при продувке): " + textBox10.Text + " (градусов в минуту)");

                    streamWriter.Close();
                }


            }


            if ((flag_open_data == 0) && (flag_report_arrived == 0))
            {
                MessageBox.Show("Нет даных! Загрузите файл!");
            }



            if ((flag_open_data == 1) && (flag_report_arrived == 0))
            {
                MessageBox.Show("Сформируйте отчёт!");
            }


        }
    }
}



