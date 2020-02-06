namespace InterlockTest
{
	partial class Form1
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Pass = new System.Windows.Forms.Button();
			this.Ng = new System.Windows.Forms.Button();
			this.BendingPass = new System.Windows.Forms.Button();
			this.BendingNg = new System.Windows.Forms.Button();
			this.PcStatus = new System.Windows.Forms.Button();
			this.PcComError = new System.Windows.Forms.Button();
			this.SensorStatus = new System.Windows.Forms.Button();
			this.SensorDataStatus = new System.Windows.Forms.Button();
			this.Bypass = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.Pass);
			this.flowLayoutPanel1.Controls.Add(this.Ng);
			this.flowLayoutPanel1.Controls.Add(this.BendingPass);
			this.flowLayoutPanel1.Controls.Add(this.BendingNg);
			this.flowLayoutPanel1.Controls.Add(this.PcStatus);
			this.flowLayoutPanel1.Controls.Add(this.PcComError);
			this.flowLayoutPanel1.Controls.Add(this.SensorStatus);
			this.flowLayoutPanel1.Controls.Add(this.SensorDataStatus);
			this.flowLayoutPanel1.Controls.Add(this.Bypass);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// Pass
			// 
			this.Pass.Enabled = false;
			this.Pass.Location = new System.Drawing.Point(3, 3);
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(260, 116);
			this.Pass.TabIndex = 0;
			this.Pass.Text = "PASS";
			this.Pass.UseVisualStyleBackColor = true;
			this.Pass.Click += new System.EventHandler(this.Pass_Click);
			// 
			// Ng
			// 
			this.Ng.Enabled = false;
			this.Ng.Location = new System.Drawing.Point(269, 3);
			this.Ng.Name = "Ng";
			this.Ng.Size = new System.Drawing.Size(260, 116);
			this.Ng.TabIndex = 1;
			this.Ng.Text = "NG";
			this.Ng.UseVisualStyleBackColor = true;
			this.Ng.Click += new System.EventHandler(this.Ng_Click);
			// 
			// BendingPass
			// 
			this.BendingPass.Enabled = false;
			this.BendingPass.Location = new System.Drawing.Point(535, 3);
			this.BendingPass.Name = "BendingPass";
			this.BendingPass.Size = new System.Drawing.Size(260, 116);
			this.BendingPass.TabIndex = 2;
			this.BendingPass.Text = "BENDING_PASS";
			this.BendingPass.UseVisualStyleBackColor = true;
			this.BendingPass.Click += new System.EventHandler(this.BendingPass_Click);
			// 
			// BendingNg
			// 
			this.BendingNg.Enabled = false;
			this.BendingNg.Location = new System.Drawing.Point(3, 125);
			this.BendingNg.Name = "BendingNg";
			this.BendingNg.Size = new System.Drawing.Size(260, 116);
			this.BendingNg.TabIndex = 3;
			this.BendingNg.Text = "BENDING_NG";
			this.BendingNg.UseVisualStyleBackColor = true;
			this.BendingNg.Click += new System.EventHandler(this.BendingNg_Click);
			// 
			// PcStatus
			// 
			this.PcStatus.Location = new System.Drawing.Point(269, 125);
			this.PcStatus.Name = "PcStatus";
			this.PcStatus.Size = new System.Drawing.Size(260, 116);
			this.PcStatus.TabIndex = 4;
			this.PcStatus.Text = "PC_STATUS";
			this.PcStatus.UseVisualStyleBackColor = true;
			this.PcStatus.Click += new System.EventHandler(this.PcStatus_Click);
			// 
			// PcComError
			// 
			this.PcComError.Location = new System.Drawing.Point(535, 125);
			this.PcComError.Name = "PcComError";
			this.PcComError.Size = new System.Drawing.Size(260, 116);
			this.PcComError.TabIndex = 5;
			this.PcComError.Text = "PC_COM_ERROR";
			this.PcComError.UseVisualStyleBackColor = true;
			this.PcComError.Click += new System.EventHandler(this.PcComError_Click);
			// 
			// SensorStatus
			// 
			this.SensorStatus.Location = new System.Drawing.Point(3, 247);
			this.SensorStatus.Name = "SensorStatus";
			this.SensorStatus.Size = new System.Drawing.Size(260, 116);
			this.SensorStatus.TabIndex = 6;
			this.SensorStatus.Text = "SENSOR_STATUS";
			this.SensorStatus.UseVisualStyleBackColor = true;
			this.SensorStatus.Click += new System.EventHandler(this.SensorStatus_Click);
			// 
			// SensorDataStatus
			// 
			this.SensorDataStatus.Enabled = false;
			this.SensorDataStatus.Location = new System.Drawing.Point(269, 247);
			this.SensorDataStatus.Name = "SensorDataStatus";
			this.SensorDataStatus.Size = new System.Drawing.Size(260, 116);
			this.SensorDataStatus.TabIndex = 7;
			this.SensorDataStatus.Text = "SENSOR_DATA_STATUS";
			this.SensorDataStatus.UseVisualStyleBackColor = true;
			this.SensorDataStatus.Click += new System.EventHandler(this.SensorDataStatus_Click);
			// 
			// Bypass
			// 
			this.Bypass.Location = new System.Drawing.Point(535, 247);
			this.Bypass.Name = "Bypass";
			this.Bypass.Size = new System.Drawing.Size(260, 116);
			this.Bypass.TabIndex = 8;
			this.Bypass.Text = "BYPASS";
			this.Bypass.UseVisualStyleBackColor = true;
			this.Bypass.Click += new System.EventHandler(this.Bypass_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button Pass;
		private System.Windows.Forms.Button Ng;
		private System.Windows.Forms.Button BendingPass;
		private System.Windows.Forms.Button BendingNg;
		private System.Windows.Forms.Button PcStatus;
		private System.Windows.Forms.Button PcComError;
		private System.Windows.Forms.Button SensorStatus;
		private System.Windows.Forms.Button SensorDataStatus;
		private System.Windows.Forms.Button Bypass;
	}
}

