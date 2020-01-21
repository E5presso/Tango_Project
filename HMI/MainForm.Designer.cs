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
			this.TitleBar = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.TabMenu = new System.Windows.Forms.TabControl();
			this.Main = new System.Windows.Forms.TabPage();
			this.Configuration = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.ByPass = new System.Windows.Forms.TabPage();
			this.Logs = new System.Windows.Forms.TabPage();
			this.MainTabButton = new System.Windows.Forms.Button();
			this.StatisticsTabButton = new System.Windows.Forms.Button();
			this.ConfigTabButton = new System.Windows.Forms.Button();
			this.BypassTabButton = new System.Windows.Forms.Button();
			this.LogTabButton = new System.Windows.Forms.Button();
			this.DoorImage = new System.Windows.Forms.PictureBox();
			this.DoorLeftDataGrid = new System.Windows.Forms.DataGridView();
			this.DoorRightDataGrid = new System.Windows.Forms.DataGridView();
			this.StatusPanel = new System.Windows.Forms.GroupBox();
			this.Sensor1Status = new System.Windows.Forms.Label();
			this.Sensor2Status = new System.Windows.Forms.Label();
			this.Robot1Status = new System.Windows.Forms.Label();
			this.Robot2Status = new System.Windows.Forms.Label();
			this.LogConsole = new System.Windows.Forms.TextBox();
			this.Sensor1Config = new System.Windows.Forms.GroupBox();
			this.Sensor2Config = new System.Windows.Forms.GroupBox();
			this.RobotConfig = new System.Windows.Forms.GroupBox();
			this.Sensor1IP = new System.Windows.Forms.TextBox();
			this.Sensor1Port = new System.Windows.Forms.TextBox();
			this.Sensor1Connect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Sensor2Connect = new System.Windows.Forms.Button();
			this.Sensor2Port = new System.Windows.Forms.TextBox();
			this.Sensor2IP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.BypassToggle = new System.Windows.Forms.Button();
			this.TabMenu.SuspendLayout();
			this.Main.SuspendLayout();
			this.Configuration.SuspendLayout();
			this.ByPass.SuspendLayout();
			this.Logs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DoorImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DoorLeftDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DoorRightDataGrid)).BeginInit();
			this.StatusPanel.SuspendLayout();
			this.Sensor1Config.SuspendLayout();
			this.Sensor2Config.SuspendLayout();
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
			this.Main.Controls.Add(this.StatusPanel);
			this.Main.Controls.Add(this.DoorRightDataGrid);
			this.Main.Controls.Add(this.DoorLeftDataGrid);
			this.Main.Controls.Add(this.DoorImage);
			this.Main.Location = new System.Drawing.Point(4, 14);
			this.Main.Margin = new System.Windows.Forms.Padding(0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(1272, 702);
			this.Main.TabIndex = 0;
			// 
			// Configuration
			// 
			this.Configuration.BackColor = System.Drawing.Color.White;
			this.Configuration.Controls.Add(this.RobotConfig);
			this.Configuration.Controls.Add(this.Sensor2Config);
			this.Configuration.Controls.Add(this.Sensor1Config);
			this.Configuration.Location = new System.Drawing.Point(4, 14);
			this.Configuration.Margin = new System.Windows.Forms.Padding(0);
			this.Configuration.Name = "Configuration";
			this.Configuration.Size = new System.Drawing.Size(1272, 702);
			this.Configuration.TabIndex = 1;
			// 
			// Statistics
			// 
			this.Statistics.BackColor = System.Drawing.Color.White;
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
			// Logs
			// 
			this.Logs.BackColor = System.Drawing.Color.White;
			this.Logs.Controls.Add(this.LogConsole);
			this.Logs.Location = new System.Drawing.Point(4, 14);
			this.Logs.Name = "Logs";
			this.Logs.Size = new System.Drawing.Size(1272, 702);
			this.Logs.TabIndex = 4;
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
			// DoorImage
			// 
			this.DoorImage.Location = new System.Drawing.Point(0, 0);
			this.DoorImage.Margin = new System.Windows.Forms.Padding(0);
			this.DoorImage.Name = "DoorImage";
			this.DoorImage.Size = new System.Drawing.Size(508, 702);
			this.DoorImage.TabIndex = 0;
			this.DoorImage.TabStop = false;
			// 
			// DoorLeftDataGrid
			// 
			this.DoorLeftDataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
			this.DoorLeftDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DoorLeftDataGrid.GridColor = System.Drawing.Color.Gray;
			this.DoorLeftDataGrid.Location = new System.Drawing.Point(508, 0);
			this.DoorLeftDataGrid.Margin = new System.Windows.Forms.Padding(0);
			this.DoorLeftDataGrid.Name = "DoorLeftDataGrid";
			this.DoorLeftDataGrid.RowTemplate.Height = 23;
			this.DoorLeftDataGrid.Size = new System.Drawing.Size(512, 351);
			this.DoorLeftDataGrid.TabIndex = 1;
			// 
			// DoorRightDataGrid
			// 
			this.DoorRightDataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
			this.DoorRightDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DoorRightDataGrid.GridColor = System.Drawing.Color.Gray;
			this.DoorRightDataGrid.Location = new System.Drawing.Point(508, 351);
			this.DoorRightDataGrid.Margin = new System.Windows.Forms.Padding(0);
			this.DoorRightDataGrid.Name = "DoorRightDataGrid";
			this.DoorRightDataGrid.RowTemplate.Height = 23;
			this.DoorRightDataGrid.Size = new System.Drawing.Size(512, 351);
			this.DoorRightDataGrid.TabIndex = 2;
			// 
			// StatusPanel
			// 
			this.StatusPanel.Controls.Add(this.Robot2Status);
			this.StatusPanel.Controls.Add(this.Robot1Status);
			this.StatusPanel.Controls.Add(this.Sensor2Status);
			this.StatusPanel.Controls.Add(this.Sensor1Status);
			this.StatusPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StatusPanel.Location = new System.Drawing.Point(1023, 3);
			this.StatusPanel.Margin = new System.Windows.Forms.Padding(0);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Padding = new System.Windows.Forms.Padding(0);
			this.StatusPanel.Size = new System.Drawing.Size(249, 699);
			this.StatusPanel.TabIndex = 3;
			this.StatusPanel.TabStop = false;
			this.StatusPanel.Text = "연결상태";
			// 
			// Sensor1Status
			// 
			this.Sensor1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor1Status.ForeColor = System.Drawing.Color.White;
			this.Sensor1Status.Location = new System.Drawing.Point(5, 24);
			this.Sensor1Status.Margin = new System.Windows.Forms.Padding(5);
			this.Sensor1Status.Name = "Sensor1Status";
			this.Sensor1Status.Size = new System.Drawing.Size(234, 49);
			this.Sensor1Status.TabIndex = 0;
			this.Sensor1Status.Text = "센서 1";
			this.Sensor1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Sensor2Status
			// 
			this.Sensor2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Sensor2Status.ForeColor = System.Drawing.Color.White;
			this.Sensor2Status.Location = new System.Drawing.Point(5, 83);
			this.Sensor2Status.Margin = new System.Windows.Forms.Padding(5);
			this.Sensor2Status.Name = "Sensor2Status";
			this.Sensor2Status.Size = new System.Drawing.Size(234, 49);
			this.Sensor2Status.TabIndex = 1;
			this.Sensor2Status.Text = "센서 2";
			this.Sensor2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Robot1Status
			// 
			this.Robot1Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot1Status.ForeColor = System.Drawing.Color.White;
			this.Robot1Status.Location = new System.Drawing.Point(5, 142);
			this.Robot1Status.Margin = new System.Windows.Forms.Padding(5);
			this.Robot1Status.Name = "Robot1Status";
			this.Robot1Status.Size = new System.Drawing.Size(234, 49);
			this.Robot1Status.TabIndex = 2;
			this.Robot1Status.Text = "로봇 1";
			this.Robot1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Robot2Status
			// 
			this.Robot2Status.BackColor = System.Drawing.Color.OrangeRed;
			this.Robot2Status.ForeColor = System.Drawing.Color.White;
			this.Robot2Status.Location = new System.Drawing.Point(5, 201);
			this.Robot2Status.Margin = new System.Windows.Forms.Padding(5);
			this.Robot2Status.Name = "Robot2Status";
			this.Robot2Status.Size = new System.Drawing.Size(234, 49);
			this.Robot2Status.TabIndex = 3;
			this.Robot2Status.Text = "로봇 2";
			this.Robot2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// Sensor1Config
			// 
			this.Sensor1Config.Controls.Add(this.label2);
			this.Sensor1Config.Controls.Add(this.label1);
			this.Sensor1Config.Controls.Add(this.Sensor1Connect);
			this.Sensor1Config.Controls.Add(this.Sensor1Port);
			this.Sensor1Config.Controls.Add(this.Sensor1IP);
			this.Sensor1Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sensor1Config.Location = new System.Drawing.Point(0, 0);
			this.Sensor1Config.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor1Config.Name = "Sensor1Config";
			this.Sensor1Config.Padding = new System.Windows.Forms.Padding(10);
			this.Sensor1Config.Size = new System.Drawing.Size(636, 351);
			this.Sensor1Config.TabIndex = 0;
			this.Sensor1Config.TabStop = false;
			this.Sensor1Config.Text = "센서 1 연결설정";
			// 
			// Sensor2Config
			// 
			this.Sensor2Config.Controls.Add(this.label3);
			this.Sensor2Config.Controls.Add(this.label4);
			this.Sensor2Config.Controls.Add(this.Sensor2Connect);
			this.Sensor2Config.Controls.Add(this.Sensor2Port);
			this.Sensor2Config.Controls.Add(this.Sensor2IP);
			this.Sensor2Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Sensor2Config.Location = new System.Drawing.Point(0, 351);
			this.Sensor2Config.Margin = new System.Windows.Forms.Padding(0);
			this.Sensor2Config.Name = "Sensor2Config";
			this.Sensor2Config.Padding = new System.Windows.Forms.Padding(10);
			this.Sensor2Config.Size = new System.Drawing.Size(636, 351);
			this.Sensor2Config.TabIndex = 1;
			this.Sensor2Config.TabStop = false;
			this.Sensor2Config.Text = "센서 2 연결설정";
			// 
			// RobotConfig
			// 
			this.RobotConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RobotConfig.Location = new System.Drawing.Point(636, 0);
			this.RobotConfig.Margin = new System.Windows.Forms.Padding(0);
			this.RobotConfig.Name = "RobotConfig";
			this.RobotConfig.Padding = new System.Windows.Forms.Padding(10);
			this.RobotConfig.Size = new System.Drawing.Size(636, 702);
			this.RobotConfig.TabIndex = 2;
			this.RobotConfig.TabStop = false;
			this.RobotConfig.Text = "로봇 연결설정";
			// 
			// Sensor1IP
			// 
			this.Sensor1IP.BackColor = System.Drawing.Color.Silver;
			this.Sensor1IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sensor1IP.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1IP.Location = new System.Drawing.Point(126, 108);
			this.Sensor1IP.Name = "Sensor1IP";
			this.Sensor1IP.Size = new System.Drawing.Size(497, 34);
			this.Sensor1IP.TabIndex = 0;
			// 
			// Sensor1Port
			// 
			this.Sensor1Port.BackColor = System.Drawing.Color.Silver;
			this.Sensor1Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sensor1Port.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1Port.Location = new System.Drawing.Point(158, 155);
			this.Sensor1Port.Name = "Sensor1Port";
			this.Sensor1Port.Size = new System.Drawing.Size(465, 34);
			this.Sensor1Port.TabIndex = 1;
			// 
			// Sensor1Connect
			// 
			this.Sensor1Connect.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor1Connect.Location = new System.Drawing.Point(13, 210);
			this.Sensor1Connect.Name = "Sensor1Connect";
			this.Sensor1Connect.Size = new System.Drawing.Size(610, 40);
			this.Sensor1Connect.TabIndex = 2;
			this.Sensor1Connect.Text = "연결";
			this.Sensor1Connect.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(8, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP 주소";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(8, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "포트 번호";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(11, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 29);
			this.label3.TabIndex = 9;
			this.label3.Text = "포트 번호";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(11, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "IP 주소";
			// 
			// Sensor2Connect
			// 
			this.Sensor2Connect.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2Connect.Location = new System.Drawing.Point(16, 206);
			this.Sensor2Connect.Name = "Sensor2Connect";
			this.Sensor2Connect.Size = new System.Drawing.Size(610, 40);
			this.Sensor2Connect.TabIndex = 7;
			this.Sensor2Connect.Text = "연결";
			this.Sensor2Connect.UseVisualStyleBackColor = true;
			// 
			// Sensor2Port
			// 
			this.Sensor2Port.BackColor = System.Drawing.Color.Silver;
			this.Sensor2Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sensor2Port.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2Port.Location = new System.Drawing.Point(161, 151);
			this.Sensor2Port.Name = "Sensor2Port";
			this.Sensor2Port.Size = new System.Drawing.Size(465, 34);
			this.Sensor2Port.TabIndex = 6;
			// 
			// Sensor2IP
			// 
			this.Sensor2IP.BackColor = System.Drawing.Color.Silver;
			this.Sensor2IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sensor2IP.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Sensor2IP.Location = new System.Drawing.Point(129, 104);
			this.Sensor2IP.Name = "Sensor2IP";
			this.Sensor2IP.Size = new System.Drawing.Size(497, 34);
			this.Sensor2IP.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(465, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(342, 48);
			this.label5.TabIndex = 0;
			this.label5.Text = "BY PASS 모드";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BypassToggle
			// 
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.Configuration.ResumeLayout(false);
			this.ByPass.ResumeLayout(false);
			this.ByPass.PerformLayout();
			this.Logs.ResumeLayout(false);
			this.Logs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DoorImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DoorLeftDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DoorRightDataGrid)).EndInit();
			this.StatusPanel.ResumeLayout(false);
			this.Sensor1Config.ResumeLayout(false);
			this.Sensor1Config.PerformLayout();
			this.Sensor2Config.ResumeLayout(false);
			this.Sensor2Config.PerformLayout();
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
		private System.Windows.Forms.PictureBox DoorImage;
		private System.Windows.Forms.DataGridView DoorRightDataGrid;
		private System.Windows.Forms.DataGridView DoorLeftDataGrid;
		private System.Windows.Forms.GroupBox StatusPanel;
		private System.Windows.Forms.Label Robot2Status;
		private System.Windows.Forms.Label Robot1Status;
		private System.Windows.Forms.Label Sensor2Status;
		private System.Windows.Forms.Label Sensor1Status;
		private System.Windows.Forms.TextBox LogConsole;
		private System.Windows.Forms.GroupBox Sensor2Config;
		private System.Windows.Forms.GroupBox Sensor1Config;
		private System.Windows.Forms.GroupBox RobotConfig;
		private System.Windows.Forms.TextBox Sensor1IP;
		private System.Windows.Forms.Button Sensor1Connect;
		private System.Windows.Forms.TextBox Sensor1Port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Sensor2Connect;
		private System.Windows.Forms.TextBox Sensor2Port;
		private System.Windows.Forms.TextBox Sensor2IP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BypassToggle;
	}
}

