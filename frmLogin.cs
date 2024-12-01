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
    public partial class frmLogin : Form
    {
        CafeShopManagementSystemDataContext db = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        public void ResetAllTextBox()
        {
            txtUserName.ResetText();
            txtPassword.ResetText();
            radAdmin.Checked = true;
            txtUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUserName.Text.Equals("") || !txtPassword.Equals(""))
            {
                using (db = new CafeShopManagementSystemDataContext())
                {
                    var list = from acc in db.Accounts
                               join accType in db.AccountTypes on acc.typeID equals accType.id
                               select acc;
                    bool kt = true;
                    if (radAdmin.Checked == true)
                    {
                        foreach (var item in list)
                        {
                            if (item.typeID == 1 && item.username == txtUserName.Text && item.password == txtPassword.Text)
                            {
                                kt = false;
                                frmMainAdmin frmMainAdmin = new frmMainAdmin(this);
                                this.Hide();
                                frmMainAdmin.Show();
                                ResetAllTextBox();
                            }
                        }
                    }
                    else if (radNhanVien.Checked == true)
                    {
                        foreach (var item in list)
                        {
                            if (item.typeID == 2 && item.username == txtUserName.Text && item.password == txtPassword.Text)
                            {
                                kt = false;
                                Account account = item;
                                frmMainNhanVien frmMain = new frmMainNhanVien(account, this);
                                this.Hide();
                                frmMain.Show();
                                ResetAllTextBox();
                            }
                        }
                    }
                    if (kt)
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "CAFE SHOP MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetAllTextBox();

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "CAFE SHOP MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetAllTextBox();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
            this.radAdmin.Checked = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
