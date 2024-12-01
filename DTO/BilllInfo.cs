using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_SHOP_MANAGEMENT.DTO
{
    public class BilllInfo
    {
        private int iD;
        private int iDBill;
        private int iDFood;
        private int count;
        public BilllInfo(int id, int billId, int Foodid, int count)
        {
            this.iD = id;
            this.iDBill = billId;
            this.iDFood = Foodid;
            this.count = count;
        }
        public BilllInfo(BillInfo bill )
        {
            this.iD = bill.id;
            this.iDBill = bill.idBill;
            this.iDFood = bill.idFood;
            this.count = bill.count;
        }
        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
