using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_SHOP_MANAGEMENT
{
    public partial class frmMainNhanVien : Form
    {
        Account acc;
        frmLogin oldMain;
        public frmMainNhanVien(Account ac, frmLogin frmLogin)
        {
            InitializeComponent();
            acc = ac;
            oldMain = frmLogin;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "CAFE SHOP MANAGEMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            frmUser frmUser = new frmUser(acc);
            frmUser.TopLevel = false;
            panelForm.Controls.Add(frmUser);
            frmUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmUser.Dock = DockStyle.Fill;
            frmUser.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbDateNow.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
            

        }

        private void loadOrderfrm()
        {
            panelForm.Controls.Clear();
            frmOrder frmOrder = new frmOrder();
            frmOrder.TopLevel = false;
            panelForm.Controls.Add(frmOrder);            
            //frmOrder.Dock = DockStyle.Fill;
            frmOrder.Show();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            loadOrderfrm();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lbDateNow_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            oldMain.Show();
            oldMain.ResetAllTextBox();
            this.Close();
           
            
        }
    }
}
