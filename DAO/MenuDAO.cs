using System;
using System.Collections.Generic;
using System.Linq;

using CAFE_SHOP_MANAGEMENT.DTO;

namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        CafeShopManagementSystemDataContext db = null;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menuu> GetListMenuByTable(int id)
        {

            List<Menuu> listMenu = new List<Menuu>();
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from bi in db.BillInfos
                           join b in db.Bills on bi.idBill equals b.id
                           join f in db.Foods on bi.idFood equals f.id
                           where b.idTable == id && b.status.Equals("Chưa thanh toán") == true
                           select new
                           {
                               f.name,
                               bi.count,
                               f.price,
                               TotalPrice = f.price * bi.count
                           };
                foreach (var item in list)
                {
                    string fname = item.name;
                    int count = item.count;
                    double fprice = item.price;
                    double ftotalprice = item.TotalPrice;
                    Menuu menu = new Menuu(fname, count, fprice, ftotalprice);
                    listMenu.Add(menu);
                }
            }

            return listMenu;
        }
    }
}
