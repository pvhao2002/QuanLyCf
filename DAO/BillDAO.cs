using CAFE_SHOP_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        CafeShopManagementSystemDataContext db = null;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUnCheckBillIdByTableID(int id)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                var list = from p in db.Bills
                           where p.idTable == id && p.status == "Chưa thanh toán"
                           select p;
                if (list.Count() > 0)
                {
                    Billl bill = new Billl(list.FirstOrDefault());
                    return bill.Id;
                }
                return -1;
            }
        }
        public void checkOut(int id, double totalprice)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                try
                {
                    Bill bill = db.Bills.Where(s => s.id == id).Single();
                    bill.timeOut = DateTime.Now;
                    bill.status = "Đã thanh toán";
                    bill.totalPrice = totalprice;
                    db.SubmitChanges();
                }
                catch
                {
                    return;
                }
            }
        }

        public void InsertBill(int id)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                try
                {
                    Bill bill = new Bill();
                    bill.idTable = id;
                    bill.totalPrice = 0;
                    bill.discount = 0;
                    bill.timeIn = DateTime.Now;
                    bill.timeOut = null;
                    bill.status = "Chưa thanh toán";
                    db.Bills.InsertOnSubmit(bill);
                    db.SubmitChanges();
                }
                catch (Exception)
                {                    
                    return;
                }
            }
        }

        public int GetMaxIdBill()
        {
            int id = 1;
            using (db = new CafeShopManagementSystemDataContext())
            {
                id = (from p in db.Bills
                      select p.id).Max();
            }
            return id;

        }
        public DataTable GetListBillByDate(DateTime TimeIn, DateTime TimeOut)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDate @TimeIn , @TimeOut", new object[] { TimeIn, TimeOut });
        }
    }
}
