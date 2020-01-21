using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI
{
    public partial class MainForm : Form
    {
        private Point mousePosition;
        private readonly Dictionary<object, int> tabList = new Dictionary<object, int>();

        public MainForm()
        {
            InitializeComponent();

            tabList.Add(MainTabButton, 0);
            tabList.Add(ConfigTabButton, 1);
            tabList.Add(StatisticsTabButton, 2);
            tabList.Add(BypassTabButton, 3);
            tabList.Add(LogTabButton, 4);

            foreach (var button in tabList.Keys)
                (button as Button).BackColor = Color.DarkGray;
            MainTabButton.BackColor = Color.White;
        }
        #region 윈도우 UI 기본동작
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
        #region 탭 메뉴 동작
        private void TabButton_Click(object sender, EventArgs e)
        {
            TabMenu.SelectedIndex = tabList[sender];
            foreach (var button in tabList.Keys)
                (button as Button).BackColor = Color.DarkGray;
            (sender as Button).BackColor = Color.White;
        }
        #endregion
    }
}