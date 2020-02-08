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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.TabMenu = new System.Windows.Forms.TabControl();
			this.Main = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Sensor1Data = new System.Windows.Forms.DataGridView();
			this.Sensor1Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1BendingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X1Before = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X2Before = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X1After = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X2After = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X1Delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor1X2Delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2Data = new System.Windows.Forms.DataGridView();
			this.Sensor2Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X1Before = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X2Before = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X1After = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X2After = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X1Delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2X2Delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensor2BendingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StatusPanel = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.Robot2Status = new System.Windows.Forms.Label();
			this.Robot1Status = new System.Windows.Forms.Label();
			this.Sensor2Status = new System.Windows.Forms.Label();
			this.Sensor1Status = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.LeftDoorImage = new System.Windows.Forms.PictureBox();
			this.RightDoorImage = new System.Windows.Forms.PictureBox();
			this.RobotPhase = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.Robot2PhaseGroup = new System.Windows.Forms.GroupBox();
			this.Robot2PhasePanel = new System.Windows.Forms.TableLayoutPanel();
			this.Robot2PhaseText = new System.Windows.Forms.TextBox();
			this.Robot2PhaseImage = new System.Windows.Forms.PictureBox();
			this.Robot1PhaseGroup = new System.Windows.Forms.GroupBox();
			this.Robot1PhasePanel = new System.Windows.Forms.TableLayoutPanel();
			this.Robot1PhaseImage = new System.Windows.Forms.PictureBox();
			this.Robot1PhaseText = new System.Windows.Forms.TextBox();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.StatisticsChartArea = new System.Windows.Forms.TableLayoutPanel();
			this.SensorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.Stats2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Stats1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ByPass = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.BypassToggle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.Configuration = new System.Windows.Forms.TabPage();
			this.ConfigPanel = new System.Windows.Forms.TableLayoutPanel();
			this.BiasConfig = new System.Windows.Forms.GroupBox();
			this.BiasConfigPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Sensor2X1Offset = new System.Windows.Forms.NumericUpDown();
			this.Sensor2X2Offset = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Sensor1X1Offset = new System.Windows.Forms.NumericUpDown();
			this.Sensor1X2Offset = new System.Windows.Forms.NumericUpDown();
			this.SaveOffset = new System.Windows.Forms.Button();
			this.FileConfig = new System.Windows.Forms.GroupBox();
			this.FileSaveConfig = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
			this.AutoSaveApply = new System.Windows.Forms.Button();
			this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
			this.AutoSaveDirectory = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.EnableAutoSave = new System.Windows.Forms.Button();
			this.AutoSaveInterval = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
			this.SaveNow = new System.Windows.Forms.Button();
			this.NetworkConfig = new System.Windows.Forms.GroupBox();
			this.SocketsConfig = new System.Windows.Forms.TableLayoutPanel();
			this.DbConnectionConfig = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
			this.DbConnectionSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
			this.DbIpAddress = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.DbConnectionStatus = new System.Windows.Forms.Label();
			this.RobotConnectionConfig = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
			this.Robot2IpAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
			this.Robot1IpAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.RobotConnectionSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
			this.RobotServerPort = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.SensorConnectionConfig = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
			this.Sensor2IpAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.Sensor1IpAddress = new System.Windows.Forms.TextBox();
			this.Sensor1ConnectionStatus = new System.Windows.Forms.Label();
			this.Sensor2ConnectionStatus = new System.Windows.Forms.Label();
			this.Logs = new System.Windows.Forms.TabPage();
			this.LogConsole = new System.Windows.Forms.TextBox();
			this.Diagnostics = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
			this.SensorPingData = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.PassDiag = new System.Windows.Forms.Button();
			this.NgDiag = new System.Windows.Forms.Button();
			this.BPassDiag = new System.Windows.Forms.Button();
			this.BNgDiag = new System.Windows.Forms.Button();
			this.PcStatusDiag = new System.Windows.Forms.Button();
			this.PcCommErrorDiag = new System.Windows.Forms.Button();
			this.SensorStatusDiag = new System.Windows.Forms.Button();
			this.SensorDataStatusDiag = new System.Windows.Forms.Button();
			this.BypassDiag = new System.Windows.Forms.Button();
			this.GlobalFormLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.Exit = new System.Windows.Forms.Button();
			this.TitleBar = new System.Windows.Forms.Label();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.TabMenu.SuspendLayout();
			this.Main.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).BeginInit();
			this.StatusPanel.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeftDoorImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RightDoorImage)).BeginInit();
			this.RobotPhase.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.Robot2PhaseGroup.SuspendLayout();
			this.Robot2PhasePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Robot2PhaseImage)).BeginInit();
			this.Robot1PhaseGroup.SuspendLayout();
			this.Robot1PhasePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Robot1PhaseImage)).BeginInit();
			this.Statistics.SuspendLayout();
			this.StatisticsChartArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).BeginInit();
			this.tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Stats2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats1)).BeginInit();
			this.ByPass.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.Configuration.SuspendLayout();
			this.ConfigPanel.SuspendLayout();
			this.BiasConfig.SuspendLayout();
			this.BiasConfigPanel.SuspendLayout();
			this.tableLayoutPanel17.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tableLayoutPanel25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2X1Offset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2X2Offset)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1X1Offset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1X2Offset)).BeginInit();
			this.FileConfig.SuspendLayout();
			this.FileSaveConfig.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel21.SuspendLayout();
			this.tableLayoutPanel22.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel23.SuspendLayout();
			this.NetworkConfig.SuspendLayout();
			this.SocketsConfig.SuspendLayout();
			this.DbConnectionConfig.SuspendLayout();
			this.tableLayoutPanel16.SuspendLayout();
			this.tableLayoutPanel18.SuspendLayout();
			this.RobotConnectionConfig.SuspendLayout();
			this.tableLayoutPanel12.SuspendLayout();
			this.tableLayoutPanel14.SuspendLayout();
			this.tableLayoutPanel15.SuspendLayout();
			this.tableLayoutPanel26.SuspendLayout();
			this.SensorConnectionConfig.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.tableLayoutPanel13.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.Logs.SuspendLayout();
			this.Diagnostics.SuspendLayout();
			this.tableLayoutPanel27.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.GlobalFormLayout.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// TabMenu
			// 
			this.TabMenu.Controls.Add(this.Main);
			this.TabMenu.Controls.Add(this.RobotPhase);
			this.TabMenu.Controls.Add(this.Statistics);
			this.TabMenu.Controls.Add(this.ByPass);
			this.TabMenu.Controls.Add(this.Configuration);
			this.TabMenu.Controls.Add(this.Logs);
			this.TabMenu.Controls.Add(this.Diagnostics);
			this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMenu.ItemSize = new System.Drawing.Size(180, 50);
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
			this.Main.Location = new System.Drawing.Point(4, 54);
			this.Main.Margin = new System.Windows.Forms.Padding(0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(1272, 702);
			this.Main.TabIndex = 0;
			this.Main.Text = "Main";
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
			// Sensor1Data
			// 
			this.Sensor1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor1Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sensor1Time,
            this.Sensor1BendingStatus,
            this.Sensor1X1Before,
            this.Sensor1X2Before,
            this.Sensor1X1After,
            this.Sensor1X2After,
            this.Sensor1X1Delta,
            this.Sensor1X2Delta});
			this.Sensor1Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor1Data.Location = new System.Drawing.Point(2, 2);
			this.Sensor1Data.Margin = new System.Windows.Forms.Padding(2);
			this.Sensor1Data.Name = "Sensor1Data";
			this.Sensor1Data.RowHeadersWidth = 51;
			this.Sensor1Data.RowTemplate.Height = 27;
			this.Sensor1Data.Size = new System.Drawing.Size(504, 347);
			this.Sensor1Data.TabIndex = 0;
			// 
			// Sensor1Time
			// 
			this.Sensor1Time.HeaderText = "Time";
			this.Sensor1Time.MinimumWidth = 6;
			this.Sensor1Time.Name = "Sensor1Time";
			this.Sensor1Time.Width = 125;
			// 
			// Sensor1BendingStatus
			// 
			this.Sensor1BendingStatus.HeaderText = "Status";
			this.Sensor1BendingStatus.MinimumWidth = 6;
			this.Sensor1BendingStatus.Name = "Sensor1BendingStatus";
			this.Sensor1BendingStatus.Width = 125;
			// 
			// Sensor1X1Before
			// 
			this.Sensor1X1Before.HeaderText = "X1 Before";
			this.Sensor1X1Before.MinimumWidth = 6;
			this.Sensor1X1Before.Name = "Sensor1X1Before";
			this.Sensor1X1Before.Width = 125;
			// 
			// Sensor1X2Before
			// 
			this.Sensor1X2Before.HeaderText = "X2 Before";
			this.Sensor1X2Before.MinimumWidth = 6;
			this.Sensor1X2Before.Name = "Sensor1X2Before";
			this.Sensor1X2Before.Width = 125;
			// 
			// Sensor1X1After
			// 
			this.Sensor1X1After.HeaderText = "X1 After";
			this.Sensor1X1After.MinimumWidth = 6;
			this.Sensor1X1After.Name = "Sensor1X1After";
			this.Sensor1X1After.Width = 125;
			// 
			// Sensor1X2After
			// 
			this.Sensor1X2After.HeaderText = "X2 After";
			this.Sensor1X2After.MinimumWidth = 6;
			this.Sensor1X2After.Name = "Sensor1X2After";
			this.Sensor1X2After.Width = 125;
			// 
			// Sensor1X1Delta
			// 
			this.Sensor1X1Delta.HeaderText = "X1 Delta";
			this.Sensor1X1Delta.MinimumWidth = 6;
			this.Sensor1X1Delta.Name = "Sensor1X1Delta";
			this.Sensor1X1Delta.Width = 125;
			// 
			// Sensor1X2Delta
			// 
			this.Sensor1X2Delta.HeaderText = "X2 Delta";
			this.Sensor1X2Delta.MinimumWidth = 6;
			this.Sensor1X2Delta.Name = "Sensor1X2Delta";
			this.Sensor1X2Delta.Width = 125;
			// 
			// Sensor2Data
			// 
			this.Sensor2Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Sensor2Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sensor2Time,
            this.Sensor2X1Before,
            this.Sensor2X2Before,
            this.Sensor2X1After,
            this.Sensor2X2After,
            this.Sensor2X1Delta,
            this.Sensor2X2Delta,
            this.Sensor2BendingStatus});
			this.Sensor2Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor2Data.Location = new System.Drawing.Point(2, 353);
			this.Sensor2Data.Margin = new System.Windows.Forms.Padding(2);
			this.Sensor2Data.Name = "Sensor2Data";
			this.Sensor2Data.RowHeadersWidth = 51;
			this.Sensor2Data.RowTemplate.Height = 27;
			this.Sensor2Data.Size = new System.Drawing.Size(504, 347);
			this.Sensor2Data.TabIndex = 1;
			// 
			// Sensor2Time
			// 
			this.Sensor2Time.HeaderText = "Time";
			this.Sensor2Time.MinimumWidth = 6;
			this.Sensor2Time.Name = "Sensor2Time";
			this.Sensor2Time.Width = 125;
			// 
			// Sensor2X1Before
			// 
			this.Sensor2X1Before.HeaderText = "X1 Before";
			this.Sensor2X1Before.MinimumWidth = 6;
			this.Sensor2X1Before.Name = "Sensor2X1Before";
			this.Sensor2X1Before.Width = 125;
			// 
			// Sensor2X2Before
			// 
			this.Sensor2X2Before.HeaderText = "X2 Before";
			this.Sensor2X2Before.MinimumWidth = 6;
			this.Sensor2X2Before.Name = "Sensor2X2Before";
			this.Sensor2X2Before.Width = 125;
			// 
			// Sensor2X1After
			// 
			this.Sensor2X1After.HeaderText = "X1 After";
			this.Sensor2X1After.MinimumWidth = 6;
			this.Sensor2X1After.Name = "Sensor2X1After";
			this.Sensor2X1After.Width = 125;
			// 
			// Sensor2X2After
			// 
			this.Sensor2X2After.HeaderText = "X2 After";
			this.Sensor2X2After.MinimumWidth = 6;
			this.Sensor2X2After.Name = "Sensor2X2After";
			this.Sensor2X2After.Width = 125;
			// 
			// Sensor2X1Delta
			// 
			this.Sensor2X1Delta.HeaderText = "X1 Delta";
			this.Sensor2X1Delta.MinimumWidth = 6;
			this.Sensor2X1Delta.Name = "Sensor2X1Delta";
			this.Sensor2X1Delta.Width = 125;
			// 
			// Sensor2X2Delta
			// 
			this.Sensor2X2Delta.HeaderText = "X2 Delta";
			this.Sensor2X2Delta.MinimumWidth = 6;
			this.Sensor2X2Delta.Name = "Sensor2X2Delta";
			this.Sensor2X2Delta.Width = 125;
			// 
			// Sensor2BendingStatus
			// 
			this.Sensor2BendingStatus.HeaderText = "Status";
			this.Sensor2BendingStatus.MinimumWidth = 6;
			this.Sensor2BendingStatus.Name = "Sensor2BendingStatus";
			this.Sensor2BendingStatus.Width = 125;
			// 
			// StatusPanel
			// 
			this.StatusPanel.Controls.Add(this.tableLayoutPanel8);
			this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusPanel.Location = new System.Drawing.Point(1016, 0);
			this.StatusPanel.Margin = new System.Windows.Forms.Padding(0);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Padding = new System.Windows.Forms.Padding(2);
			this.StatusPanel.Size = new System.Drawing.Size(256, 702);
			this.StatusPanel.TabIndex = 2;
			this.StatusPanel.TabStop = false;
			this.StatusPanel.Text = "Connection Status";
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Controls.Add(this.Robot2Status, 0, 3);
			this.tableLayoutPanel8.Controls.Add(this.Robot1Status, 0, 2);
			this.tableLayoutPanel8.Controls.Add(this.Sensor2Status, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.Sensor1Status, 0, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 25);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 10;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(252, 675);
			this.tableLayoutPanel8.TabIndex = 0;
			// 
			// Robot2Status
			// 
			this.Robot2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot2Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot2Status.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Robot2Status.ForeColor = System.Drawing.Color.White;
			this.Robot2Status.Location = new System.Drawing.Point(3, 204);
			this.Robot2Status.Margin = new System.Windows.Forms.Padding(3);
			this.Robot2Status.Name = "Robot2Status";
			this.Robot2Status.Size = new System.Drawing.Size(246, 61);
			this.Robot2Status.TabIndex = 16;
			this.Robot2Status.Text = "Robot 2";
			this.Robot2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Robot1Status
			// 
			this.Robot1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot1Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot1Status.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Robot1Status.ForeColor = System.Drawing.Color.White;
			this.Robot1Status.Location = new System.Drawing.Point(3, 137);
			this.Robot1Status.Margin = new System.Windows.Forms.Padding(3);
			this.Robot1Status.Name = "Robot1Status";
			this.Robot1Status.Size = new System.Drawing.Size(246, 61);
			this.Robot1Status.TabIndex = 15;
			this.Robot1Status.Text = "Robot 1";
			this.Robot1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor2Status
			// 
			this.Sensor2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor2Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor2Status.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2Status.ForeColor = System.Drawing.Color.White;
			this.Sensor2Status.Location = new System.Drawing.Point(3, 70);
			this.Sensor2Status.Margin = new System.Windows.Forms.Padding(3);
			this.Sensor2Status.Name = "Sensor2Status";
			this.Sensor2Status.Size = new System.Drawing.Size(246, 61);
			this.Sensor2Status.TabIndex = 14;
			this.Sensor2Status.Text = "Sensor 2";
			this.Sensor2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor1Status
			// 
			this.Sensor1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor1Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor1Status.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1Status.ForeColor = System.Drawing.Color.White;
			this.Sensor1Status.Location = new System.Drawing.Point(3, 3);
			this.Sensor1Status.Margin = new System.Windows.Forms.Padding(3);
			this.Sensor1Status.Name = "Sensor1Status";
			this.Sensor1Status.Size = new System.Drawing.Size(246, 61);
			this.Sensor1Status.TabIndex = 13;
			this.Sensor1Status.Text = "Sensor 1";
			this.Sensor1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.LeftDoorImage, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.RightDoorImage, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(508, 702);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// LeftDoorImage
			// 
			this.LeftDoorImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LeftDoorImage.Image = ((System.Drawing.Image)(resources.GetObject("LeftDoorImage.Image")));
			this.LeftDoorImage.Location = new System.Drawing.Point(2, 2);
			this.LeftDoorImage.Margin = new System.Windows.Forms.Padding(2);
			this.LeftDoorImage.Name = "LeftDoorImage";
			this.LeftDoorImage.Size = new System.Drawing.Size(504, 347);
			this.LeftDoorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.LeftDoorImage.TabIndex = 0;
			this.LeftDoorImage.TabStop = false;
			// 
			// RightDoorImage
			// 
			this.RightDoorImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightDoorImage.Image = ((System.Drawing.Image)(resources.GetObject("RightDoorImage.Image")));
			this.RightDoorImage.Location = new System.Drawing.Point(2, 353);
			this.RightDoorImage.Margin = new System.Windows.Forms.Padding(2);
			this.RightDoorImage.Name = "RightDoorImage";
			this.RightDoorImage.Size = new System.Drawing.Size(504, 347);
			this.RightDoorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.RightDoorImage.TabIndex = 1;
			this.RightDoorImage.TabStop = false;
			// 
			// RobotPhase
			// 
			this.RobotPhase.Controls.Add(this.tableLayoutPanel9);
			this.RobotPhase.Location = new System.Drawing.Point(4, 54);
			this.RobotPhase.Name = "RobotPhase";
			this.RobotPhase.Padding = new System.Windows.Forms.Padding(3);
			this.RobotPhase.Size = new System.Drawing.Size(1272, 702);
			this.RobotPhase.TabIndex = 5;
			this.RobotPhase.Text = "Robot Phase";
			this.RobotPhase.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel9.Controls.Add(this.Robot2PhaseGroup, 1, 0);
			this.tableLayoutPanel9.Controls.Add(this.Robot1PhaseGroup, 0, 0);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 1;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 696F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(1266, 696);
			this.tableLayoutPanel9.TabIndex = 0;
			// 
			// Robot2PhaseGroup
			// 
			this.Robot2PhaseGroup.Controls.Add(this.Robot2PhasePanel);
			this.Robot2PhaseGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot2PhaseGroup.Location = new System.Drawing.Point(637, 4);
			this.Robot2PhaseGroup.Margin = new System.Windows.Forms.Padding(4);
			this.Robot2PhaseGroup.Name = "Robot2PhaseGroup";
			this.Robot2PhaseGroup.Padding = new System.Windows.Forms.Padding(0);
			this.Robot2PhaseGroup.Size = new System.Drawing.Size(625, 688);
			this.Robot2PhaseGroup.TabIndex = 1;
			this.Robot2PhaseGroup.TabStop = false;
			this.Robot2PhaseGroup.Text = "Robot 2";
			// 
			// Robot2PhasePanel
			// 
			this.Robot2PhasePanel.ColumnCount = 1;
			this.Robot2PhasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Robot2PhasePanel.Controls.Add(this.Robot2PhaseText, 0, 1);
			this.Robot2PhasePanel.Controls.Add(this.Robot2PhaseImage, 0, 0);
			this.Robot2PhasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot2PhasePanel.Location = new System.Drawing.Point(0, 23);
			this.Robot2PhasePanel.Margin = new System.Windows.Forms.Padding(0);
			this.Robot2PhasePanel.Name = "Robot2PhasePanel";
			this.Robot2PhasePanel.RowCount = 2;
			this.Robot2PhasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.Robot2PhasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.Robot2PhasePanel.Size = new System.Drawing.Size(625, 665);
			this.Robot2PhasePanel.TabIndex = 1;
			// 
			// Robot2PhaseText
			// 
			this.Robot2PhaseText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot2PhaseText.Location = new System.Drawing.Point(4, 536);
			this.Robot2PhaseText.Margin = new System.Windows.Forms.Padding(4);
			this.Robot2PhaseText.Multiline = true;
			this.Robot2PhaseText.Name = "Robot2PhaseText";
			this.Robot2PhaseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Robot2PhaseText.Size = new System.Drawing.Size(617, 125);
			this.Robot2PhaseText.TabIndex = 2;
			// 
			// Robot2PhaseImage
			// 
			this.Robot2PhaseImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot2PhaseImage.Location = new System.Drawing.Point(4, 4);
			this.Robot2PhaseImage.Margin = new System.Windows.Forms.Padding(4);
			this.Robot2PhaseImage.Name = "Robot2PhaseImage";
			this.Robot2PhaseImage.Size = new System.Drawing.Size(617, 524);
			this.Robot2PhaseImage.TabIndex = 1;
			this.Robot2PhaseImage.TabStop = false;
			// 
			// Robot1PhaseGroup
			// 
			this.Robot1PhaseGroup.Controls.Add(this.Robot1PhasePanel);
			this.Robot1PhaseGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot1PhaseGroup.Location = new System.Drawing.Point(4, 4);
			this.Robot1PhaseGroup.Margin = new System.Windows.Forms.Padding(4);
			this.Robot1PhaseGroup.Name = "Robot1PhaseGroup";
			this.Robot1PhaseGroup.Padding = new System.Windows.Forms.Padding(0);
			this.Robot1PhaseGroup.Size = new System.Drawing.Size(625, 688);
			this.Robot1PhaseGroup.TabIndex = 0;
			this.Robot1PhaseGroup.TabStop = false;
			this.Robot1PhaseGroup.Text = "Robot 1";
			// 
			// Robot1PhasePanel
			// 
			this.Robot1PhasePanel.ColumnCount = 1;
			this.Robot1PhasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Robot1PhasePanel.Controls.Add(this.Robot1PhaseImage, 0, 0);
			this.Robot1PhasePanel.Controls.Add(this.Robot1PhaseText, 0, 1);
			this.Robot1PhasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot1PhasePanel.Location = new System.Drawing.Point(0, 23);
			this.Robot1PhasePanel.Margin = new System.Windows.Forms.Padding(0);
			this.Robot1PhasePanel.Name = "Robot1PhasePanel";
			this.Robot1PhasePanel.RowCount = 2;
			this.Robot1PhasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.Robot1PhasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.Robot1PhasePanel.Size = new System.Drawing.Size(625, 665);
			this.Robot1PhasePanel.TabIndex = 0;
			// 
			// Robot1PhaseImage
			// 
			this.Robot1PhaseImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot1PhaseImage.Location = new System.Drawing.Point(4, 4);
			this.Robot1PhaseImage.Margin = new System.Windows.Forms.Padding(4);
			this.Robot1PhaseImage.Name = "Robot1PhaseImage";
			this.Robot1PhaseImage.Size = new System.Drawing.Size(617, 524);
			this.Robot1PhaseImage.TabIndex = 0;
			this.Robot1PhaseImage.TabStop = false;
			// 
			// Robot1PhaseText
			// 
			this.Robot1PhaseText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Robot1PhaseText.Location = new System.Drawing.Point(4, 536);
			this.Robot1PhaseText.Margin = new System.Windows.Forms.Padding(4);
			this.Robot1PhaseText.Multiline = true;
			this.Robot1PhaseText.Name = "Robot1PhaseText";
			this.Robot1PhaseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Robot1PhaseText.Size = new System.Drawing.Size(617, 125);
			this.Robot1PhaseText.TabIndex = 1;
			// 
			// Statistics
			// 
			this.Statistics.BackColor = System.Drawing.Color.White;
			this.Statistics.Controls.Add(this.StatisticsChartArea);
			this.Statistics.Location = new System.Drawing.Point(4, 54);
			this.Statistics.Margin = new System.Windows.Forms.Padding(2);
			this.Statistics.Name = "Statistics";
			this.Statistics.Size = new System.Drawing.Size(1272, 702);
			this.Statistics.TabIndex = 2;
			this.Statistics.Text = "Stats";
			// 
			// StatisticsChartArea
			// 
			this.StatisticsChartArea.ColumnCount = 1;
			this.StatisticsChartArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.StatisticsChartArea.Controls.Add(this.SensorChart, 0, 0);
			this.StatisticsChartArea.Controls.Add(this.tableLayoutPanel7, 0, 1);
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
			this.SensorChart.Enabled = false;
			legend1.DockedToChartArea = "Sensor1";
			legend1.IsDockedInsideChartArea = false;
			legend1.Name = "Sensor1";
			legend1.Title = "Sensor 1";
			legend2.DockedToChartArea = "Sensor2";
			legend2.IsDockedInsideChartArea = false;
			legend2.Name = "Sensor2";
			legend2.Title = "Sensor 2";
			legend3.DockedToChartArea = "Delta";
			legend3.IsDockedInsideChartArea = false;
			legend3.Name = "Delta";
			legend3.Title = "Delta";
			legend4.Enabled = false;
			legend4.Name = "Hidden";
			this.SensorChart.Legends.Add(legend1);
			this.SensorChart.Legends.Add(legend2);
			this.SensorChart.Legends.Add(legend3);
			this.SensorChart.Legends.Add(legend4);
			this.SensorChart.Location = new System.Drawing.Point(0, 0);
			this.SensorChart.Margin = new System.Windows.Forms.Padding(0);
			this.SensorChart.Name = "SensorChart";
			series1.ChartArea = "Sensor1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series1.Color = System.Drawing.Color.SeaGreen;
			series1.Legend = "Sensor1";
			series1.LegendText = "Before";
			series1.Name = "Sensor1Before";
			series2.ChartArea = "Sensor1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series2.Color = System.Drawing.Color.Orange;
			series2.Legend = "Sensor1";
			series2.LegendText = "After";
			series2.Name = "Sensor1After";
			series3.BorderWidth = 3;
			series3.ChartArea = "Sensor1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series3.Color = System.Drawing.Color.OrangeRed;
			series3.Legend = "Hidden";
			series3.Name = "Sensor1MaxPlus";
			series4.BorderWidth = 3;
			series4.ChartArea = "Sensor1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series4.Color = System.Drawing.Color.OrangeRed;
			series4.Legend = "Hidden";
			series4.Name = "Sensor1MaxMinus";
			series5.BorderWidth = 3;
			series5.ChartArea = "Sensor1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series5.Color = System.Drawing.Color.RoyalBlue;
			series5.Legend = "Hidden";
			series5.Name = "Sensor1MinPlus";
			series6.BorderWidth = 3;
			series6.ChartArea = "Sensor1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series6.Color = System.Drawing.Color.RoyalBlue;
			series6.Legend = "Hidden";
			series6.Name = "Sensor1MinMinus";
			series7.ChartArea = "Sensor2";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series7.Color = System.Drawing.Color.SeaGreen;
			series7.Legend = "Sensor2";
			series7.LegendText = "Before";
			series7.Name = "Sensor2Before";
			series8.ChartArea = "Sensor2";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series8.Color = System.Drawing.Color.Orange;
			series8.Legend = "Sensor2";
			series8.LegendText = "After";
			series8.Name = "Sensor2After";
			series9.BorderWidth = 3;
			series9.ChartArea = "Sensor2";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series9.Color = System.Drawing.Color.OrangeRed;
			series9.Legend = "Hidden";
			series9.Name = "Sensor2MaxPlus";
			series10.BorderWidth = 3;
			series10.ChartArea = "Sensor2";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series10.Color = System.Drawing.Color.OrangeRed;
			series10.Legend = "Hidden";
			series10.Name = "Sensor2MaxMinus";
			series11.BorderWidth = 3;
			series11.ChartArea = "Sensor2";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series11.Color = System.Drawing.Color.RoyalBlue;
			series11.Legend = "Hidden";
			series11.Name = "Sensor2MinPlus";
			series12.BorderWidth = 3;
			series12.ChartArea = "Sensor2";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series12.Color = System.Drawing.Color.RoyalBlue;
			series12.Legend = "Hidden";
			series12.Name = "Sensor2MinMinus";
			series13.ChartArea = "Delta";
			series13.Color = System.Drawing.Color.RoyalBlue;
			series13.Legend = "Delta";
			series13.LegendText = "Sensor1";
			series13.Name = "Sensor1Delta";
			series14.ChartArea = "Delta";
			series14.Color = System.Drawing.Color.Orange;
			series14.Legend = "Delta";
			series14.LegendText = "Sensor2";
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
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel7.Controls.Add(this.Stats2, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.Stats1, 0, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 421);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(1272, 281);
			this.tableLayoutPanel7.TabIndex = 1;
			// 
			// Stats2
			// 
			chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea4.Name = "StatsArea";
			this.Stats2.ChartAreas.Add(chartArea4);
			this.Stats2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Stats2.Enabled = false;
			legend5.Alignment = System.Drawing.StringAlignment.Center;
			legend5.DockedToChartArea = "StatsArea";
			legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend5.IsDockedInsideChartArea = false;
			legend5.Name = "StatsLegend";
			this.Stats2.Legends.Add(legend5);
			this.Stats2.Location = new System.Drawing.Point(636, 0);
			this.Stats2.Margin = new System.Windows.Forms.Padding(0);
			this.Stats2.Name = "Stats2";
			this.Stats2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			series15.ChartArea = "StatsArea";
			series15.Color = System.Drawing.Color.SteelBlue;
			series15.Legend = "StatsLegend";
			series15.LegendText = "1st Bending";
			series15.Name = "FirstBended";
			series16.ChartArea = "StatsArea";
			series16.Color = System.Drawing.Color.CornflowerBlue;
			series16.Legend = "StatsLegend";
			series16.LegendText = "2nd Bending";
			series16.Name = "SecondBended";
			this.Stats2.Series.Add(series15);
			this.Stats2.Series.Add(series16);
			this.Stats2.Size = new System.Drawing.Size(636, 281);
			this.Stats2.TabIndex = 3;
			this.Stats2.Text = "chart2";
			// 
			// Stats1
			// 
			chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
			chartArea5.Name = "StatsArea";
			this.Stats1.ChartAreas.Add(chartArea5);
			this.Stats1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Stats1.Enabled = false;
			legend6.Alignment = System.Drawing.StringAlignment.Center;
			legend6.DockedToChartArea = "StatsArea";
			legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend6.IsDockedInsideChartArea = false;
			legend6.Name = "StatsLegend";
			this.Stats1.Legends.Add(legend6);
			this.Stats1.Location = new System.Drawing.Point(0, 0);
			this.Stats1.Margin = new System.Windows.Forms.Padding(0);
			this.Stats1.Name = "Stats1";
			this.Stats1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			series17.ChartArea = "StatsArea";
			series17.Color = System.Drawing.Color.OrangeRed;
			series17.Legend = "StatsLegend";
			series17.LegendText = "Failed";
			series17.Name = "Failed";
			series18.ChartArea = "StatsArea";
			series18.Color = System.Drawing.Color.RoyalBlue;
			series18.Legend = "StatsLegend";
			series18.LegendText = "Passed";
			series18.Name = "Passed";
			this.Stats1.Series.Add(series17);
			this.Stats1.Series.Add(series18);
			this.Stats1.Size = new System.Drawing.Size(636, 281);
			this.Stats1.TabIndex = 2;
			this.Stats1.Text = "chart2";
			// 
			// ByPass
			// 
			this.ByPass.BackColor = System.Drawing.Color.White;
			this.ByPass.Controls.Add(this.tableLayoutPanel5);
			this.ByPass.Location = new System.Drawing.Point(4, 54);
			this.ByPass.Margin = new System.Windows.Forms.Padding(0);
			this.ByPass.Name = "ByPass";
			this.ByPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ByPass.Size = new System.Drawing.Size(1272, 702);
			this.ByPass.TabIndex = 3;
			this.ByPass.Text = "BYPASS";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(1272, 702);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Controls.Add(this.BypassToggle, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(424, 234);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(424, 234);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// BypassToggle
			// 
			this.BypassToggle.BackColor = System.Drawing.Color.DarkGray;
			this.BypassToggle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BypassToggle.FlatAppearance.BorderSize = 0;
			this.BypassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BypassToggle.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.BypassToggle.Location = new System.Drawing.Point(4, 167);
			this.BypassToggle.Margin = new System.Windows.Forms.Padding(4);
			this.BypassToggle.Name = "BypassToggle";
			this.BypassToggle.Size = new System.Drawing.Size(416, 63);
			this.BypassToggle.TabIndex = 1;
			this.BypassToggle.Text = "DISABLED";
			this.BypassToggle.UseVisualStyleBackColor = false;
			this.BypassToggle.Click += new System.EventHandler(this.BypassToggle_Click);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(4, 4);
			this.label5.Margin = new System.Windows.Forms.Padding(4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(416, 155);
			this.label5.TabIndex = 1;
			this.label5.Text = "BYPASS MODE";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Configuration
			// 
			this.Configuration.BackColor = System.Drawing.Color.White;
			this.Configuration.Controls.Add(this.ConfigPanel);
			this.Configuration.Location = new System.Drawing.Point(4, 54);
			this.Configuration.Margin = new System.Windows.Forms.Padding(0);
			this.Configuration.Name = "Configuration";
			this.Configuration.Size = new System.Drawing.Size(1272, 702);
			this.Configuration.TabIndex = 1;
			this.Configuration.Text = "Config";
			// 
			// ConfigPanel
			// 
			this.ConfigPanel.ColumnCount = 3;
			this.ConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ConfigPanel.Controls.Add(this.BiasConfig, 2, 0);
			this.ConfigPanel.Controls.Add(this.FileConfig, 1, 0);
			this.ConfigPanel.Controls.Add(this.NetworkConfig, 0, 0);
			this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConfigPanel.Location = new System.Drawing.Point(0, 0);
			this.ConfigPanel.Margin = new System.Windows.Forms.Padding(0);
			this.ConfigPanel.Name = "ConfigPanel";
			this.ConfigPanel.RowCount = 1;
			this.ConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ConfigPanel.Size = new System.Drawing.Size(1272, 702);
			this.ConfigPanel.TabIndex = 0;
			// 
			// BiasConfig
			// 
			this.BiasConfig.Controls.Add(this.BiasConfigPanel);
			this.BiasConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BiasConfig.Location = new System.Drawing.Point(852, 4);
			this.BiasConfig.Margin = new System.Windows.Forms.Padding(4);
			this.BiasConfig.Name = "BiasConfig";
			this.BiasConfig.Padding = new System.Windows.Forms.Padding(4);
			this.BiasConfig.Size = new System.Drawing.Size(416, 694);
			this.BiasConfig.TabIndex = 2;
			this.BiasConfig.TabStop = false;
			this.BiasConfig.Text = "Offset";
			// 
			// BiasConfigPanel
			// 
			this.BiasConfigPanel.ColumnCount = 1;
			this.BiasConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.BiasConfigPanel.Controls.Add(this.tableLayoutPanel17, 0, 0);
			this.BiasConfigPanel.Controls.Add(this.SaveOffset, 0, 1);
			this.BiasConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BiasConfigPanel.Location = new System.Drawing.Point(4, 27);
			this.BiasConfigPanel.Margin = new System.Windows.Forms.Padding(4);
			this.BiasConfigPanel.Name = "BiasConfigPanel";
			this.BiasConfigPanel.RowCount = 2;
			this.BiasConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.BiasConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.BiasConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.BiasConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.BiasConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.BiasConfigPanel.Size = new System.Drawing.Size(408, 663);
			this.BiasConfigPanel.TabIndex = 0;
			// 
			// tableLayoutPanel17
			// 
			this.tableLayoutPanel17.ColumnCount = 1;
			this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel17.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel17.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel17.Name = "tableLayoutPanel17";
			this.tableLayoutPanel17.RowCount = 2;
			this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel17.Size = new System.Drawing.Size(408, 596);
			this.tableLayoutPanel17.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel20);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(4, 302);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(400, 290);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sensor 2";
			// 
			// tableLayoutPanel20
			// 
			this.tableLayoutPanel20.ColumnCount = 2;
			this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel20.Controls.Add(this.pictureBox2, 0, 0);
			this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel25, 1, 0);
			this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel20.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel20.Name = "tableLayoutPanel20";
			this.tableLayoutPanel20.Padding = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel20.RowCount = 1;
			this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel20.Size = new System.Drawing.Size(392, 259);
			this.tableLayoutPanel20.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(4, 4);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(192, 251);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// tableLayoutPanel25
			// 
			this.tableLayoutPanel25.ColumnCount = 2;
			this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel25.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel25.Controls.Add(this.label9, 0, 1);
			this.tableLayoutPanel25.Controls.Add(this.Sensor2X1Offset, 1, 0);
			this.tableLayoutPanel25.Controls.Add(this.Sensor2X2Offset, 1, 1);
			this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel25.Location = new System.Drawing.Point(199, 7);
			this.tableLayoutPanel25.Name = "tableLayoutPanel25";
			this.tableLayoutPanel25.RowCount = 2;
			this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel25.Size = new System.Drawing.Size(186, 245);
			this.tableLayoutPanel25.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 122);
			this.label8.TabIndex = 0;
			this.label8.Text = "X1";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(0, 122);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 123);
			this.label9.TabIndex = 1;
			this.label9.Text = "X2";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor2X1Offset
			// 
			this.Sensor2X1Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor2X1Offset.DecimalPlaces = 2;
			this.Sensor2X1Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.Sensor2X1Offset.Location = new System.Drawing.Point(74, 46);
			this.Sensor2X1Offset.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor2X1Offset.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            65536});
			this.Sensor2X1Offset.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147418112});
			this.Sensor2X1Offset.Name = "Sensor2X1Offset";
			this.Sensor2X1Offset.Size = new System.Drawing.Size(112, 30);
			this.Sensor2X1Offset.TabIndex = 1;
			this.Sensor2X1Offset.ValueChanged += new System.EventHandler(this.Sensor2X1Offset_ValueChanged);
			// 
			// Sensor2X2Offset
			// 
			this.Sensor2X2Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor2X2Offset.DecimalPlaces = 2;
			this.Sensor2X2Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.Sensor2X2Offset.Location = new System.Drawing.Point(74, 168);
			this.Sensor2X2Offset.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor2X2Offset.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            65536});
			this.Sensor2X2Offset.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147418112});
			this.Sensor2X2Offset.Name = "Sensor2X2Offset";
			this.Sensor2X2Offset.Size = new System.Drawing.Size(112, 30);
			this.Sensor2X2Offset.TabIndex = 1;
			this.Sensor2X2Offset.ValueChanged += new System.EventHandler(this.Sensor2X2Offset_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel19);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(4, 4);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(400, 290);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sensor 1";
			// 
			// tableLayoutPanel19
			// 
			this.tableLayoutPanel19.ColumnCount = 2;
			this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel19.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel24, 1, 0);
			this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel19.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel19.Name = "tableLayoutPanel19";
			this.tableLayoutPanel19.Padding = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel19.RowCount = 1;
			this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel19.Size = new System.Drawing.Size(392, 259);
			this.tableLayoutPanel19.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(192, 251);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel24
			// 
			this.tableLayoutPanel24.ColumnCount = 2;
			this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel24.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel24.Controls.Add(this.label7, 0, 1);
			this.tableLayoutPanel24.Controls.Add(this.Sensor1X1Offset, 1, 0);
			this.tableLayoutPanel24.Controls.Add(this.Sensor1X2Offset, 1, 1);
			this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel24.Location = new System.Drawing.Point(199, 7);
			this.tableLayoutPanel24.Name = "tableLayoutPanel24";
			this.tableLayoutPanel24.RowCount = 2;
			this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel24.Size = new System.Drawing.Size(186, 245);
			this.tableLayoutPanel24.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 122);
			this.label6.TabIndex = 0;
			this.label6.Text = "X1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(0, 122);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 123);
			this.label7.TabIndex = 0;
			this.label7.Text = "X2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor1X1Offset
			// 
			this.Sensor1X1Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor1X1Offset.DecimalPlaces = 2;
			this.Sensor1X1Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.Sensor1X1Offset.Location = new System.Drawing.Point(74, 46);
			this.Sensor1X1Offset.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor1X1Offset.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            65536});
			this.Sensor1X1Offset.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147418112});
			this.Sensor1X1Offset.Name = "Sensor1X1Offset";
			this.Sensor1X1Offset.Size = new System.Drawing.Size(112, 30);
			this.Sensor1X1Offset.TabIndex = 1;
			this.Sensor1X1Offset.ValueChanged += new System.EventHandler(this.Sensor1X1Offset_ValueChanged);
			// 
			// Sensor1X2Offset
			// 
			this.Sensor1X2Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor1X2Offset.DecimalPlaces = 2;
			this.Sensor1X2Offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.Sensor1X2Offset.Location = new System.Drawing.Point(74, 168);
			this.Sensor1X2Offset.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor1X2Offset.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            65536});
			this.Sensor1X2Offset.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147418112});
			this.Sensor1X2Offset.Name = "Sensor1X2Offset";
			this.Sensor1X2Offset.Size = new System.Drawing.Size(112, 30);
			this.Sensor1X2Offset.TabIndex = 1;
			this.Sensor1X2Offset.ValueChanged += new System.EventHandler(this.Sensor1X2Offset_ValueChanged);
			// 
			// SaveOffset
			// 
			this.SaveOffset.BackColor = System.Drawing.Color.Silver;
			this.SaveOffset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SaveOffset.FlatAppearance.BorderSize = 0;
			this.SaveOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveOffset.ForeColor = System.Drawing.Color.Black;
			this.SaveOffset.Location = new System.Drawing.Point(4, 600);
			this.SaveOffset.Margin = new System.Windows.Forms.Padding(4);
			this.SaveOffset.Name = "SaveOffset";
			this.SaveOffset.Size = new System.Drawing.Size(400, 59);
			this.SaveOffset.TabIndex = 1;
			this.SaveOffset.Text = "Apply";
			this.SaveOffset.UseVisualStyleBackColor = false;
			// 
			// FileConfig
			// 
			this.FileConfig.Controls.Add(this.FileSaveConfig);
			this.FileConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileConfig.Location = new System.Drawing.Point(428, 4);
			this.FileConfig.Margin = new System.Windows.Forms.Padding(4);
			this.FileConfig.Name = "FileConfig";
			this.FileConfig.Padding = new System.Windows.Forms.Padding(4);
			this.FileConfig.Size = new System.Drawing.Size(416, 694);
			this.FileConfig.TabIndex = 1;
			this.FileConfig.TabStop = false;
			this.FileConfig.Text = "File";
			// 
			// FileSaveConfig
			// 
			this.FileSaveConfig.ColumnCount = 1;
			this.FileSaveConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FileSaveConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.FileSaveConfig.Controls.Add(this.groupBox3, 0, 0);
			this.FileSaveConfig.Controls.Add(this.groupBox4, 0, 1);
			this.FileSaveConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileSaveConfig.Location = new System.Drawing.Point(4, 27);
			this.FileSaveConfig.Margin = new System.Windows.Forms.Padding(4);
			this.FileSaveConfig.Name = "FileSaveConfig";
			this.FileSaveConfig.Padding = new System.Windows.Forms.Padding(4);
			this.FileSaveConfig.RowCount = 2;
			this.FileSaveConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.70992F));
			this.FileSaveConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.29008F));
			this.FileSaveConfig.Size = new System.Drawing.Size(408, 663);
			this.FileSaveConfig.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel21);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(8, 8);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(392, 369);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Auto Save";
			// 
			// tableLayoutPanel21
			// 
			this.tableLayoutPanel21.ColumnCount = 1;
			this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel21.Controls.Add(this.AutoSaveApply, 0, 1);
			this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 0, 0);
			this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel21.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel21.Name = "tableLayoutPanel21";
			this.tableLayoutPanel21.RowCount = 2;
			this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel21.Size = new System.Drawing.Size(384, 338);
			this.tableLayoutPanel21.TabIndex = 0;
			// 
			// AutoSaveApply
			// 
			this.AutoSaveApply.BackColor = System.Drawing.Color.Silver;
			this.AutoSaveApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoSaveApply.FlatAppearance.BorderSize = 0;
			this.AutoSaveApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AutoSaveApply.Location = new System.Drawing.Point(4, 257);
			this.AutoSaveApply.Margin = new System.Windows.Forms.Padding(4);
			this.AutoSaveApply.Name = "AutoSaveApply";
			this.AutoSaveApply.Size = new System.Drawing.Size(376, 77);
			this.AutoSaveApply.TabIndex = 18;
			this.AutoSaveApply.Text = "Apply";
			this.AutoSaveApply.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel22
			// 
			this.tableLayoutPanel22.ColumnCount = 2;
			this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel22.Controls.Add(this.AutoSaveDirectory, 1, 2);
			this.tableLayoutPanel22.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel22.Controls.Add(this.label12, 0, 1);
			this.tableLayoutPanel22.Controls.Add(this.label13, 0, 2);
			this.tableLayoutPanel22.Controls.Add(this.EnableAutoSave, 1, 0);
			this.tableLayoutPanel22.Controls.Add(this.AutoSaveInterval, 1, 1);
			this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel22.Name = "tableLayoutPanel22";
			this.tableLayoutPanel22.RowCount = 3;
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel22.Size = new System.Drawing.Size(384, 253);
			this.tableLayoutPanel22.TabIndex = 19;
			// 
			// AutoSaveDirectory
			// 
			this.AutoSaveDirectory.BackColor = System.Drawing.Color.Silver;
			this.AutoSaveDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoSaveDirectory.FlatAppearance.BorderSize = 0;
			this.AutoSaveDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AutoSaveDirectory.Location = new System.Drawing.Point(157, 172);
			this.AutoSaveDirectory.Margin = new System.Windows.Forms.Padding(4);
			this.AutoSaveDirectory.Name = "AutoSaveDirectory";
			this.AutoSaveDirectory.Size = new System.Drawing.Size(223, 77);
			this.AutoSaveDirectory.TabIndex = 21;
			this.AutoSaveDirectory.Text = "Browse";
			this.AutoSaveDirectory.UseVisualStyleBackColor = false;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(4, 4);
			this.label10.Margin = new System.Windows.Forms.Padding(4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(145, 76);
			this.label10.TabIndex = 1;
			this.label10.Text = "Auto Save";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(4, 88);
			this.label12.Margin = new System.Windows.Forms.Padding(4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(145, 76);
			this.label12.TabIndex = 1;
			this.label12.Text = "Save Interval";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Location = new System.Drawing.Point(4, 172);
			this.label13.Margin = new System.Windows.Forms.Padding(4);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(145, 77);
			this.label13.TabIndex = 1;
			this.label13.Text = "Directory";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EnableAutoSave
			// 
			this.EnableAutoSave.BackColor = System.Drawing.Color.Silver;
			this.EnableAutoSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EnableAutoSave.FlatAppearance.BorderSize = 0;
			this.EnableAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EnableAutoSave.Location = new System.Drawing.Point(157, 4);
			this.EnableAutoSave.Margin = new System.Windows.Forms.Padding(4);
			this.EnableAutoSave.Name = "EnableAutoSave";
			this.EnableAutoSave.Size = new System.Drawing.Size(223, 76);
			this.EnableAutoSave.TabIndex = 19;
			this.EnableAutoSave.Text = "Disabled";
			this.EnableAutoSave.UseVisualStyleBackColor = false;
			// 
			// AutoSaveInterval
			// 
			this.AutoSaveInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.AutoSaveInterval.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AutoSaveInterval.FormattingEnabled = true;
			this.AutoSaveInterval.Items.AddRange(new object[] {
            "Hour",
            "Day",
            "Week",
            "Month",
            "Year"});
			this.AutoSaveInterval.Location = new System.Drawing.Point(156, 108);
			this.AutoSaveInterval.Name = "AutoSaveInterval";
			this.AutoSaveInterval.Size = new System.Drawing.Size(225, 35);
			this.AutoSaveInterval.TabIndex = 20;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel23);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(8, 385);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(392, 270);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Manual Save";
			// 
			// tableLayoutPanel23
			// 
			this.tableLayoutPanel23.ColumnCount = 1;
			this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel23.Controls.Add(this.SaveNow, 0, 0);
			this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel23.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel23.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel23.Name = "tableLayoutPanel23";
			this.tableLayoutPanel23.RowCount = 1;
			this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
			this.tableLayoutPanel23.Size = new System.Drawing.Size(384, 239);
			this.tableLayoutPanel23.TabIndex = 0;
			// 
			// SaveNow
			// 
			this.SaveNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveNow.BackColor = System.Drawing.Color.Silver;
			this.SaveNow.FlatAppearance.BorderSize = 0;
			this.SaveNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveNow.Location = new System.Drawing.Point(4, 81);
			this.SaveNow.Margin = new System.Windows.Forms.Padding(4);
			this.SaveNow.Name = "SaveNow";
			this.SaveNow.Size = new System.Drawing.Size(376, 77);
			this.SaveNow.TabIndex = 19;
			this.SaveNow.Text = "Save Now";
			this.SaveNow.UseVisualStyleBackColor = false;
			// 
			// NetworkConfig
			// 
			this.NetworkConfig.Controls.Add(this.SocketsConfig);
			this.NetworkConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NetworkConfig.Location = new System.Drawing.Point(4, 4);
			this.NetworkConfig.Margin = new System.Windows.Forms.Padding(4);
			this.NetworkConfig.Name = "NetworkConfig";
			this.NetworkConfig.Padding = new System.Windows.Forms.Padding(4);
			this.NetworkConfig.Size = new System.Drawing.Size(416, 694);
			this.NetworkConfig.TabIndex = 0;
			this.NetworkConfig.TabStop = false;
			this.NetworkConfig.Text = "Network";
			// 
			// SocketsConfig
			// 
			this.SocketsConfig.ColumnCount = 1;
			this.SocketsConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SocketsConfig.Controls.Add(this.DbConnectionConfig, 0, 2);
			this.SocketsConfig.Controls.Add(this.RobotConnectionConfig, 0, 1);
			this.SocketsConfig.Controls.Add(this.SensorConnectionConfig, 0, 0);
			this.SocketsConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SocketsConfig.Location = new System.Drawing.Point(4, 27);
			this.SocketsConfig.Margin = new System.Windows.Forms.Padding(4);
			this.SocketsConfig.Name = "SocketsConfig";
			this.SocketsConfig.RowCount = 3;
			this.SocketsConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.SocketsConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.SocketsConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.SocketsConfig.Size = new System.Drawing.Size(408, 663);
			this.SocketsConfig.TabIndex = 0;
			// 
			// DbConnectionConfig
			// 
			this.DbConnectionConfig.Controls.Add(this.tableLayoutPanel16);
			this.DbConnectionConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DbConnectionConfig.Location = new System.Drawing.Point(3, 499);
			this.DbConnectionConfig.Name = "DbConnectionConfig";
			this.DbConnectionConfig.Padding = new System.Windows.Forms.Padding(4);
			this.DbConnectionConfig.Size = new System.Drawing.Size(402, 161);
			this.DbConnectionConfig.TabIndex = 2;
			this.DbConnectionConfig.TabStop = false;
			this.DbConnectionConfig.Text = "DB Connection";
			// 
			// tableLayoutPanel16
			// 
			this.tableLayoutPanel16.ColumnCount = 1;
			this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel16.Controls.Add(this.DbConnectionSave, 0, 2);
			this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel18, 0, 0);
			this.tableLayoutPanel16.Controls.Add(this.DbConnectionStatus, 0, 1);
			this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel16.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel16.Name = "tableLayoutPanel16";
			this.tableLayoutPanel16.RowCount = 3;
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel16.Size = new System.Drawing.Size(394, 130);
			this.tableLayoutPanel16.TabIndex = 1;
			// 
			// DbConnectionSave
			// 
			this.DbConnectionSave.BackColor = System.Drawing.Color.Silver;
			this.DbConnectionSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DbConnectionSave.FlatAppearance.BorderSize = 0;
			this.DbConnectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DbConnectionSave.Location = new System.Drawing.Point(4, 90);
			this.DbConnectionSave.Margin = new System.Windows.Forms.Padding(4);
			this.DbConnectionSave.Name = "DbConnectionSave";
			this.DbConnectionSave.Size = new System.Drawing.Size(386, 36);
			this.DbConnectionSave.TabIndex = 19;
			this.DbConnectionSave.Text = "Apply";
			this.DbConnectionSave.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel18
			// 
			this.tableLayoutPanel18.ColumnCount = 2;
			this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel18.Controls.Add(this.DbIpAddress, 0, 0);
			this.tableLayoutPanel18.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel18.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel18.Name = "tableLayoutPanel18";
			this.tableLayoutPanel18.RowCount = 1;
			this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel18.Size = new System.Drawing.Size(386, 35);
			this.tableLayoutPanel18.TabIndex = 0;
			// 
			// DbIpAddress
			// 
			this.DbIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DbIpAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DbIpAddress.Location = new System.Drawing.Point(115, 2);
			this.DbIpAddress.Margin = new System.Windows.Forms.Padding(0);
			this.DbIpAddress.Name = "DbIpAddress";
			this.DbIpAddress.Size = new System.Drawing.Size(271, 30);
			this.DbIpAddress.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 35);
			this.label11.TabIndex = 1;
			this.label11.Text = "DB IP";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DbConnectionStatus
			// 
			this.DbConnectionStatus.BackColor = System.Drawing.Color.Silver;
			this.DbConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DbConnectionStatus.Enabled = false;
			this.DbConnectionStatus.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DbConnectionStatus.ForeColor = System.Drawing.Color.Black;
			this.DbConnectionStatus.Location = new System.Drawing.Point(3, 46);
			this.DbConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
			this.DbConnectionStatus.Name = "DbConnectionStatus";
			this.DbConnectionStatus.Size = new System.Drawing.Size(388, 37);
			this.DbConnectionStatus.TabIndex = 17;
			this.DbConnectionStatus.Text = "Connection Test";
			this.DbConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DbConnectionStatus.Click += new System.EventHandler(this.DbConnectionStatus_Click);
			// 
			// RobotConnectionConfig
			// 
			this.RobotConnectionConfig.Controls.Add(this.tableLayoutPanel12);
			this.RobotConnectionConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RobotConnectionConfig.Location = new System.Drawing.Point(3, 251);
			this.RobotConnectionConfig.Name = "RobotConnectionConfig";
			this.RobotConnectionConfig.Padding = new System.Windows.Forms.Padding(4);
			this.RobotConnectionConfig.Size = new System.Drawing.Size(402, 242);
			this.RobotConnectionConfig.TabIndex = 1;
			this.RobotConnectionConfig.TabStop = false;
			this.RobotConnectionConfig.Text = "Robot Connection";
			// 
			// tableLayoutPanel12
			// 
			this.tableLayoutPanel12.ColumnCount = 1;
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel14, 0, 1);
			this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel15, 0, 0);
			this.tableLayoutPanel12.Controls.Add(this.RobotConnectionSave, 0, 3);
			this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel26, 0, 2);
			this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 4;
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel12.Size = new System.Drawing.Size(394, 211);
			this.tableLayoutPanel12.TabIndex = 1;
			// 
			// tableLayoutPanel14
			// 
			this.tableLayoutPanel14.ColumnCount = 2;
			this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel14.Controls.Add(this.Robot2IpAddress, 0, 0);
			this.tableLayoutPanel14.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel14.Location = new System.Drawing.Point(4, 56);
			this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel14.Name = "tableLayoutPanel14";
			this.tableLayoutPanel14.RowCount = 1;
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel14.Size = new System.Drawing.Size(386, 44);
			this.tableLayoutPanel14.TabIndex = 2;
			// 
			// Robot2IpAddress
			// 
			this.Robot2IpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Robot2IpAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Robot2IpAddress.Location = new System.Drawing.Point(115, 7);
			this.Robot2IpAddress.Margin = new System.Windows.Forms.Padding(0);
			this.Robot2IpAddress.Name = "Robot2IpAddress";
			this.Robot2IpAddress.Size = new System.Drawing.Size(271, 30);
			this.Robot2IpAddress.TabIndex = 3;
			this.Robot2IpAddress.Text = "124.127.248.85";
			this.Robot2IpAddress.TextChanged += new System.EventHandler(this.Robot2IpAddress_TextChanged);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 44);
			this.label4.TabIndex = 2;
			this.label4.Text = "Robot2 IP";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel15
			// 
			this.tableLayoutPanel15.ColumnCount = 2;
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel15.Controls.Add(this.Robot1IpAddress, 0, 0);
			this.tableLayoutPanel15.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel15.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel15.Name = "tableLayoutPanel15";
			this.tableLayoutPanel15.RowCount = 1;
			this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel15.Size = new System.Drawing.Size(386, 44);
			this.tableLayoutPanel15.TabIndex = 0;
			// 
			// Robot1IpAddress
			// 
			this.Robot1IpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Robot1IpAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Robot1IpAddress.Location = new System.Drawing.Point(115, 7);
			this.Robot1IpAddress.Margin = new System.Windows.Forms.Padding(0);
			this.Robot1IpAddress.Name = "Robot1IpAddress";
			this.Robot1IpAddress.Size = new System.Drawing.Size(271, 30);
			this.Robot1IpAddress.TabIndex = 2;
			this.Robot1IpAddress.Text = "124.127.248.84";
			this.Robot1IpAddress.TextChanged += new System.EventHandler(this.Robot1IpAddress_TextChanged);
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 44);
			this.label3.TabIndex = 1;
			this.label3.Text = "Robot1 IP";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RobotConnectionSave
			// 
			this.RobotConnectionSave.BackColor = System.Drawing.Color.Silver;
			this.RobotConnectionSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RobotConnectionSave.FlatAppearance.BorderSize = 0;
			this.RobotConnectionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RobotConnectionSave.Location = new System.Drawing.Point(4, 160);
			this.RobotConnectionSave.Margin = new System.Windows.Forms.Padding(4);
			this.RobotConnectionSave.Name = "RobotConnectionSave";
			this.RobotConnectionSave.Size = new System.Drawing.Size(386, 47);
			this.RobotConnectionSave.TabIndex = 19;
			this.RobotConnectionSave.Text = "Apply";
			this.RobotConnectionSave.UseVisualStyleBackColor = false;
			this.RobotConnectionSave.Click += new System.EventHandler(this.RobotConnectionSave_Click);
			// 
			// tableLayoutPanel26
			// 
			this.tableLayoutPanel26.ColumnCount = 2;
			this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel26.Controls.Add(this.RobotServerPort, 0, 0);
			this.tableLayoutPanel26.Controls.Add(this.label14, 0, 0);
			this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel26.Location = new System.Drawing.Point(4, 108);
			this.tableLayoutPanel26.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel26.Name = "tableLayoutPanel26";
			this.tableLayoutPanel26.RowCount = 1;
			this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel26.Size = new System.Drawing.Size(386, 44);
			this.tableLayoutPanel26.TabIndex = 2;
			// 
			// RobotServerPort
			// 
			this.RobotServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RobotServerPort.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.RobotServerPort.Location = new System.Drawing.Point(115, 7);
			this.RobotServerPort.Margin = new System.Windows.Forms.Padding(0);
			this.RobotServerPort.Name = "RobotServerPort";
			this.RobotServerPort.Size = new System.Drawing.Size(271, 30);
			this.RobotServerPort.TabIndex = 3;
			this.RobotServerPort.Text = "11002";
			// 
			// label14
			// 
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(115, 44);
			this.label14.TabIndex = 2;
			this.label14.Text = "Port";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SensorConnectionConfig
			// 
			this.SensorConnectionConfig.Controls.Add(this.tableLayoutPanel10);
			this.SensorConnectionConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SensorConnectionConfig.Location = new System.Drawing.Point(4, 4);
			this.SensorConnectionConfig.Margin = new System.Windows.Forms.Padding(4);
			this.SensorConnectionConfig.Name = "SensorConnectionConfig";
			this.SensorConnectionConfig.Padding = new System.Windows.Forms.Padding(4);
			this.SensorConnectionConfig.Size = new System.Drawing.Size(400, 240);
			this.SensorConnectionConfig.TabIndex = 0;
			this.SensorConnectionConfig.TabStop = false;
			this.SensorConnectionConfig.Text = "Sensor Connection";
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.ColumnCount = 1;
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel13, 0, 2);
			this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
			this.tableLayoutPanel10.Controls.Add(this.Sensor1ConnectionStatus, 0, 1);
			this.tableLayoutPanel10.Controls.Add(this.Sensor2ConnectionStatus, 0, 3);
			this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 27);
			this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 4;
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(392, 209);
			this.tableLayoutPanel10.TabIndex = 0;
			// 
			// tableLayoutPanel13
			// 
			this.tableLayoutPanel13.ColumnCount = 2;
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel13.Controls.Add(this.Sensor2IpAddress, 0, 0);
			this.tableLayoutPanel13.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 108);
			this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel13.Name = "tableLayoutPanel13";
			this.tableLayoutPanel13.RowCount = 1;
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel13.Size = new System.Drawing.Size(384, 44);
			this.tableLayoutPanel13.TabIndex = 2;
			// 
			// Sensor2IpAddress
			// 
			this.Sensor2IpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor2IpAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2IpAddress.Location = new System.Drawing.Point(115, 7);
			this.Sensor2IpAddress.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor2IpAddress.Name = "Sensor2IpAddress";
			this.Sensor2IpAddress.Size = new System.Drawing.Size(269, 30);
			this.Sensor2IpAddress.TabIndex = 2;
			this.Sensor2IpAddress.Text = "192.168.0.102:24687";
			this.Sensor2IpAddress.TextChanged += new System.EventHandler(this.Sensor2IpAddress_TextChanged);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 44);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sensor2 IP";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel11
			// 
			this.tableLayoutPanel11.ColumnCount = 2;
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel11.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel11.Controls.Add(this.Sensor1IpAddress, 1, 0);
			this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel11.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 1;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel11.Size = new System.Drawing.Size(384, 44);
			this.tableLayoutPanel11.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sensor1 IP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor1IpAddress
			// 
			this.Sensor1IpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Sensor1IpAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1IpAddress.Location = new System.Drawing.Point(115, 7);
			this.Sensor1IpAddress.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor1IpAddress.Name = "Sensor1IpAddress";
			this.Sensor1IpAddress.Size = new System.Drawing.Size(269, 30);
			this.Sensor1IpAddress.TabIndex = 1;
			this.Sensor1IpAddress.Text = "192.168.0.101:24687";
			this.Sensor1IpAddress.TextChanged += new System.EventHandler(this.Sensor1IpAddress_TextChanged);
			// 
			// Sensor1ConnectionStatus
			// 
			this.Sensor1ConnectionStatus.BackColor = System.Drawing.Color.Silver;
			this.Sensor1ConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor1ConnectionStatus.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1ConnectionStatus.ForeColor = System.Drawing.Color.Black;
			this.Sensor1ConnectionStatus.Location = new System.Drawing.Point(3, 55);
			this.Sensor1ConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
			this.Sensor1ConnectionStatus.Name = "Sensor1ConnectionStatus";
			this.Sensor1ConnectionStatus.Size = new System.Drawing.Size(386, 46);
			this.Sensor1ConnectionStatus.TabIndex = 15;
			this.Sensor1ConnectionStatus.Text = "Connection Test";
			this.Sensor1ConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Sensor1ConnectionStatus.Click += new System.EventHandler(this.Sensor1ConnectionStatus_Click);
			// 
			// Sensor2ConnectionStatus
			// 
			this.Sensor2ConnectionStatus.BackColor = System.Drawing.Color.Silver;
			this.Sensor2ConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Sensor2ConnectionStatus.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2ConnectionStatus.ForeColor = System.Drawing.Color.Black;
			this.Sensor2ConnectionStatus.Location = new System.Drawing.Point(3, 159);
			this.Sensor2ConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
			this.Sensor2ConnectionStatus.Name = "Sensor2ConnectionStatus";
			this.Sensor2ConnectionStatus.Size = new System.Drawing.Size(386, 47);
			this.Sensor2ConnectionStatus.TabIndex = 16;
			this.Sensor2ConnectionStatus.Text = "Connection Test";
			this.Sensor2ConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Sensor2ConnectionStatus.Click += new System.EventHandler(this.Sensor2ConnectionStatus_Click);
			// 
			// Logs
			// 
			this.Logs.BackColor = System.Drawing.Color.White;
			this.Logs.Controls.Add(this.LogConsole);
			this.Logs.Location = new System.Drawing.Point(4, 54);
			this.Logs.Margin = new System.Windows.Forms.Padding(0);
			this.Logs.Name = "Logs";
			this.Logs.Size = new System.Drawing.Size(1272, 702);
			this.Logs.TabIndex = 4;
			this.Logs.Text = "Logs";
			// 
			// LogConsole
			// 
			this.LogConsole.BackColor = System.Drawing.Color.Black;
			this.LogConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogConsole.ForeColor = System.Drawing.Color.Lime;
			this.LogConsole.Location = new System.Drawing.Point(0, 0);
			this.LogConsole.Margin = new System.Windows.Forms.Padding(0);
			this.LogConsole.MaxLength = 65536;
			this.LogConsole.Multiline = true;
			this.LogConsole.Name = "LogConsole";
			this.LogConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LogConsole.Size = new System.Drawing.Size(1272, 702);
			this.LogConsole.TabIndex = 0;
			// 
			// Diagnostics
			// 
			this.Diagnostics.Controls.Add(this.tableLayoutPanel27);
			this.Diagnostics.Location = new System.Drawing.Point(4, 54);
			this.Diagnostics.Name = "Diagnostics";
			this.Diagnostics.Size = new System.Drawing.Size(1272, 702);
			this.Diagnostics.TabIndex = 6;
			this.Diagnostics.Text = "Diagnostics";
			this.Diagnostics.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel27
			// 
			this.tableLayoutPanel27.ColumnCount = 1;
			this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel27.Controls.Add(this.SensorPingData, 0, 0);
			this.tableLayoutPanel27.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel27.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel27.Name = "tableLayoutPanel27";
			this.tableLayoutPanel27.RowCount = 2;
			this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.985755F));
			this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.01424F));
			this.tableLayoutPanel27.Size = new System.Drawing.Size(1272, 702);
			this.tableLayoutPanel27.TabIndex = 0;
			// 
			// SensorPingData
			// 
			this.SensorPingData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SensorPingData.Location = new System.Drawing.Point(0, 0);
			this.SensorPingData.Margin = new System.Windows.Forms.Padding(0);
			this.SensorPingData.Name = "SensorPingData";
			this.SensorPingData.Size = new System.Drawing.Size(1272, 35);
			this.SensorPingData.TabIndex = 0;
			this.SensorPingData.Text = "Sensor Ping : ";
			this.SensorPingData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.PassDiag);
			this.flowLayoutPanel1.Controls.Add(this.NgDiag);
			this.flowLayoutPanel1.Controls.Add(this.BPassDiag);
			this.flowLayoutPanel1.Controls.Add(this.BNgDiag);
			this.flowLayoutPanel1.Controls.Add(this.PcStatusDiag);
			this.flowLayoutPanel1.Controls.Add(this.PcCommErrorDiag);
			this.flowLayoutPanel1.Controls.Add(this.SensorStatusDiag);
			this.flowLayoutPanel1.Controls.Add(this.SensorDataStatusDiag);
			this.flowLayoutPanel1.Controls.Add(this.BypassDiag);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 38);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1266, 661);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// PassDiag
			// 
			this.PassDiag.Enabled = false;
			this.PassDiag.Location = new System.Drawing.Point(3, 3);
			this.PassDiag.Name = "PassDiag";
			this.PassDiag.Size = new System.Drawing.Size(410, 137);
			this.PassDiag.TabIndex = 0;
			this.PassDiag.Text = "PASS";
			this.PassDiag.UseVisualStyleBackColor = true;
			this.PassDiag.Click += new System.EventHandler(this.PassDiag_Click);
			// 
			// NgDiag
			// 
			this.NgDiag.Enabled = false;
			this.NgDiag.Location = new System.Drawing.Point(419, 3);
			this.NgDiag.Name = "NgDiag";
			this.NgDiag.Size = new System.Drawing.Size(410, 137);
			this.NgDiag.TabIndex = 1;
			this.NgDiag.Text = "NG";
			this.NgDiag.UseVisualStyleBackColor = true;
			this.NgDiag.Click += new System.EventHandler(this.NgDiag_Click);
			// 
			// BPassDiag
			// 
			this.BPassDiag.Enabled = false;
			this.BPassDiag.Location = new System.Drawing.Point(835, 3);
			this.BPassDiag.Name = "BPassDiag";
			this.BPassDiag.Size = new System.Drawing.Size(410, 137);
			this.BPassDiag.TabIndex = 2;
			this.BPassDiag.Text = "BENDING PASS";
			this.BPassDiag.UseVisualStyleBackColor = true;
			this.BPassDiag.Click += new System.EventHandler(this.BPassDiag_Click);
			// 
			// BNgDiag
			// 
			this.BNgDiag.Enabled = false;
			this.BNgDiag.Location = new System.Drawing.Point(3, 146);
			this.BNgDiag.Name = "BNgDiag";
			this.BNgDiag.Size = new System.Drawing.Size(410, 137);
			this.BNgDiag.TabIndex = 3;
			this.BNgDiag.Text = "BENDING NG";
			this.BNgDiag.UseVisualStyleBackColor = true;
			this.BNgDiag.Click += new System.EventHandler(this.BNgDiag_Click);
			// 
			// PcStatusDiag
			// 
			this.PcStatusDiag.Location = new System.Drawing.Point(419, 146);
			this.PcStatusDiag.Name = "PcStatusDiag";
			this.PcStatusDiag.Size = new System.Drawing.Size(410, 137);
			this.PcStatusDiag.TabIndex = 4;
			this.PcStatusDiag.Text = "PC STATUS";
			this.PcStatusDiag.UseVisualStyleBackColor = true;
			this.PcStatusDiag.Click += new System.EventHandler(this.PcStatus_Click);
			// 
			// PcCommErrorDiag
			// 
			this.PcCommErrorDiag.Location = new System.Drawing.Point(835, 146);
			this.PcCommErrorDiag.Name = "PcCommErrorDiag";
			this.PcCommErrorDiag.Size = new System.Drawing.Size(410, 137);
			this.PcCommErrorDiag.TabIndex = 8;
			this.PcCommErrorDiag.Text = "PC COMM ERROR";
			this.PcCommErrorDiag.UseVisualStyleBackColor = true;
			this.PcCommErrorDiag.Click += new System.EventHandler(this.PcCommError_Click);
			// 
			// SensorStatusDiag
			// 
			this.SensorStatusDiag.Location = new System.Drawing.Point(3, 289);
			this.SensorStatusDiag.Name = "SensorStatusDiag";
			this.SensorStatusDiag.Size = new System.Drawing.Size(410, 137);
			this.SensorStatusDiag.TabIndex = 5;
			this.SensorStatusDiag.Text = "SENSOR STATUS";
			this.SensorStatusDiag.UseVisualStyleBackColor = true;
			this.SensorStatusDiag.Click += new System.EventHandler(this.SensorStatus_Click);
			// 
			// SensorDataStatusDiag
			// 
			this.SensorDataStatusDiag.Enabled = false;
			this.SensorDataStatusDiag.Location = new System.Drawing.Point(419, 289);
			this.SensorDataStatusDiag.Name = "SensorDataStatusDiag";
			this.SensorDataStatusDiag.Size = new System.Drawing.Size(410, 137);
			this.SensorDataStatusDiag.TabIndex = 6;
			this.SensorDataStatusDiag.Text = "SENSOR DATA STATUS";
			this.SensorDataStatusDiag.UseVisualStyleBackColor = true;
			this.SensorDataStatusDiag.Click += new System.EventHandler(this.SensorDataStatusDiag_Click);
			// 
			// BypassDiag
			// 
			this.BypassDiag.Location = new System.Drawing.Point(835, 289);
			this.BypassDiag.Name = "BypassDiag";
			this.BypassDiag.Size = new System.Drawing.Size(410, 137);
			this.BypassDiag.TabIndex = 7;
			this.BypassDiag.Text = "BYPASS";
			this.BypassDiag.UseVisualStyleBackColor = true;
			this.BypassDiag.Click += new System.EventHandler(this.BypassDiag_Click);
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
			this.GlobalFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.GlobalFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.GlobalFormLayout.Size = new System.Drawing.Size(1280, 800);
			this.GlobalFormLayout.TabIndex = 3;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.Controls.Add(this.Exit, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.TitleBar, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.Logo, 0, 0);
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
			this.Exit.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.RoyalBlue;
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitleBar.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TitleBar.ForeColor = System.Drawing.Color.White;
			this.TitleBar.Location = new System.Drawing.Point(40, 0);
			this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(1200, 40);
			this.TitleBar.TabIndex = 0;
			this.TitleBar.Text = "Tango Project";
			this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			// 
			// Logo
			// 
			this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
			this.Logo.Location = new System.Drawing.Point(0, 0);
			this.Logo.Margin = new System.Windows.Forms.Padding(0);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(40, 40);
			this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Logo.TabIndex = 2;
			this.Logo.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.TabMenu.ResumeLayout(false);
			this.Main.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Sensor1Data)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2Data)).EndInit();
			this.StatusPanel.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LeftDoorImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RightDoorImage)).EndInit();
			this.RobotPhase.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.Robot2PhaseGroup.ResumeLayout(false);
			this.Robot2PhasePanel.ResumeLayout(false);
			this.Robot2PhasePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Robot2PhaseImage)).EndInit();
			this.Robot1PhaseGroup.ResumeLayout(false);
			this.Robot1PhasePanel.ResumeLayout(false);
			this.Robot1PhasePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Robot1PhaseImage)).EndInit();
			this.Statistics.ResumeLayout(false);
			this.StatisticsChartArea.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SensorChart)).EndInit();
			this.tableLayoutPanel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Stats2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Stats1)).EndInit();
			this.ByPass.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.Configuration.ResumeLayout(false);
			this.ConfigPanel.ResumeLayout(false);
			this.BiasConfig.ResumeLayout(false);
			this.BiasConfigPanel.ResumeLayout(false);
			this.tableLayoutPanel17.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tableLayoutPanel25.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Sensor2X1Offset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor2X2Offset)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel19.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel24.ResumeLayout(false);
			this.tableLayoutPanel24.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1X1Offset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Sensor1X2Offset)).EndInit();
			this.FileConfig.ResumeLayout(false);
			this.FileSaveConfig.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel21.ResumeLayout(false);
			this.tableLayoutPanel22.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel23.ResumeLayout(false);
			this.NetworkConfig.ResumeLayout(false);
			this.SocketsConfig.ResumeLayout(false);
			this.DbConnectionConfig.ResumeLayout(false);
			this.tableLayoutPanel16.ResumeLayout(false);
			this.tableLayoutPanel18.ResumeLayout(false);
			this.tableLayoutPanel18.PerformLayout();
			this.RobotConnectionConfig.ResumeLayout(false);
			this.tableLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel14.ResumeLayout(false);
			this.tableLayoutPanel14.PerformLayout();
			this.tableLayoutPanel15.ResumeLayout(false);
			this.tableLayoutPanel15.PerformLayout();
			this.tableLayoutPanel26.ResumeLayout(false);
			this.tableLayoutPanel26.PerformLayout();
			this.SensorConnectionConfig.ResumeLayout(false);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel13.PerformLayout();
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel11.PerformLayout();
			this.Logs.ResumeLayout(false);
			this.Logs.PerformLayout();
			this.Diagnostics.ResumeLayout(false);
			this.tableLayoutPanel27.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.GlobalFormLayout.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
		private System.Windows.Forms.Button BypassToggle;
		private System.Windows.Forms.TableLayoutPanel StatisticsChartArea;
		private System.Windows.Forms.DataVisualization.Charting.Chart SensorChart;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView Sensor1Data;
		private System.Windows.Forms.DataGridView Sensor2Data;
		private System.Windows.Forms.GroupBox StatusPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox LeftDoorImage;
		private System.Windows.Forms.PictureBox RightDoorImage;
		private System.Windows.Forms.TableLayoutPanel GlobalFormLayout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.DataVisualization.Charting.Chart Stats2;
		private System.Windows.Forms.DataVisualization.Charting.Chart Stats1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Label Robot2Status;
		private System.Windows.Forms.Label Robot1Status;
		private System.Windows.Forms.Label Sensor2Status;
		private System.Windows.Forms.Label Sensor1Status;
		private System.Windows.Forms.TableLayoutPanel ConfigPanel;
		private System.Windows.Forms.GroupBox BiasConfig;
		private System.Windows.Forms.GroupBox FileConfig;
		private System.Windows.Forms.GroupBox NetworkConfig;
		private System.Windows.Forms.TableLayoutPanel SocketsConfig;
		private System.Windows.Forms.TableLayoutPanel FileSaveConfig;
		private System.Windows.Forms.TableLayoutPanel BiasConfigPanel;
		private System.Windows.Forms.TabPage RobotPhase;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.GroupBox Robot2PhaseGroup;
		private System.Windows.Forms.TableLayoutPanel Robot2PhasePanel;
		private System.Windows.Forms.TextBox Robot2PhaseText;
		private System.Windows.Forms.PictureBox Robot2PhaseImage;
		private System.Windows.Forms.GroupBox Robot1PhaseGroup;
		private System.Windows.Forms.TableLayoutPanel Robot1PhasePanel;
		private System.Windows.Forms.PictureBox Robot1PhaseImage;
		private System.Windows.Forms.TextBox Robot1PhaseText;
		private System.Windows.Forms.GroupBox RobotConnectionConfig;
		private System.Windows.Forms.GroupBox SensorConnectionConfig;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Sensor1IpAddress;
		private System.Windows.Forms.TextBox Sensor2IpAddress;
		private System.Windows.Forms.TextBox Robot2IpAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Robot1IpAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Sensor1ConnectionStatus;
		private System.Windows.Forms.Label Sensor2ConnectionStatus;
		private System.Windows.Forms.Button RobotConnectionSave;
		private System.Windows.Forms.GroupBox DbConnectionConfig;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
		private System.Windows.Forms.Button DbConnectionSave;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
		private System.Windows.Forms.TextBox DbIpAddress;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label DbConnectionStatus;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
		private System.Windows.Forms.Button SaveOffset;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
		private System.Windows.Forms.Button AutoSaveApply;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button EnableAutoSave;
		private System.Windows.Forms.Button AutoSaveDirectory;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
		private System.Windows.Forms.Button SaveNow;
		private System.Windows.Forms.ComboBox AutoSaveInterval;
		private System.Windows.Forms.Label TitleBar;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown Sensor2X1Offset;
		private System.Windows.Forms.NumericUpDown Sensor2X2Offset;
		private System.Windows.Forms.NumericUpDown Sensor1X1Offset;
		private System.Windows.Forms.NumericUpDown Sensor1X2Offset;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
		private System.Windows.Forms.TextBox RobotServerPort;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1Time;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1BendingStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X1Before;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X2Before;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X1After;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X2After;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X1Delta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor1X2Delta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2Time;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X1Before;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X2Before;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X1After;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X2After;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X1Delta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2X2Delta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensor2BendingStatus;
		private System.Windows.Forms.TabPage Diagnostics;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
		private System.Windows.Forms.Label SensorPingData;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button PassDiag;
		private System.Windows.Forms.Button NgDiag;
		private System.Windows.Forms.Button BPassDiag;
		private System.Windows.Forms.Button BNgDiag;
		private System.Windows.Forms.Button PcStatusDiag;
		private System.Windows.Forms.Button SensorStatusDiag;
		private System.Windows.Forms.Button PcCommErrorDiag;
		private System.Windows.Forms.Button SensorDataStatusDiag;
		private System.Windows.Forms.Button BypassDiag;
	}
}

