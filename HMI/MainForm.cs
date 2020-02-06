using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Extensions;
using Core.Network;
using Middleware;

namespace HMI
{
    public partial class MainForm : Form
    {
        private const int buffersize = 1500;
        private readonly Controller controller = new Controller();

        public MainForm()
        {
            InitializeComponent();

            controller.Sensor1Connected += Controller_Sensor1Connected;
            controller.Sensor2Connected += Controller_Sensor2Connected;
            controller.Sensor1Sended += Controller_Sensor1Sended;
            controller.Sensor2Sended += Controller_Sensor2Sended;
            controller.Sensor1Received += Controller_Sensor1Received;
            controller.Sensor2Received += Controller_Sensor2Received;
            controller.Sensor1ValueReceived += Controller_Sensor1ValueReceived;
            controller.Sensor2ValueReceived += Controller_Sensor2ValueReceived;
            controller.Sensor1ConnectionRefused += Controller_Sensor1ConnectionRefused;
            controller.Sensor2ConnectionRefused += Controller_Sensor2ConnectionRefused;
            controller.Sensor1Disconnected += Controller_Sensor1Disconnected;
            controller.Sensor2Disconnected += Controller_Sensor2Disconnected;

            controller.Robot1Connected += Controller_Robot1Connected;
            controller.Robot2Connected += Controller_Robot2Connected;
            controller.Robot1Sended += Controller_Robot1Sended;
            controller.Robot2Sended += Controller_Robot2Sended;
            controller.Robot1Received += Controller_Robot1Received;
            controller.Robot2Received += Controller_Robot2Received;
            controller.Robot1PhaseChanged += Controller_Robot1PhaseChanged;
            controller.Robot2PhaseChanged += Controller_Robot2PhaseChanged;
            controller.Robot1Disconnected += Controller_Robot1Disconnected;
            controller.Robot2Disconnected += Controller_Robot2Disconnected;

            controller.ErrorOccurred += Controller_ErrorOccurred;
        }
        #region 윈도우 UI 기본동작
        private Point mousePosition;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                mousePosition = new Point(-e.X, -e.Y);
        }
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + (mousePosition.X + e.X), Location.Y + (mousePosition.Y + e.Y));
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region 로보틱스 네트워크 제어
        private void Controller_Sensor1Connected(object sender, Core.Network.ConnectEventArgs e)
        {
            controller.Sensor1IpAddress = e.IP;
            Sensor1Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
            });
            Sensor1ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
                x.Text = "Connection Succeed";
            });
        }
        private void Controller_Sensor2Connected(object sender, Core.Network.ConnectEventArgs e)
        {
            controller.Sensor2IpAddress = e.IP;
            Sensor2Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
            });
            Sensor2ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
                x.Text = "Connection Succeed";
            });
        }
        private void Controller_Sensor1Sended(object sender, SendEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesSent} Bytes Sended to {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Sensor2Sended(object sender, SendEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesSent} Bytes Sended to {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Sensor1Received(object sender, ReceiveEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesRead} Bytes Readed from {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Sensor2Received(object sender, ReceiveEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesRead} Bytes Readed from {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Sensor1ValueReceived(object sender, SensorValueEventArgs e)
        {
            DateTime time = DateTime.Now;
            Sensor1Data.AsyncInvoke(x =>
            {
                x.Rows.Add(new object[]
                {
                    time, 
                    e.Status, 
                    e.Before.Sensor1, 
                    e.Before.Sensor2,
                    e.After == null ? 0f : e.After.Value.Sensor1,
                    e.After == null ? 0f : e.After.Value.Sensor2,
                    e.Delta == null ? 0f : e.Delta.Value.Sensor1,
                    e.Delta == null ? 0f : e.Delta.Value.Sensor2
                });
            });
            SensorChart.AsyncInvoke(x =>
            {
                if (!x.IsDisposed)
                {
                    x.Series["Sensor1Before"].Points.AddXY(time, e.Before.Sensor1);
                    x.Series["Sensor1After"].Points.AddXY(time, e.After == null ? 0f : e.After.Value.Sensor1);
                    x.Series["Sensor1MaxPlus"].Points.AddXY(time, 3.5f);
                    x.Series["Sensor1MaxMinus"].Points.AddXY(time, -3.5f);
                    x.Series["Sensor1MinPlus"].Points.AddXY(time, 0.75f);
                    x.Series["Sensor1MinMinus"].Points.AddXY(time, -0.75f);

                    x.Series["Sensor2Before"].Points.AddXY(time, e.Before.Sensor2);
                    x.Series["Sensor2After"].Points.AddXY(time, e.After == null ? 0f : e.After.Value.Sensor2);
                    x.Series["Sensor2MaxPlus"].Points.AddXY(time, 3.5f);
                    x.Series["Sensor2MaxMinus"].Points.AddXY(time, -3.5f);
                    x.Series["Sensor2MinPlus"].Points.AddXY(time, 0.75f);
                    x.Series["Sensor2MinMinus"].Points.AddXY(time, -0.75f);

                    x.Series["Sensor1Delta"].Points.AddXY(time, e.Delta == null ? 0f : e.Delta.Value.Sensor1);
                    x.Series["Sensor2Delta"].Points.AddXY(time, e.Delta == null ? 0f : e.Delta.Value.Sensor2);
                }
            });
            switch (e.Status)
            {
                case StatusCode.PASS:
                {
                    Stats1.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["Passed"].Points.Count > 0)
                            {
                                x.Series["Passed"].Points[0].SetValueXY("Passed", x.Series["Passed"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["Passed"].Points.AddXY("Passed", 1);
                        }
                    });
                    break;
                }
                case StatusCode.FAILED:
                {
                    Stats1.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["Failed"].Points.Count > 0)
                            {
                                x.Series["Failed"].Points[0].SetValueXY("Failed", x.Series["Failed"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["Failed"].Points.AddXY("Failed", 1);
                        }
                    });
                    break;
                }
                case StatusCode.FIRST_BENDED:
                {
                    Stats2.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["FirstBended"].Points.Count > 0)
                            {
                                x.Series["FirstBended"].Points[0].SetValueXY("FirstBended", x.Series["FirstBended"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["FirstBended"].Points.AddXY("FirstBended", 1);
                        }
                    });
                    break;
                }
                case StatusCode.SECOND_BENDED:
                {
                    Stats2.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["SecondBended"].Points.Count > 0)
                            {
                                x.Series["SecondBended"].Points[0].SetValueXY("SecondBended", x.Series["SecondBended"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["SecondBended"].Points.AddXY("SecondBended", 1);
                        }
                    });
                    break;
                }
            }
        }
        private void Controller_Sensor2ValueReceived(object sender, SensorValueEventArgs e)
        {
            DateTime time = DateTime.Now;
            Sensor2Data.AsyncInvoke(x =>
            {
                x.Rows.Add(new object[]
                {
                    time,
                    e.Status,
                    e.Before.Sensor1,
                    e.Before.Sensor2,
                    e.After == null ? 0f : e.After.Value.Sensor1,
                    e.After == null ? 0f : e.After.Value.Sensor2,
                    e.Delta == null ? 0f : e.Delta.Value.Sensor1,
                    e.Delta == null ? 0f : e.Delta.Value.Sensor2
                });
            });
            SensorChart.AsyncInvoke(x =>
            {
                if (!x.IsDisposed)
                {
                    x.Series["Sensor1Before"].Points.AddXY(time, e.Before.Sensor1);
                    x.Series["Sensor1After"].Points.AddXY(time, e.After == null ? 0f : e.After.Value.Sensor1);
                    x.Series["Sensor1MaxPlus"].Points.AddXY(time, 3.5f);
                    x.Series["Sensor1MaxMinus"].Points.AddXY(time, -3.5f);
                    x.Series["Sensor1MinPlus"].Points.AddXY(time, 0.75f);
                    x.Series["Sensor1MinMinus"].Points.AddXY(time, -0.75f);

                    x.Series["Sensor2Before"].Points.AddXY(time, e.Before.Sensor2);
                    x.Series["Sensor2After"].Points.AddXY(time, e.After == null ? 0f : e.After.Value.Sensor2);
                    x.Series["Sensor2MaxPlus"].Points.AddXY(time, 3.5f);
                    x.Series["Sensor2MaxMinus"].Points.AddXY(time, -3.5f);
                    x.Series["Sensor2MinPlus"].Points.AddXY(time, 0.75f);
                    x.Series["Sensor2MinMinus"].Points.AddXY(time, -0.75f);

                    x.Series["Sensor1Delta"].Points.AddXY(time, e.Delta == null ? 0f : e.Delta.Value.Sensor1);
                    x.Series["Sensor2Delta"].Points.AddXY(time, e.Delta == null ? 0f : e.Delta.Value.Sensor2);
                }
            });
            switch (e.Status)
            {
                case StatusCode.PASS:
                {
                    Stats1.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["Passed"].Points.Count > 0)
                            {
                                x.Series["Passed"].Points[0].SetValueXY("Passed", x.Series["Passed"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["Passed"].Points.AddXY("Passed", 1);
                        }
                    });
                    break;
                }
                case StatusCode.FAILED:
                {
                    Stats1.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["Failed"].Points.Count > 0)
                            {
                                x.Series["Failed"].Points[0].SetValueXY("Failed", x.Series["Failed"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["Failed"].Points.AddXY("Failed", 1);
                        }
                    });
                    break;
                }
                case StatusCode.FIRST_BENDED:
                {
                    Stats2.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["FirstBended"].Points.Count > 0)
                            {
                                x.Series["FirstBended"].Points[0].SetValueXY("FirstBended", x.Series["FirstBended"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["FirstBended"].Points.AddXY("FirstBended", 1);
                        }
                    });
                    break;
                }
                case StatusCode.SECOND_BENDED:
                {
                    Stats2.AsyncInvoke(x =>
                    {
                        if (!x.IsDisposed)
                        {
                            if (x.Series["SecondBended"].Points.Count > 0)
                            {
                                x.Series["SecondBended"].Points[0].SetValueXY("SecondBended", x.Series["SecondBended"].Points[0].GetValueByName("Y") + 1);
                                x.ResetAutoValues();
                            }
                            else x.Series["SecondBended"].Points.AddXY("SecondBended", 1);
                        }
                    });
                    break;
                }
            }
        }
        private void Controller_Sensor1ConnectionRefused(object sender, ConnectionRefusedEventArgs e)
        {
            Sensor1Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
            Sensor1ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
                x.Text = "Connection Failed";
            });
        }
        private void Controller_Sensor2ConnectionRefused(object sender, ConnectionRefusedEventArgs e)
        {
            Sensor2Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
            Sensor2ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
                x.Text = "Connection Failed";
            });
        }
        private void Controller_Sensor1Disconnected(object sender, Core.Network.DisconnectEventArgs e)
        {
            Sensor1Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
            Sensor1ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
                x.Text = "Connection Failed";
            });
        }
        private void Controller_Sensor2Disconnected(object sender, Core.Network.DisconnectEventArgs e)
        {
            Sensor2Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
            Sensor2ConnectionStatus.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
                x.Text = "Connection Failed";
            });
        }

        private void Controller_Robot1Connected(object sender, Core.Network.ConnectEventArgs e)
        {
            Robot1Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
            });
        }
        private void Controller_Robot2Connected(object sender, Core.Network.ConnectEventArgs e)
        {
            Robot2Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OliveDrab;
            });
        }
        private void Controller_Robot1Sended(object sender, SendEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesSent} Bytes Sended to {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Robot2Sended(object sender, SendEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesSent} Bytes Sended to {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Robot1Received(object sender, ReceiveEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesRead} Bytes Readed from {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Robot2Received(object sender, ReceiveEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][NETWORK] : {e.BytesRead} Bytes Readed from {e.IP}{Environment.NewLine}");
            });
        }
        private void Controller_Robot1PhaseChanged(object sender, RobotPhaseEventArgs e)
        {
        }
        private void Controller_Robot2PhaseChanged(object sender, RobotPhaseEventArgs e)
        {
        }
        private void Controller_Robot1Disconnected(object sender, Core.Network.DisconnectEventArgs e)
        {
            Robot1Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
        }
        private void Controller_Robot2Disconnected(object sender, Core.Network.DisconnectEventArgs e)
        {
            Robot2Status.AsyncInvoke(x =>
            {
                x.BackColor = Color.OrangeRed;
            });
        }

        private void Controller_ErrorOccurred(object sender, Core.Network.ExceptionEventArgs e)
        {
            LogConsole.AsyncInvoke(x =>
            {
                if (!x.IsDisposed) x.AppendText($"[{DateTime.Now}][ERROR] : {e.Message}[{e.ErrorCode}] {e.StackTrace}{Environment.NewLine}");
            });
        }
        #endregion
        #region HMI UI 처리
        private void Sensor1IpAddress_TextChanged(object sender, EventArgs e)
        {
            if (NetworkUtilities.ValidateIPAddress(Sensor1IpAddress.Text, true))
                Sensor1ConnectionStatus.Enabled = true;
            else Sensor1ConnectionStatus.Enabled = false;
        }
        private void Sensor2IpAddress_TextChanged(object sender, EventArgs e)
        {
            if (NetworkUtilities.ValidateIPAddress(Sensor2IpAddress.Text, true))
                Sensor2ConnectionStatus.Enabled = true;
            else Sensor2ConnectionStatus.Enabled = false;
        }
        private void RobotConnectionSave_Click(object sender, EventArgs e)
        {
            try
            {
                int port = Convert.ToInt32(RobotServerPort.Text);
                if (port > 65535) return;
                if (controller.IsRobotServerActive) controller.StopRobotServer();
                controller.StartRobotServer(port, buffersize);
            }
            catch { return; }
        }
        private void Sensor1ConnectionStatus_Click(object sender, EventArgs e)
        {
            string[] parsed = Sensor1IpAddress.Text.Split(':');
            string ip = parsed[0];
            int port = Convert.ToInt32(parsed[1]);
            controller.ConnectToSensor1(ip, port, buffersize);
            Sensor1ConnectionStatus.BackColor = Color.Gold;
            Sensor1ConnectionStatus.Text = "Testing...";
        }
        private void Sensor2ConnectionStatus_Click(object sender, EventArgs e)
        {
            string[] parsed = Sensor2IpAddress.Text.Split(':');
            string ip = parsed[0];
            int port = Convert.ToInt32(parsed[1]);
            controller.ConnectToSensor2(ip, port, buffersize);
            Sensor2ConnectionStatus.BackColor = Color.Gold;
            Sensor2ConnectionStatus.Text = "Testing...";
        }
        private void DbConnectionStatus_Click(object sender, EventArgs e)
        {

        }
        private void Robot1IpAddress_TextChanged(object sender, EventArgs e)
        {
            if (NetworkUtilities.ValidateIPAddress(Robot1IpAddress.Text, false))
                controller.Robot1IpAddress = Robot1IpAddress.Text;
        }
        private void Robot2IpAddress_TextChanged(object sender, EventArgs e)
        {
            if (NetworkUtilities.ValidateIPAddress(Robot2IpAddress.Text, false))
                controller.Robot1IpAddress = Robot2IpAddress.Text;
        }
        #endregion
    }
}