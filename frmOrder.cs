using CAFE_SHOP_MANAGEMENT.DAO;
using CAFE_SHOP_MANAGEMENT.DTO;
using CAFE_SHOP_MANAGEMENT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_SHOP_MANAGEMENT
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }
        private void loadTable()
        {
            flpanelTable.Controls.Clear();
            List<Table> tables = TableDAO.Instance.LoadTableList();

            foreach (Table item in tables)
            {
                Button btnTable = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeight };
                btnTable.Text = item.Name + Environment.NewLine + item.Status;
                btnTable.Click += BtnTable_Click;
                btnTable.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btnTable.BackColor = Color.LightCyan;
                        break;
                    default:
                        btnTable.BackColor = Color.Aqua;
                        break;
                }
                flpanelTable.Controls.Add(btnTable);
            }
        }
        void ShowBill(int id)           // show bill cho table nao, table id
        {
            lvOrder.Items.Clear();
            List<Menuu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPricee = 0;
            foreach (var item in listBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPricee += item.TotalPrice;
                lvOrder.Items.Add(listViewItem);
            }
            txtTotalPrice.Text = totalPricee.ToString();
            CultureInfo cultureInfo = new CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotalPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotalPrice.Text = String.Format(cultureInfo, "{0:N0}", value);
            txtTotalPrice.Select(txtTotalPrice.Text.Length, 0);
            
        }
        private void BtnTable_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lvOrder.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        private void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetCategories();
            foreach (var item in listCategory)
            {
                Button btnCategory = new Button() { Width = 210, Height = 34 };
                btnCategory.Text = item.Name;
                btnCategory.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnCategory.Tag = item;
                btnCategory.BackColor = Color.LightCyan;
                btnCategory.ForeColor = Color.DarkCyan;
                btnCategory.TextAlign = ContentAlignment.MiddleCenter;
                btnCategory.Click += BtnCategory_Click;
                flpanelCategory.Controls.Add(btnCategory);

            }
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Category).ID;
            loadFoodlistByCategoryID(id);
        }

        private void loadFoodlistByCategoryID(int id)
        {

            List<FoodDrink> foodDrinks = FoodDrinkDAO.Instance.GetFoodDrinksByCategoryID(id);
            cboFoodDrinkName.DataSource = foodDrinks;
            cboFoodDrinkName.DisplayMember = "name";
            cboFoodDrinkName.ValueMember = "id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lvOrder.Tag as Table;
            int idbill = BillDAO.Instance.GetUnCheckBillIdByTableID(table.Id);
            if (cboFoodDrinkName.SelectedItem == null) return;
            int foodid = (cboFoodDrinkName.SelectedItem as FoodDrink).ID;
            int count = (int)nmrCount.Value;
            if (idbill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BilllInfoDAO.Instace.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodid, count);
            }
            else
            {
                
                BilllInfoDAO.Instace.InsertBillInfo(idbill, foodid, count);

            }
            ShowBill(table.Id);
            loadTable();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lvOrder.Tag != null)
            {
                Table table = lvOrder.Tag as Table;
                int idbill = BillDAO.Instance.GetUnCheckBillIdByTableID(table.Id);
                double totalPrice = Convert.ToDouble(Decimal.Parse(txtTotalPrice.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, new CultureInfo("en-US")));
                if (idbill != -1)
                {
                    if (MessageBox.Show("Bạn có chắc thanh toán", "CAFE SHOP MANAGEMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BillDAO.Instance.checkOut(idbill, totalPrice);
                        ShowBill(table.Id);
                        loadTable();
                    }
                }
            }


            
        }
    }
}
