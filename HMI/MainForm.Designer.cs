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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Main = new System.Windows.Forms.TabPage();
			this.Configuration = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.ByPass = new System.Windows.Forms.TabPage();
			this.Logs = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.DimGray;
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
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Main);
			this.tabControl1.Controls.Add(this.Configuration);
			this.tabControl1.Controls.Add(this.Statistics);
			this.tabControl1.Controls.Add(this.ByPass);
			this.tabControl1.Controls.Add(this.Logs);
			this.tabControl1.Location = new System.Drawing.Point(0, 40);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1280, 760);
			this.tabControl1.TabIndex = 2;
			// 
			// Main
			// 
			this.Main.Location = new System.Drawing.Point(4, 30);
			this.Main.Margin = new System.Windows.Forms.Padding(0);
			this.Main.Name = "Main";
			this.Main.Size = new System.Drawing.Size(1272, 726);
			this.Main.TabIndex = 0;
			this.Main.Text = "메인";
			this.Main.UseVisualStyleBackColor = true;
			// 
			// Configuration
			// 
			this.Configuration.Location = new System.Drawing.Point(4, 30);
			this.Configuration.Margin = new System.Windows.Forms.Padding(0);
			this.Configuration.Name = "Configuration";
			this.Configuration.Size = new System.Drawing.Size(1272, 726);
			this.Configuration.TabIndex = 1;
			this.Configuration.Text = "설정";
			this.Configuration.UseVisualStyleBackColor = true;
			// 
			// Statistics
			// 
			this.Statistics.Location = new System.Drawing.Point(4, 30);
			this.Statistics.Name = "Statistics";
			this.Statistics.Size = new System.Drawing.Size(1272, 726);
			this.Statistics.TabIndex = 2;
			this.Statistics.Text = "통계";
			this.Statistics.UseVisualStyleBackColor = true;
			// 
			// ByPass
			// 
			this.ByPass.Location = new System.Drawing.Point(4, 30);
			this.ByPass.Name = "ByPass";
			this.ByPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ByPass.Size = new System.Drawing.Size(1272, 726);
			this.ByPass.TabIndex = 3;
			this.ByPass.Text = "ByPass";
			this.ByPass.UseVisualStyleBackColor = true;
			// 
			// Logs
			// 
			this.Logs.Location = new System.Drawing.Point(4, 30);
			this.Logs.Name = "Logs";
			this.Logs.Size = new System.Drawing.Size(1272, 726);
			this.Logs.TabIndex = 4;
			this.Logs.Text = "기록";
			this.Logs.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.TitleBar);
			this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Tango_Project";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Main;
		private System.Windows.Forms.TabPage Configuration;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.TabPage ByPass;
		private System.Windows.Forms.TabPage Logs;
	}
}

