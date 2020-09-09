using MSSQL_Connect_Program.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL_Connect_Program
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.Load += FormLoad_Event;
        }

        /// <summary>
        /// 폼 Load 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad_Event(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //Connect to DB
            if (SqlDBManager.Instance.GetConnection() == false)
            {
                string msg = $"Failed to Connect to Database";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                uiLb_Connect.Text = $"DB 연결 성공";
            }

            this.Cursor = Cursors.Default;
        }
    }
}
