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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.TitleBar = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.TabMenu = new System.Windows.Forms.TabControl();
			this.Main = new System.Windows.Forms.TabPage();
			this.Configuration = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.ByPass = new System.Windows.Forms.TabPage();
			this.BypassToggle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.Logs = new System.Windows.Forms.TabPage();
			this.LogConsole = new System.Windows.Forms.TextBox();
			this.MainTabButton = new System.Windows.Forms.Button();
			this.StatisticsTabButton = new System.Windows.Forms.Button();
			this.ConfigTabButton = new System.Windows.Forms.Button();
			this.BypassTabButton = new System.Windows.Forms.Button();
			this.LogTabButton = new System.Windows.Forms.Button();
			this.StatisticsChartArea = new System.Windows.Forms.TableLayoutPanel();
			this.SensorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.DoorImage = new System.Windows.Forms.PictureBox();
			this.Sensor1Data = new System.Windows.Forms.DataGridView();
			this.Sensor2Data = new System.Windows.Forms.DataGridView();
			this.StatusPanel = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Sensor1Status = new System.Windows.Forms.Label();
			this.Sensor2Status = new System.Windows.Forms.Label();
			this.Robot1Status = new System.Windows.Forms.Label();
			this.Robot2Status = new System.Windows.Forms.Label();
			this.TabMenu.SuspendLayout();
			this.Main.SuspendLayout();
			this.Statistics.SuspendLayout();
			this.ByPass.SuspendLayout();
			this.Logs.SuspendLayout();
			this.StatisticsChartArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DoorImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).BeginInit();
			this.StatusPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.RoyalBlue;
			this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitleBar.ForeColor = System.Drawing.Color.White;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(1240, 40);
			this.TitleBar.TabIndex = 0;
			this.TitleBar.Text = "TangoProject";
			this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Red;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.ForeColor = System.Drawing.Color.White;
			this.Exit.Location = new System.Drawing.Point(1240, 0);
			this.Exit.Margin = new System.Windows.Forms.Padding(0);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(40, 40);
			this.Exit.TabIndex = 1;
			this.Exit.Text = "X";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// TabMenu
			// 
			this.TabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.TabMenu.Controls.Add(this.Main);
			this.TabMenu.Controls.Add(this.Configuration);
			this.TabMenu.Controls.Add(this.Statistics);
			this.TabMenu.Controls.Add(this.ByPass);
			this.TabMenu.Controls.Add(this.Logs);
			this.TabMenu.ItemSize = new System.Drawing.Size(100, 10);
			this.TabMenu.Location = new System.Drawing.Point(0, 80);
			this.TabMenu.Margin = new System.Windows.Forms.Padding(0);
			this.TabMenu.Name = "TabMenu";
			this.TabMenu.Padding = new System.Drawing.Point(0, 0);
			this.TabMenu.SelectedIndex = 0;
			this.TabMenu.Size = new System.Drawing.Size(1280, 720);
			this.TabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabMenu.TabIndex = 2;
			// 
			// Main
			// 
			this.Main.BackColor = System.Drawing.Color.White;
			this.Main.Controls.Add(this.tableLayoutPanel1);
			this.Main.Location = new System.Drawing.Point(4, 14);
			this.Main.Margin = new System.Windows.Forms.Padding(0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(1272, 702);
			this.Main.TabIndex = 0;
			// 
			// Configuration
			// 
			this.Configuration.BackColor = System.Drawing.Color.White;
			this.Configuration.Location = new System.Drawing.Point(4, 14);
			this.Configuration.Margin = new System.Windows.Forms.Padding(0);
			this.Configuration.Name = "Configuration";
			this.Configuration.Size = new System.Drawing.Size(1272, 702);
			this.Configuration.TabIndex = 1;
			// 
			// Statistics
			// 
			this.Statistics.BackColor = System.Drawing.Color.White;
			this.Statistics.Controls.Add(this.StatisticsChartArea);
			this.Statistics.Location = new System.Drawing.Point(4, 14);
			this.Statistics.Name = "Statistics";
			this.Statistics.Size = new System.Drawing.Size(1272, 702);
			this.Statistics.TabIndex = 2;
			// 
			// ByPass
			// 
			this.ByPass.BackColor = System.Drawing.Color.White;
			this.ByPass.Controls.Add(this.BypassToggle);
			this.ByPass.Controls.Add(this.label5);
			this.ByPass.Location = new System.Drawing.Point(4, 14);
			this.ByPass.Name = "ByPass";
			this.ByPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ByPass.Size = new System.Drawing.Size(1272, 702);
			this.ByPass.TabIndex = 3;
			// 
			// BypassToggle
			// 
			this.BypassToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BypassToggle.BackColor = System.Drawing.Color.DarkGray;
			this.BypassToggle.FlatAppearance.BorderSize = 0;
			this.BypassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BypassToggle.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.BypassToggle.Location = new System.Drawing.Point(465, 343);
			this.BypassToggle.Name = "BypassToggle";
			this.BypassToggle.Size = new System.Drawing.Size(342, 50);
			this.BypassToggle.TabIndex = 1;
			this.BypassToggle.Text = "꺼짐";
			this.BypassToggle.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(432, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(420, 60);
			this.label5.TabIndex = 0;
			this.label5.Text = "BY PASS 모드";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Logs
			// 
			this.Logs.BackColor = System.Drawing.Color.White;
			this.Logs.Controls.Add(this.LogConsole);
			this.Logs.Location = new System.Drawing.Point(4, 14);
			this.Logs.Name = "Logs";
			this.Logs.Size = new System.Drawing.Size(1272, 702);
			this.Logs.TabIndex = 4;
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
			// MainTabButton
			// 
			this.MainTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.MainTabButton.FlatAppearance.BorderSize = 0;
			this.MainTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MainTabButton.Location = new System.Drawing.Point(0, 40);
			this.MainTabButton.Margin = new System.Windows.Forms.Padding(0);
			this.MainTabButton.Name = "MainTabButton";
			this.MainTabButton.Size = new System.Drawing.Size(256, 40);
			this.MainTabButton.TabIndex = 3;
			this.MainTabButton.Text = "대시보드";
			this.MainTabButton.UseVisualStyleBackColor = true;
			this.MainTabButton.Click += new System.EventHandler(this.TabButton_Click);
			// 
			// StatisticsTabButton
			// 
			this.StatisticsTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.StatisticsTabButton.FlatAppearance.BorderSize = 0;
			this.StatisticsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StatisticsTabButton.Location = new System.Drawing.Point(512, 40);
			this.StatisticsTabButton.Margin = new System.Windows.Forms.Padding(0);
			this.StatisticsTabButton.Name = "StatisticsTabButton";
			this.StatisticsTabButton.Size = new System.Drawing.Size(256, 40);
			this.StatisticsTabButton.TabIndex = 4;
			this.StatisticsTabButton.Text = "통계";
			this.StatisticsTabButton.UseVisualStyleBackColor = true;
			this.StatisticsTabButton.Click += new System.EventHandler(this.TabButton_Click);
			// 
			// ConfigTabButton
			// 
			this.ConfigTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ConfigTabButton.FlatAppearance.BorderSize = 0;
			this.ConfigTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ConfigTabButton.Location = new System.Drawing.Point(256, 40);
			this.ConfigTabButton.Margin = new System.Windows.Forms.Padding(0);
			this.ConfigTabButton.Name = "ConfigTabButton";
			this.ConfigTabButton.Size = new System.Drawing.Size(256, 40);
			this.ConfigTabButton.TabIndex = 5;
			this.ConfigTabButton.Text = "설정";
			this.ConfigTabButton.UseVisualStyleBackColor = true;
			this.ConfigTabButton.Click += new System.EventHandler(this.TabButton_Click);
			// 
			// BypassTabButton
			// 
			this.BypassTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BypassTabButton.FlatAppearance.BorderSize = 0;
			this.BypassTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BypassTabButton.Location = new System.Drawing.Point(768, 40);
			this.BypassTabButton.Margin = new System.Windows.Forms.Padding(0);
			this.BypassTabButton.Name = "BypassTabButton";
			this.BypassTabButton.Size = new System.Drawing.Size(256, 40);
			this.BypassTabButton.TabIndex = 6;
			this.BypassTabButton.Text = "BY PASS";
			this.BypassTabButton.UseVisualStyleBackColor = true;
			this.BypassTabButton.Click += new System.EventHandler(this.TabButton_Click);
			// 
			// LogTabButton
			// 
			this.LogTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.LogTabButton.FlatAppearance.BorderSize = 0;
			this.LogTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogTabButton.Location = new System.Drawing.Point(1024, 40);
			this.LogTabButton.Margin = new System.Windows.Forms.Padding(0);
			this.LogTabButton.Name = "LogTabButton";
			this.LogTabButton.Size = new System.Drawing.Size(256, 40);
			this.LogTabButton.TabIndex = 7;
			this.LogTabButton.Text = "로그";
			this.LogTabButton.UseVisualStyleBackColor = true;
			this.LogTabButton.Click += new System.EventHandler(this.TabButton_Click);
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
			this.StatisticsChartArea.Size = new System.Drawing.Size(1272, 702);
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
			this.SensorChart.Size = new System.Drawing.Size(1272, 421);
			this.SensorChart.TabIndex = 0;
			// 
			// Stats
			// 
			chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea4.Name = "Failed";
			chartArea4.Position.Auto = false;
			chartArea4.Position.Height = 85F;
			chartArea4.Position.Width = 33F;
			chartArea4.Position.Y = 3F;
			chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea5.Name = "Passed";
			chartArea5.Position.Auto = false;
			chartArea5.Position.Height = 85F;
			chartArea5.Position.Width = 33F;
			chartArea5.Position.X = 33F;
			chartArea5.Position.Y = 3F;
			chartArea6.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea6.Name = "Bended";
			chartArea6.Position.Auto = false;
			chartArea6.Position.Height = 85F;
			chartArea6.Position.Width = 33F;
			chartArea6.Position.X = 66F;
			chartArea6.Position.Y = 3F;
			this.Stats.ChartAreas.Add(chartArea4);
			this.Stats.ChartAreas.Add(chartArea5);
			this.Stats.ChartAreas.Add(chartArea6);
			this.Stats.Dock = System.Windows.Forms.DockStyle.Fill;
			legend5.Alignment = System.Drawing.StringAlignment.Center;
			legend5.DockedToChartArea = "Failed";
			legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend5.IsDockedInsideChartArea = false;
			legend5.Name = "Failed";
			legend6.Alignment = System.Drawing.StringAlignment.Center;
			legend6.DockedToChartArea = "Passed";
			legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend6.IsDockedInsideChartArea = false;
			legend6.Name = "Passed";
			legend7.Alignment = System.Drawing.StringAlignment.Center;
			legend7.DockedToChartArea = "Bended";
			legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend7.IsDockedInsideChartArea = false;
			legend7.Name = "Bended";
			this.Stats.Legends.Add(legend5);
			this.Stats.Legends.Add(legend6);
			this.Stats.Legends.Add(legend7);
			this.Stats.Location = new System.Drawing.Point(0, 421);
			this.Stats.Margin = new System.Windows.Forms.Padding(0);
			this.Stats.Name = "Stats";
			this.Stats.RightToLeft = System.Windows.Forms.RightToLeft.No;
			series15.ChartArea = "Failed";
			series15.Legend = "Failed";
			series15.LegendText = "벤딩불가";
			series15.Name = "Failed";
			series16.ChartArea = "Passed";
			series16.Legend = "Passed";
			series16.LegendText = "통과";
			series16.Name = "Passed";
			series17.ChartArea = "Bended";
			series17.Legend = "Bended";
			series17.LegendText = "1차 벤딩";
			series17.Name = "FirstBended";
			series18.ChartArea = "Bended";
			series18.Legend = "Bended";
			series18.LegendText = "2차 벤딩";
			series18.Name = "SecondBended";
			this.Stats.Series.Add(series15);
			this.Stats.Series.Add(series16);
			this.Stats.Series.Add(series17);
			this.Stats.Series.Add(series18);
			this.Stats.Size = new System.Drawing.Size(1272, 281);
			this.Stats.TabIndex = 1;
			this.Stats.Text = "chart2";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.DoorImage, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.StatusPanel, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 702);
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(508, 702);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// DoorImage
			// 
			this.DoorImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DoorImage.Location = new System.Drawing.Point(3, 3);
			this.DoorImage.Name = "DoorImage";
			this.DoorImage.Size = new System.Drawing.Size(502, 696);
			this.DoorImage.TabIndex = 1;
			this.DoorImage.TabStop = false;
			// 
			// Sensor1Data
			// 
			this.Sensor1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor1Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor1Data.Location = new System.Drawing.Point(3, 3);
			this.Sensor1Data.Name = "Sensor1Data";
			this.Sensor1Data.RowHeadersWidth = 51;
			this.Sensor1Data.RowTemplate.Height = 27;
			this.Sensor1Data.Size = new System.Drawing.Size(502, 345);
			this.Sensor1Data.TabIndex = 0;
			// 
			// Sensor2Data
			// 
			this.Sensor2Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor2Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor2Data.Location = new System.Drawing.Point(3, 354);
			this.Sensor2Data.Name = "Sensor2Data";
			this.Sensor2Data.RowHeadersWidth = 51;
			this.Sensor2Data.RowTemplate.Height = 27;
			this.Sensor2Data.Size = new System.Drawing.Size(502, 345);
			this.Sensor2Data.TabIndex = 1;
			// 
			// StatusPanel
			// 
			this.StatusPanel.Controls.Add(this.flowLayoutPanel1);
			this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusPanel.Location = new System.Drawing.Point(1016, 0);
			this.StatusPanel.Margin = new System.Windows.Forms.Padding(0);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Size = new System.Drawing.Size(256, 702);
			this.StatusPanel.TabIndex = 2;
			this.StatusPanel.TabStop = false;
			this.StatusPanel.Text = "연결 상태";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.Sensor1Status);
			this.flowLayoutPanel1.Controls.Add(this.Sensor2Status);
			this.flowLayoutPanel1.Controls.Add(this.Robot1Status);
			this.flowLayoutPanel1.Controls.Add(this.Robot2Status);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 26);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 673);
			this.flowLayoutPanel1.TabIndex = 0;
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
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.StatisticsTabButton);
			this.Controls.Add(this.LogTabButton);
			this.Controls.Add(this.BypassTabButton);
			this.Controls.Add(this.ConfigTabButton);
			this.Controls.Add(this.MainTabButton);
			this.Controls.Add(this.TabMenu);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.TitleBar);
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
			this.Statistics.ResumeLayout(false);
			this.ByPass.ResumeLayout(false);
			this.ByPass.PerformLayout();
			this.Logs.ResumeLayout(false);
			this.Logs.PerformLayout();
			this.StatisticsChartArea.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DoorImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).EndInit();
			this.StatusPanel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TabControl TabMenu;
		private System.Windows.Forms.TabPage Main;
		private System.Windows.Forms.TabPage Configuration;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.TabPage ByPass;
		private System.Windows.Forms.TabPage Logs;
		private System.Windows.Forms.Button MainTabButton;
		private System.Windows.Forms.Button StatisticsTabButton;
		private System.Windows.Forms.Button ConfigTabButton;
		private System.Windows.Forms.Button BypassTabButton;
		private System.Windows.Forms.Button LogTabButton;
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
		private System.Windows.Forms.PictureBox DoorImage;
		private System.Windows.Forms.GroupBox StatusPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label Sensor1Status;
		private System.Windows.Forms.Label Sensor2Status;
		private System.Windows.Forms.Label Robot1Status;
		private System.Windows.Forms.Label Robot2Status;
	}
}

