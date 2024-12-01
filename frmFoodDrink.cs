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

    public partial class frmFoodDrink : Form
    {
        public frmFoodDrink()
        {
            InitializeComponent();
        }
        CafeShopManagementSystemDataContext db = null;
        bool Add = false;


        private void loaddulieu()
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var lin1 = from a in db.Foods
                           select new
                           {
                               a.id,
                               a.name,
                               a.idCategory,
                               a.price,
                               a.stateID
                           };

                dgvFoodDrink.DataSource = lin1;
                dgvFoodDrink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFoodDrink.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvFoodDrink.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            }
        }

        void LoadData()
        {
            ResetAllTextBox();
            SetBtEdit_Off();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            ResetAllTextBox();
            SetBtEdit_On();
            rtxtFoodName.Focus();
        }


        private void ResetAllTextBox()
        {
            rtxtFoodID.ResetText();
            rtxtFoodName.ResetText();
            rtxtPrice.ResetText();
            cboFoodCategory.ResetText();
            cboFoodState.ResetText();
        }



        private void SetBtEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grpanel3.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvFoodDrink.Enabled = false;

        }
        private void SetBtEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grpanel3.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dgvFoodDrink.Enabled = true;
            Add = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dgvFoodDrink_CellClick(null, null);
            SetBtEdit_On();
            rtxtFoodName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {

                if (Add) // Thêm dữ liệu
                {
                    try
                    {
                        Food fo = new Food();
                        fo.name = rtxtFoodName.Text;
                        fo.idCategory = int.Parse(cboFoodCategory.Text);
                        fo.price = double.Parse(rtxtPrice.Text);
                        fo.stateID = Int32.Parse(cboFoodState.Text);

                        db.Foods.InsertOnSubmit(fo);
                        db.SubmitChanges();
                        loaddulieu();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("LỖI THÊM RỒI , LÝ DO NÈ : " + Ex.Message);
                    }
                }
                else // sua du lieu
                {

                    try
                    {
                        int r = dgvFoodDrink.CurrentCell.RowIndex;
                        int tempDID = (int)dgvFoodDrink.Rows[r].Cells[0].Value;
                        Food fo = db.Foods.Where(s => s.id == tempDID).Single();

                        fo.name = rtxtFoodName.Text;

                        fo.idCategory = int.Parse(cboFoodCategory.Text);
                        fo.price = double.Parse(rtxtPrice.Text);
                        fo.stateID = Int32.Parse(cboFoodState.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Lưu thành công");
                        loaddulieu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("LỖI LƯU RỒI , LÝ DO NÈ: " + ex.Message);
                    }
                }
                SetBtEdit_Off();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SetBtEdit_Off();
            ResetAllTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                try
                {
                    int r = dgvFoodDrink.CurrentCell.RowIndex;
                    int tempDID = (int)dgvFoodDrink.Rows[r].Cells[0].Value;
                    Food foodlist = db.Foods.Where(s => s.id == tempDID).Single();

                    db.Foods.DeleteOnSubmit(foodlist);
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SubmitChanges();
                    loaddulieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI XÓA RỒI , LÝ DO NÈ: " + ex.Message);
                }
            }
            SetBtEdit_Off();
        }

        private void dgvFoodDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvFoodDrink.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            rtxtFoodID.Text = dgvFoodDrink.Rows[r].Cells[0].Value.ToString();
            rtxtFoodName.Text = dgvFoodDrink.Rows[r].Cells[1].Value.ToString();
            cboFoodCategory.Text = dgvFoodDrink.Rows[r].Cells[2].Value.ToString();
            rtxtPrice.Text = dgvFoodDrink.Rows[r].Cells[3].Value.ToString();
            cboFoodState.Text = dgvFoodDrink.Rows[r].Cells[4].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from f in db.Foods
                           where f.name.Contains(btnSearch.Text) == true
                           select new
                           {
                               f.id,
                               f.name,
                               f.idCategory,
                               f.price,
                               f.stateID
                           };
                dgvFoodDrink.DataSource = list;
            }
        }

        private void frmFoodDrink_Load(object sender, EventArgs e)
        {
            LoadData();
            loaddulieu();
            using (db = new CafeShopManagementSystemDataContext())
            {

                var listCategory = from p in db.FoodCategories
                                   select new { p.id, p.name };
                var listState = from a in db.States
                                select new { a.id, a.name };

                cboFoodCategory.DataSource = listCategory;
                cboFoodCategory.DisplayMember = "id";
                cboFoodCategory.ValueMember = "id";

                cboFoodState.DataSource = listState;
                cboFoodState.ValueMember = "id";
                cboFoodState.DisplayMember = "id";
            }


        }

        private void rtxtFoodName_Leave(object sender, EventArgs e)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                int count = 0;
                var list = from p in db.Foods
                           where p.name.Contains(rtxtFoodName.Text) == true
                           select p;
                count = list.Count();
                if (count > 0)
                {
                    MessageBox.Show("Đã tồn tại món này!");
                    rtxtFoodName.ResetText();
                    rtxtFoodName.Focus();
                }
            }
        }
    }
}
