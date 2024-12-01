using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAFE_SHOP_MANAGEMENT.DAO;
using CAFE_SHOP_MANAGEMENT.DTO;
namespace CAFE_SHOP_MANAGEMENT
{
    public partial class frmTable : Form
    {
        string connstr = @"Data Source=KIRA;Initial Catalog=CafeShop;Integrated Security=True";

        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào Data Table SqlStore
        SqlDataAdapter adTableFood = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtTableFood = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        public frmTable()
        {
            InitializeComponent();
        }



        void ResetAllTextBox()
        {
            rtxtTableID.ResetText();
            rtxtTableName.ResetText();
            cboTableStatus.ResetText();
        }
        void SetBtnEdit_On()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            grboxTableFood.Enabled = true;
            // Enable các control Add, Edit, Delete, Exit...
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvTableFood.Enabled = false;
        }
        void SetBtnEdit_Off()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            grboxTableFood.Enabled = false;
            // Enable các control Add, Edit, Delete, Exit...
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            dgvTableFood.Enabled = true;
            Add = false;
        }

        void LoadData()
        {
            ResetAllTextBox();
            SetBtnEdit_Off();
            // Không kích hoạt các control Save, Cancel, Panel chưa các text
            //Tạo kết nối
            try
            {
                conn = new SqlConnection(connstr);
                adTableFood = new SqlDataAdapter("SELECT * FROM TableFood", conn);
                dtTableFood = new DataTable();
                adTableFood.Fill(dtTableFood);
                dgvTableFood.DataSource = dtTableFood;
                dgvTableFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTableFood.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvTableFood.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng TableFood", "Lỗi dữ liệu!");
            }
        }
        void CheckTableFoodIDExit()
        {
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                // Thực hiện lệnh
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lệnh kiem tra
                cmd.CommandText = "SELECT Count(*) FROM TableFood WHERE id = '" + rtxtTableID.Text.Trim() + "'";

                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("TableFood ID (" + rtxtTableID.Text.Trim() + ") đã có. Nhập lại!");
                    rtxtTableID.ResetText();
                    rtxtTableID.Focus();
                }
                else
                {
                    rtxtTableName.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
            finally
            {
                conn.Close();
            }
        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadData();
            rtxtTableID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            ResetAllTextBox();
            // Kích hoạt chế độ nhập/sửa dữ liệu
            SetBtnEdit_On();
            // Đưa con trỏ đến đầu TextBox Stores ID
            rtxtTableID.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dgvTableFood_CellClick(null, null);
            SetBtnEdit_On();
            rtxtTableID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rtxtTableID.Text.Equals("") || !rtxtTableName.Text.Equals(""))
            {
                // Mở kết nối
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (Add) // Thêm dữ liệu
                {
                    try{
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO TableFood VALUES(N'" + rtxtTableName.Text + "', N'" + cboTableStatus.Text + "')";
                        cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Đã thêm TableFood thành công!");
                    }
                    catch (SqlException) {

                        MessageBox.Show(cmd.CommandText);
                    }
                }
                else // sua doi
                {
                    try{
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        int r = dgvTableFood.CurrentCell.RowIndex;// MaKH hiện hành
                        string strIdBill = dgvTableFood.Rows[r].Cells[0].Value.ToString();
                        cmd.CommandText = "UPDATE TableFood SET " + "name = N'" + rtxtTableName.Text + "', status = N'" +
                            cboTableStatus.Text + "' WHERE id = '" + strIdBill + "'";
                        cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Đã sửa TableFood xong!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(cmd.CommandText);// "Không sửa được. Lỗi rồi!");
                    }
                }
                // Đóng kết nối
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SetBtnEdit_Off();
            ResetAllTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra User có muốn xóa hàng dữ liệu
            DialogResult CheckYN;
            CheckYN = MessageBox.Show("Có chắc xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckYN == DialogResult.Yes)
            {
                // Mở kết nối
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                try  {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lấy Row hiện tại
                    int r = dgvTableFood.CurrentCell.RowIndex;
                    // Store_ID của record hiện hành
                    string TableFoodID = dgvTableFood.Rows[r].Cells[0].Value.ToString();
                    // Lệnh truy vấn SQL
                    cmd.CommandText = "DELETE FROM TableFood WHERE id='" + TableFoodID + "'";
                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();
                    // Cập nhật lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công BillInfo ID =" + TableFoodID + ".");
                }
                catch (SqlException) {
                    MessageBox.Show("Không xóa được TableFood.");
                }
                finally {
                    conn.Close();
                }
            }
            SetBtnEdit_Off();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetAllTextBox();
            SetBtnEdit_Off();
            // Không kích hoạt các control Save, Cancel, Panel chưa các text
            //Tạo kết nối
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                adTableFood = new SqlDataAdapter("SELECT * FROM TableFood WHERE name LIKE %'" + rtxtSearch + "%", conn);
                dtTableFood = new DataTable();
                adTableFood.Fill(dtTableFood);
                dgvTableFood.DataSource = dtTableFood;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng TableFood", "Lỗi dữ liệu!");
            }
        }

        private void dgvTableFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dgvTableFood.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            rtxtTableID.Text = dgvTableFood.Rows[r].Cells[0].Value.ToString();
            rtxtTableName.Text = dgvTableFood.Rows[r].Cells[1].Value.ToString();
            cboTableStatus.Text = dgvTableFood.Rows[r].Cells[2].Value.ToString();
            btnEdit.Enabled = true;
        }

        private void rtxtTableID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckTableFoodIDExit();
            }
        }
    }
}
