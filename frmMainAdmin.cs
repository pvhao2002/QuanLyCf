using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAFE_SHOP_MANAGEMENT.DAO;
using CAFE_SHOP_MANAGEMENT.DTO;
namespace CAFE_SHOP_MANAGEMENT
{
    public partial class frmMainAdmin : Form
    {
        frmLogin oldMain;
        public frmMainAdmin(frmLogin frmLogin)
        {
            InitializeComponent();
            oldMain = frmLogin;
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            frmDoanhThu frmDoanhThu = new frmDoanhThu();
            frmDoanhThu.TopLevel = false;
            panelForm.Controls.Add(frmDoanhThu);
            frmDoanhThu.Dock = DockStyle.Fill;
            frmDoanhThu.Show();
        }

        private void btnFoodDrink_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            frmFoodDrink frmFoodDrink = new frmFoodDrink();
            frmFoodDrink.TopLevel = false;
            panelForm.Controls.Add(frmFoodDrink);
            frmFoodDrink.Dock = DockStyle.Fill;
            frmFoodDrink.Show();
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            frmTable frmTable = new frmTable();
            frmTable.TopLevel = false;
            panelForm.Controls.Add(frmTable);
            frmTable.Dock = DockStyle.Fill;
            frmTable.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();            
            frmAccount frmAccount = new frmAccount();
            frmAccount.TopLevel = false;
            panelForm.Controls.Add(frmAccount);
            frmAccount.Dock = DockStyle.Fill;
            frmAccount.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "CAFE SHOP MANAGEMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            oldMain.Show();
            oldMain.ResetAllTextBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            frmReport frmReport = new frmReport();
            frmReport.TopLevel = false;
            panelForm.Controls.Add(frmReport);
            frmReport.Dock = DockStyle.Fill;
            frmReport.Show();
        }
    }
}
