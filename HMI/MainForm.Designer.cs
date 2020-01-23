namespace HMI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.TabMenu = new System.Windows.Forms.TabControl();
			this.Main = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Sensor1Data = new System.Windows.Forms.DataGridView();
			this.Sensor2Data = new System.Windows.Forms.DataGridView();
			this.StatusPanel = new System.Windows.Forms.GroupBox();
			this.StatusList = new System.Windows.Forms.FlowLayoutPanel();
			this.Sensor1Status = new System.Windows.Forms.Label();
			this.Sensor2Status = new System.Windows.Forms.Label();
			this.Robot1Status = new System.Windows.Forms.Label();
			this.Robot2Status = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.LeftDoorImage = new System.Windows.Forms.PictureBox();
			this.RightDoorImage = new System.Windows.Forms.PictureBox();
			this.Configuration = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.StatisticsChartArea = new System.Windows.Forms.TableLayoutPanel();
			this.SensorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ByPass = new System.Windows.Forms.TabPage();
			this.BypassToggle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.Logs = new System.Windows.Forms.TabPage();
			this.LogConsole = new System.Windows.Forms.TextBox();
			this.GlobalFormLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.Exit = new System.Windows.Forms.Button();
			this.TitleBar = new System.Windows.Forms.Label();
			this.TabMenu.SuspendLayout();
			this.Main.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).BeginInit();
			this.StatusPanel.SuspendLayout();
			this.StatusList.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeftDoorImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RightDoorImage)).BeginInit();
			this.Statistics.SuspendLayout();
			this.StatisticsChartArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats)).BeginInit();
			this.ByPass.SuspendLayout();
			this.Logs.SuspendLayout();
			this.GlobalFormLayout.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabMenu
			// 
			this.TabMenu.Controls.Add(this.Main);
			this.TabMenu.Controls.Add(this.Configuration);
			this.TabMenu.Controls.Add(this.Statistics);
			this.TabMenu.Controls.Add(this.ByPass);
			this.TabMenu.Controls.Add(this.Logs);
			this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMenu.ItemSize = new System.Drawing.Size(120, 40);
			this.TabMenu.Location = new System.Drawing.Point(0, 40);
			this.TabMenu.Margin = new System.Windows.Forms.Padding(0);
			this.TabMenu.Multiline = true;
			this.TabMenu.Name = "TabMenu";
			this.TabMenu.Padding = new System.Drawing.Point(0, 0);
			this.TabMenu.SelectedIndex = 0;
			this.TabMenu.Size = new System.Drawing.Size(1280, 760);
			this.TabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabMenu.TabIndex = 2;
			// 
			// Main
			// 
			this.Main.BackColor = System.Drawing.Color.White;
			this.Main.Controls.Add(this.tableLayoutPanel1);
			this.Main.Location = new System.Drawing.Point(4, 44);
			this.Main.Margin = new System.Windows.Forms.Padding(0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(1068, 514);
			this.Main.TabIndex = 0;
			this.Main.Text = "메인";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.StatusPanel, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 712);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.Sensor1Data, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.Sensor2Data, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(508, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(508, 712);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// Sensor1Data
			// 
			this.Sensor1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor1Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor1Data.Location = new System.Drawing.Point(3, 3);
			this.Sensor1Data.Name = "Sensor1Data";
			this.Sensor1Data.RowHeadersWidth = 51;
			this.Sensor1Data.RowTemplate.Height = 27;
			this.Sensor1Data.Size = new System.Drawing.Size(502, 350);
			this.Sensor1Data.TabIndex = 0;
			// 
			// Sensor2Data
			// 
			this.Sensor2Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor2Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor2Data.Location = new System.Drawing.Point(3, 359);
			this.Sensor2Data.Name = "Sensor2Data";
			this.Sensor2Data.RowHeadersWidth = 51;
			this.Sensor2Data.RowTemplate.Height = 27;
			this.Sensor2Data.Size = new System.Drawing.Size(502, 350);
			this.Sensor2Data.TabIndex = 1;
			// 
			// StatusPanel
			// 
			this.StatusPanel.Controls.Add(this.StatusList);
			this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusPanel.Location = new System.Drawing.Point(1016, 0);
			this.StatusPanel.Margin = new System.Windows.Forms.Padding(0);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Size = new System.Drawing.Size(256, 712);
			this.StatusPanel.TabIndex = 2;
			this.StatusPanel.TabStop = false;
			this.StatusPanel.Text = "연결 상태";
			// 
			// StatusList
			// 
			this.StatusList.Controls.Add(this.Sensor1Status);
			this.StatusList.Controls.Add(this.Sensor2Status);
			this.StatusList.Controls.Add(this.Robot1Status);
			this.StatusList.Controls.Add(this.Robot2Status);
			this.StatusList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusList.Location = new System.Drawing.Point(3, 26);
			this.StatusList.Margin = new System.Windows.Forms.Padding(0);
			this.StatusList.Name = "StatusList";
			this.StatusList.Size = new System.Drawing.Size(250, 683);
			this.StatusList.TabIndex = 0;
			// 
			// Sensor1Status
			// 
			this.Sensor1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor1Status.ForeColor = System.Drawing.Color.White;
			this.Sensor1Status.Location = new System.Drawing.Point(0, 5);
			this.Sensor1Status.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.Sensor1Status.Name = "Sensor1Status";
			this.Sensor1Status.Size = new System.Drawing.Size(250, 70);
			this.Sensor1Status.TabIndex = 0;
			this.Sensor1Status.Text = "센서 1";
			this.Sensor1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor2Status
			// 
			this.Sensor2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor2Status.ForeColor = System.Drawing.Color.White;
			this.Sensor2Status.Location = new System.Drawing.Point(0, 85);
			this.Sensor2Status.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.Sensor2Status.Name = "Sensor2Status";
			this.Sensor2Status.Size = new System.Drawing.Size(250, 70);
			this.Sensor2Status.TabIndex = 1;
			this.Sensor2Status.Text = "센서 2";
			this.Sensor2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Robot1Status
			// 
			this.Robot1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot1Status.ForeColor = System.Drawing.Color.White;
			this.Robot1Status.Location = new System.Drawing.Point(0, 165);
			this.Robot1Status.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.Robot1Status.Name = "Robot1Status";
			this.Robot1Status.Size = new System.Drawing.Size(250, 70);
			this.Robot1Status.TabIndex = 2;
			this.Robot1Status.Text = "로봇 1";
			this.Robot1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Robot2Status
			// 
			this.Robot2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot2Status.ForeColor = System.Drawing.Color.White;
			this.Robot2Status.Location = new System.Drawing.Point(0, 245);
			this.Robot2Status.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.Robot2Status.Name = "Robot2Status";
			this.Robot2Status.Size = new System.Drawing.Size(250, 70);
			this.Robot2Status.TabIndex = 3;
			this.Robot2Status.Text = "로봇 2";
			this.Robot2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.LeftDoorImage, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.RightDoorImage, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(508, 712);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// LeftDoorImage
			// 
			this.LeftDoorImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LeftDoorImage.Location = new System.Drawing.Point(3, 3);
			this.LeftDoorImage.Name = "LeftDoorImage";
			this.LeftDoorImage.Size = new System.Drawing.Size(502, 350);
			this.LeftDoorImage.TabIndex = 0;
			this.LeftDoorImage.TabStop = false;
			// 
			// RightDoorImage
			// 
			this.RightDoorImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightDoorImage.Location = new System.Drawing.Point(3, 359);
			this.RightDoorImage.Name = "RightDoorImage";
			this.RightDoorImage.Size = new System.Drawing.Size(502, 350);
			this.RightDoorImage.TabIndex = 1;
			this.RightDoorImage.TabStop = false;
			// 
			// Configuration
			// 
			this.Configuration.BackColor = System.Drawing.Color.White;
			this.Configuration.Location = new System.Drawing.Point(4, 44);
			this.Configuration.Margin = new System.Windows.Forms.Padding(0);
			this.Configuration.Name = "Configuration";
			this.Configuration.Size = new System.Drawing.Size(1272, 712);
			this.Configuration.TabIndex = 1;
			this.Configuration.Text = "설정";
			// 
			// Statistics
			// 
			this.Statistics.BackColor = System.Drawing.Color.White;
			this.Statistics.Controls.Add(this.StatisticsChartArea);
			this.Statistics.Location = new System.Drawing.Point(4, 44);
			this.Statistics.Name = "Statistics";
			this.Statistics.Size = new System.Drawing.Size(1272, 712);
			this.Statistics.TabIndex = 2;
			this.Statistics.Text = "통계";
			// 
			// StatisticsChartArea
			// 
			this.StatisticsChartArea.ColumnCount = 1;
			this.StatisticsChartArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.StatisticsChartArea.Controls.Add(this.SensorChart, 0, 0);
			this.StatisticsChartArea.Controls.Add(this.Stats, 0, 1);
			this.StatisticsChartArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatisticsChartArea.Location = new System.Drawing.Point(0, 0);
			this.StatisticsChartArea.Margin = new System.Windows.Forms.Padding(0);
			this.StatisticsChartArea.Name = "StatisticsChartArea";
			this.StatisticsChartArea.RowCount = 2;
			this.StatisticsChartArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.StatisticsChartArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.StatisticsChartArea.Size = new System.Drawing.Size(1272, 712);
			this.StatisticsChartArea.TabIndex = 0;
			// 
			// SensorChart
			// 
			chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY.Maximum = 5D;
			chartArea1.AxisY.Minimum = -5D;
			chartArea1.Name = "Sensor1";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 33F;
			chartArea1.Position.Width = 85F;
			chartArea1.Position.X = 2.5F;
			chartArea1.Position.Y = 3F;
			chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea2.AxisY.Maximum = 5D;
			chartArea2.AxisY.Minimum = -5D;
			chartArea2.Name = "Sensor2";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 33F;
			chartArea2.Position.Width = 85F;
			chartArea2.Position.X = 2.5F;
			chartArea2.Position.Y = 36F;
			chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea3.Name = "Delta";
			chartArea3.Position.Auto = false;
			chartArea3.Position.Height = 31F;
			chartArea3.Position.Width = 85F;
			chartArea3.Position.X = 2.5F;
			chartArea3.Position.Y = 69F;
			this.SensorChart.ChartAreas.Add(chartArea1);
			this.SensorChart.ChartAreas.Add(chartArea2);
			this.SensorChart.ChartAreas.Add(chartArea3);
			this.SensorChart.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.DockedToChartArea = "Sensor1";
			legend1.IsDockedInsideChartArea = false;
			legend1.Name = "Sensor1";
			legend1.Title = "센서 1";
			legend2.DockedToChartArea = "Sensor2";
			legend2.IsDockedInsideChartArea = false;
			legend2.Name = "Sensor2";
			legend2.Title = "센서 2";
			legend3.DockedToChartArea = "Delta";
			legend3.IsDockedInsideChartArea = false;
			legend3.Name = "Delta";
			legend3.Title = "편차 값";
			legend4.Enabled = false;
			legend4.Name = "Hidden";
			this.SensorChart.Legends.Add(legend1);
			this.SensorChart.Legends.Add(legend2);
			this.SensorChart.Legends.Add(legend3);
			this.SensorChart.Legends.Add(legend4);
			this.SensorChart.Location = new System.Drawing.Point(0, 0);
			this.SensorChart.Margin = new System.Windows.Forms.Padding(0);
			this.SensorChart.Name = "SensorChart";
			series1.BorderWidth = 3;
			series1.ChartArea = "Sensor1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series1.Legend = "Sensor1";
			series1.LegendText = "벤딩 전";
			series1.Name = "Sensor1Before";
			series2.BorderWidth = 3;
			series2.ChartArea = "Sensor1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series2.Legend = "Sensor1";
			series2.LegendText = "벤딩 후";
			series2.Name = "Sensor1After";
			series3.ChartArea = "Sensor1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series3.Legend = "Hidden";
			series3.Name = "Sensor1MaxPlus";
			series4.ChartArea = "Sensor1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series4.Legend = "Hidden";
			series4.Name = "Sensor1MaxMinus";
			series5.ChartArea = "Sensor1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series5.Legend = "Hidden";
			series5.Name = "Sensor1MinPlus";
			series6.ChartArea = "Sensor1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series6.Legend = "Hidden";
			series6.Name = "Sensor1MinMinus";
			series7.BorderWidth = 3;
			series7.ChartArea = "Sensor2";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series7.Legend = "Sensor2";
			series7.LegendText = "벤딩 전";
			series7.Name = "Sensor2Before";
			series8.BorderWidth = 3;
			series8.ChartArea = "Sensor2";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series8.Legend = "Sensor2";
			series8.LegendText = "벤딩 후";
			series8.Name = "Sensor2After";
			series9.ChartArea = "Sensor2";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series9.Legend = "Hidden";
			series9.Name = "Sensor2MaxPlus";
			series10.ChartArea = "Sensor2";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series10.Legend = "Hidden";
			series10.Name = "Sensor2MaxMinus";
			series11.ChartArea = "Sensor2";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series11.Legend = "Hidden";
			series11.Name = "Sensor2MinPlus";
			series12.ChartArea = "Sensor2";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series12.Legend = "Hidden";
			series12.Name = "Sensor2MinMinus";
			series13.ChartArea = "Delta";
			series13.Legend = "Delta";
			series13.LegendText = "센서1";
			series13.Name = "Sensor1Delta";
			series14.ChartArea = "Delta";
			series14.Legend = "Delta";
			series14.LegendText = "센서 2";
			series14.Name = "Sensor2Delta";
			this.SensorChart.Series.Add(series1);
			this.SensorChart.Series.Add(series2);
			this.SensorChart.Series.Add(series3);
			this.SensorChart.Series.Add(series4);
			this.SensorChart.Series.Add(series5);
			this.SensorChart.Series.Add(series6);
			this.SensorChart.Series.Add(series7);
			this.SensorChart.Series.Add(series8);
			this.SensorChart.Series.Add(series9);
			this.SensorChart.Series.Add(series10);
			this.SensorChart.Series.Add(series11);
			this.SensorChart.Series.Add(series12);
			this.SensorChart.Series.Add(series13);
			this.SensorChart.Series.Add(series14);
			this.SensorChart.Size = new System.Drawing.Size(1272, 427);
			this.SensorChart.TabIndex = 0;
			// 
			// Stats
			// 
			chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea4.Name = "StatsArea";
			this.Stats.ChartAreas.Add(chartArea4);
			this.Stats.Dock = System.Windows.Forms.DockStyle.Fill;
			legend5.Alignment = System.Drawing.StringAlignment.Center;
			legend5.DockedToChartArea = "StatsArea";
			legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend5.IsDockedInsideChartArea = false;
			legend5.Name = "StatsLegend";
			this.Stats.Legends.Add(legend5);
			this.Stats.Location = new System.Drawing.Point(0, 427);
			this.Stats.Margin = new System.Windows.Forms.Padding(0);
			this.Stats.Name = "Stats";
			this.Stats.RightToLeft = System.Windows.Forms.RightToLeft.No;
			series15.ChartArea = "StatsArea";
			series15.Legend = "StatsLegend";
			series15.LegendText = "벤딩불가";
			series15.Name = "Failed";
			series16.ChartArea = "StatsArea";
			series16.Legend = "StatsLegend";
			series16.LegendText = "통과";
			series16.Name = "Passed";
			series17.ChartArea = "StatsArea";
			series17.Legend = "StatsLegend";
			series17.LegendText = "1차 벤딩";
			series17.Name = "FirstBended";
			series18.ChartArea = "StatsArea";
			series18.Legend = "StatsLegend";
			series18.LegendText = "2차 벤딩";
			series18.Name = "SecondBended";
			this.Stats.Series.Add(series15);
			this.Stats.Series.Add(series16);
			this.Stats.Series.Add(series17);
			this.Stats.Series.Add(series18);
			this.Stats.Size = new System.Drawing.Size(1272, 285);
			this.Stats.TabIndex = 1;
			this.Stats.Text = "chart2";
			// 
			// ByPass
			// 
			this.ByPass.BackColor = System.Drawing.Color.White;
			this.ByPass.Controls.Add(this.BypassToggle);
			this.ByPass.Controls.Add(this.label5);
			this.ByPass.Location = new System.Drawing.Point(4, 44);
			this.ByPass.Margin = new System.Windows.Forms.Padding(0);
			this.ByPass.Name = "ByPass";
			this.ByPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ByPass.Size = new System.Drawing.Size(1272, 712);
			this.ByPass.TabIndex = 3;
			this.ByPass.Text = "BYPASS";
			// 
			// BypassToggle
			// 
			this.BypassToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BypassToggle.BackColor = System.Drawing.Color.DarkGray;
			this.BypassToggle.FlatAppearance.BorderSize = 0;
			this.BypassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BypassToggle.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.BypassToggle.Location = new System.Drawing.Point(466, 349);
			this.BypassToggle.Name = "BypassToggle";
			this.BypassToggle.Size = new System.Drawing.Size(340, 50);
			this.BypassToggle.TabIndex = 1;
			this.BypassToggle.Text = "꺼짐";
			this.BypassToggle.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(406, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(460, 70);
			this.label5.TabIndex = 0;
			this.label5.Text = "BY PASS 모드";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Logs
			// 
			this.Logs.BackColor = System.Drawing.Color.White;
			this.Logs.Controls.Add(this.LogConsole);
			this.Logs.Location = new System.Drawing.Point(4, 44);
			this.Logs.Name = "Logs";
			this.Logs.Size = new System.Drawing.Size(1272, 712);
			this.Logs.TabIndex = 4;
			this.Logs.Text = "로그";
			// 
			// LogConsole
			// 
			this.LogConsole.BackColor = System.Drawing.Color.Black;
			this.LogConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogConsole.ForeColor = System.Drawing.Color.Lime;
			this.LogConsole.Location = new System.Drawing.Point(0, 0);
			this.LogConsole.Margin = new System.Windows.Forms.Padding(0);
			this.LogConsole.MaxLength = 65536;
			this.LogConsole.Multiline = true;
			this.LogConsole.Name = "LogConsole";
			this.LogConsole.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.LogConsole.Size = new System.Drawing.Size(1272, 702);
			this.LogConsole.TabIndex = 0;
			// 
			// GlobalFormLayout
			// 
			this.GlobalFormLayout.ColumnCount = 1;
			this.GlobalFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.GlobalFormLayout.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.GlobalFormLayout.Controls.Add(this.TabMenu, 0, 1);
			this.GlobalFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GlobalFormLayout.Location = new System.Drawing.Point(0, 0);
			this.GlobalFormLayout.Margin = new System.Windows.Forms.Padding(0);
			this.GlobalFormLayout.Name = "GlobalFormLayout";
			this.GlobalFormLayout.RowCount = 2;
			this.GlobalFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.GlobalFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
			this.GlobalFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.GlobalFormLayout.Size = new System.Drawing.Size(1280, 800);
			this.GlobalFormLayout.TabIndex = 3;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel4.Controls.Add(this.Exit, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.TitleBar, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1280, 40);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.OrangeRed;
			this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Exit.ForeColor = System.Drawing.Color.White;
			this.Exit.Location = new System.Drawing.Point(1216, 0);
			this.Exit.Margin = new System.Windows.Forms.Padding(0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(64, 40);
			this.Exit.TabIndex = 1;
			this.Exit.Text = "X";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.RoyalBlue;
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitleBar.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TitleBar.ForeColor = System.Drawing.Color.White;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(1216, 40);
			this.TitleBar.TabIndex = 0;
			this.TitleBar.Text = "Tango Project";
			this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.GlobalFormLayout);
			this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Tango_Project";
			this.TabMenu.ResumeLayout(false);
			this.Main.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).EndInit();
			this.StatusPanel.ResumeLayout(false);
			this.StatusList.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LeftDoorImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RightDoorImage)).EndInit();
			this.Statistics.ResumeLayout(false);
			this.StatisticsChartArea.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats)).EndInit();
			this.ByPass.ResumeLayout(false);
			this.Logs.ResumeLayout(false);
			this.Logs.PerformLayout();
			this.GlobalFormLayout.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.TabControl TabMenu;
		private System.Windows.Forms.TabPage Main;
		private System.Windows.Forms.TabPage Configuration;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.TabPage ByPass;
		private System.Windows.Forms.TabPage Logs;
		private System.Windows.Forms.TextBox LogConsole;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BypassToggle;
		private System.Windows.Forms.TableLayoutPanel StatisticsChartArea;
		private System.Windows.Forms.DataVisualization.Charting.Chart SensorChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart Stats;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView Sensor1Data;
		private System.Windows.Forms.DataGridView Sensor2Data;
		private System.Windows.Forms.GroupBox StatusPanel;
		private System.Windows.Forms.FlowLayoutPanel StatusList;
		private System.Windows.Forms.Label Sensor1Status;
		private System.Windows.Forms.Label Sensor2Status;
		private System.Windows.Forms.Label Robot1Status;
		private System.Windows.Forms.Label Robot2Status;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox LeftDoorImage;
		private System.Windows.Forms.PictureBox RightDoorImage;
		private System.Windows.Forms.TableLayoutPanel GlobalFormLayout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label TitleBar;
		private System.Windows.Forms.Button Exit;
	}
}

