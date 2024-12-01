using CAFE_SHOP_MANAGEMENT.DAO;
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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        public void LoadListBill(DateTime TimeIn, DateTime TimeOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBillByDate(TimeIn, TimeOut);
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadListBill(dtpFromDate.Value, dtpToDate.Value);
        }
    }
}
