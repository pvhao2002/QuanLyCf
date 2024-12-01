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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DoanhThu.DoanhThu' table. You can move, or remove it, as needed.
            this.DoanhThuTableAdapter.Fill(this.DoanhThu._DoanhThu);

            this.reportViewer1.RefreshReport();
        }
    }
}
