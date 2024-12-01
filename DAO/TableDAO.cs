using CAFE_SHOP_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        CafeShopManagementSystemDataContext db = null;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public static int tableWidth = 80;
        public static int tableHeight = 80;
        private TableDAO()
        {

        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from p in db.TableFoods
                           select new { p.id, p.name, p.status };
                foreach (var item in list)
                {
                    Table table = new Table(item.id, item.name, item.status);
                    tableList.Add(table);
                }
            }   
            return tableList;
        }
    }
}
