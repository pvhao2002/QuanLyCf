using CAFE_SHOP_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAFE_SHOP_MANAGEMENT.DAO
{
    public class BilllInfoDAO
    {
        CafeShopManagementSystemDataContext db = null;
        private static BilllInfoDAO instace;
        private BilllInfoDAO() { }
        public static BilllInfoDAO Instace
        {
            get { if (instace == null) instace = new BilllInfoDAO(); return BilllInfoDAO.instace; }
            private set { BilllInfoDAO.instace = value; }
        }

        public List<BilllInfo> GetListBillInfo(int id)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                List<BilllInfo> listBillInfo = new List<BilllInfo>();
                var listBill = from p in db.BillInfos
                               where p.id == id
                               select p;
                foreach (BillInfo item in listBill)
                {
                    BilllInfo info = new BilllInfo(item);
                    listBillInfo.Add(info);

                }

                return listBillInfo;
            }

        }


        public void InsertBillInfo(int idbill, int idfood, int count)
        {
            using (db = new CafeShopManagementSystemDataContext())
            {
                try
                {

                    var list = from p in db.BillInfos
                               where p.idBill == idbill && p.idFood == idfood
                               select new { p.id, p.count };
                    int isExitsBillInfo = 0;
                    int foodCount = 1;
                    if (list.Count() != 0)
                    {
                        isExitsBillInfo = list.First().id;
                        foodCount = list.First().count;
                        if (isExitsBillInfo > 0)
                        {
                            int newcount = foodCount + count;
                            BillInfo b1 = db.BillInfos.Where(s => s.idFood == idfood && s.idBill == idbill).Single();
                            if (newcount > 0)
                                b1.count = newcount;
                            else
                                db.BillInfos.DeleteOnSubmit(b1);

                            db.SubmitChanges();
                        }
                    }
                    else
                    {
                        BillInfo billInfo = new BillInfo();
                        billInfo.idBill = idbill;
                        billInfo.idFood = idfood;
                        billInfo.count = count;
                        db.BillInfos.InsertOnSubmit(billInfo);
                        db.SubmitChanges();
                    }
                }
                catch (Exception)                {
                   
                    return;
                }

            }
        }
    }
}
