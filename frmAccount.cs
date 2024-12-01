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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        bool Add = false;
        CafeShopManagementSystemDataContext db = null;
        private void loaddulieu_Account()
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var lin1 = from p in db.Accounts
                           join plist in db.AccountTypes
                           on p.typeID equals plist.id
                           select new
                           {
                               Username = p.username,
                               DisplayName = p.displayName,
                               PassWord = p.password,
                               Type = plist.name,
                               Sex = p.sex,
                               Address = p.address,
                               BirthDay = p.birthday
                           };
                dgvAccount.DataSource = lin1;
                dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAccount.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            }
        }
        public void ResetAllTextBox_Account()
        {
            rtxtDisplayName.ResetText();
            rtxtUserName.ResetText();
            rtxtPassword.ResetText();
            cboAccountType.ResetText();
            rtxtSex.ResetText();
            rtxtAddress.ResetText();
            dtpBirthday.ResetText();
        }



       private  void SetBtEdit_On_Account()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grpanel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvAccount.Enabled = false;

        }
        private void SetBtEdit_Off_Account()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grpanel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dgvAccount.Enabled = true;
            Add = false;
        }

        private void LoadData_Account()
        {
            ResetAllTextBox_Account();
            SetBtEdit_Off_Account();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox_Account();
            SetBtEdit_On_Account();
            rtxtUserName.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dgvAccount_CellClick(null, null);
            SetBtEdit_On_Account();
            rtxtDisplayName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                if (Add) // Thêm dữ liệu
                {
                    try  {
                        Account acc = new Account();
                        acc.username = rtxtUserName.Text;
                        acc.displayName = rtxtDisplayName.Text;
                        acc.password = rtxtPassword.Text;
                        if (cboAccountType.SelectedIndex == 0)    acc.typeID = 1;
                        else if (cboAccountType.SelectedIndex == 1) acc.typeID = 2;
                        acc.sex = rtxtSex.Text;
                        acc.address = rtxtAddress.Text;
                        acc.birthday = DateTime.Parse(dtpBirthday.Text);
                        db.Accounts.InsertOnSubmit(acc);
                        db.SubmitChanges();
                        loaddulieu_Account();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch (Exception Ex) {
                        MessageBox.Show("LỖI THÊM RỒI , LÝ DO NÈ : " + Ex.Message);
                    }
                }
                else // sua du lieu
                {
                    try     {
                        int r = dgvAccount.CurrentCell.RowIndex;
                        string tempDID = dgvAccount.Rows[r].Cells[0].Value.ToString();
                        Account accc = db.Accounts.Where(s => s.username == tempDID).Single();
                        accc.displayName = rtxtDisplayName.Text;
                        accc.password = rtxtPassword.Text;
                        if (cboAccountType.SelectedIndex == 0)    accc.typeID = 1;
                        else if (cboAccountType.SelectedIndex == 1)    accc.typeID = 2;
                        accc.sex = rtxtSex.Text;
                        accc.address = rtxtAddress.Text;
                        accc.birthday = DateTime.Parse(dtpBirthday.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Lưu thành công");
                        loaddulieu_Account();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("LỖI LƯU RỒI , LÝ DO NÈ : " + ex.Message);
                    }
                }
                SetBtEdit_Off_Account();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SetBtEdit_Off_Account();
            ResetAllTextBox_Account();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                try   {
                    int r = dgvAccount.CurrentCell.RowIndex;
                    string tempDID = dgvAccount.Rows[r].Cells[0].Value.ToString();
                    Account acc = db.Accounts.Where(s => s.username == tempDID).Single();
                    db.Accounts.DeleteOnSubmit(acc);
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SubmitChanges();
                    loaddulieu_Account();
                }
                catch (Exception ex)  {
                    MessageBox.Show("LỖI RỒI RỒI , LÝ DO NÈ: " + ex.Message);
                }
            }
            SetBtEdit_Off_Account();
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAccount.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            rtxtUserName.Text = dgvAccount.Rows[r].Cells[0].Value.ToString();
            rtxtDisplayName.Text = dgvAccount.Rows[r].Cells[1].Value.ToString();
            rtxtPassword.Text = dgvAccount.Rows[r].Cells[2].Value.ToString();
            cboAccountType.Text = dgvAccount.Rows[r].Cells[3].Value.ToString();
            rtxtSex.Text = dgvAccount.Rows[r].Cells[4].Value.ToString();
            rtxtAddress.Text = dgvAccount.Rows[r].Cells[5].Value.ToString();
            dtpBirthday.Text = dgvAccount.Rows[r].Cells[6].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from f in db.Accounts
                           join fa in db.AccountTypes
                           on f.typeID equals fa.id
                           where f.username.Contains(rtxtSearch.Text) == true
                           select new
                           {
                               f.username,
                               f.displayName,
                               f.password,
                               fa.name,
                               f.sex,
                               f.address,
                               f.birthday

                           };
                dgvAccount.DataSource = list;
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadData_Account();
            loaddulieu_Account();
        }

        private void rtxtUserName_Leave(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from p in db.Accounts
                           where p.username.Contains(rtxtUserName.Text) == true
                           select p;
                if(list.Count() > 0)
                {
                    rtxtUserName.ResetText();
                    MessageBox.Show("Đã tồn tại tài khoản này!");
                    rtxtUserName.Focus();
                }    
            }    
        }
    }
}
