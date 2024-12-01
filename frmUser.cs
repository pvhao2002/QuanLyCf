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
    public partial class frmUser : Form
    {
        Account ac;
        public frmUser(Account account)
        {
            InitializeComponent();
            ac = account;
        }
        private void loadData()
        {
            txtUserName.Text = ac.username.ToString();
            if (checkbShowPassword.Checked == true)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else this.txtPassword.UseSystemPasswordChar = true;
            txtPassword.Text = ac.password.ToString();
            txtDisplayName.Text = ac.displayName.ToString();
            txtBirthDay.Text = ac.birthday.ToLongDateString();
            txtAddress.Text = ac.address.ToString();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadData(); 
        }

        private void checkbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
