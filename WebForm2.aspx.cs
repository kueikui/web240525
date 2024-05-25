using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace web_1.Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 日期與人數資料
            DateTime[] yValues = { new DateTime(2023, 5, 1), new DateTime(2023, 5, 2), new DateTime(2023, 5, 3) };
            int[] xValues = { 120, 180, 150 };

            // 建立 Chart 物件
            Chart Chart1 = new Chart();
            Chart1.Width = 700;
            Chart1.Height = 400;

            // 增加 ChartArea
            Chart1.ChartAreas.Add("ChartArea1");

            // 增加 Series
            Chart1.Series.Add("Series1");

            // 增加 Legends
            Chart1.Legends.Add("Legends1");

            // 設定標題
            Title title = new Title();
            title.Text = "每日人數統計";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("Trebuchet MS", 14F, FontStyle.Bold);
            Chart1.Titles.Add(title);

            // 設定 ChartArea
            Chart1.ChartAreas["ChartArea1"].AxisY.Title = "日期";
            Chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "yyyy-MM-dd";
            Chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1;
            Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);

            Chart1.ChartAreas["ChartArea1"].AxisX.Title = "人數";
            Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.FromArgb(150, 150, 150);

            // 設定 Legends
            Chart1.Legends["Legends1"].Docking = Docking.Bottom;
            Chart1.Legends["Legends1"].BackColor = Color.FromArgb(235, 235, 235);
            Chart1.Legends["Legends1"].BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal;
            Chart1.Legends["Legends1"].BorderWidth = 1;
            Chart1.Legends["Legends1"].BorderColor = Color.FromArgb(200, 200, 200);

            // 設定 Series
            Chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            Chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            Chart1.Series["Series1"].Legend = "Legends1";
            Chart1.Series["Series1"].LegendText = "每日人數";
            Chart1.Series["Series1"].LabelFormat = "#,###";
            Chart1.Series["Series1"].MarkerSize = 8;
            Chart1.Series["Series1"].LabelForeColor = Color.FromArgb(0, 90, 255);
            Chart1.Series["Series1"].Font = new System.Drawing.Font("Trebuchet MS", 10, System.Drawing.FontStyle.Bold);
            Chart1.Series["Series1"].LabelBackColor = Color.FromArgb(150, 255, 255, 255);
            Chart1.Series["Series1"].Color = Color.FromArgb(240, 65, 140, 240);
            Chart1.Series["Series1"].IsValueShownAsLabel = true;

            // 加入 Chart 到頁面
            ChartPanel.Controls.Add(Chart1);
        }
        
    }
}