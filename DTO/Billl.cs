using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_SHOP_MANAGEMENT.DTO
{
    public class Billl
    {
        private int id;
        private double? totalprice;
        private int? discount;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private string status;

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public string Status { get => status; set => status = value; }
        public double? Totalprice { get => totalprice; set => totalprice = value; }
        public int? Discount { get => discount; set => discount = value; }

        public Billl(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, string status, double? pricetotal = 0, int? discount = 0)
        {
            this.id = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.status = status;
            this.Totalprice = pricetotal;
            this.Discount = discount;
        }

        public Billl(Bill a)
        {
            this.id = a.id;
            this.dateCheckIn = a.timeIn;
            var dateCheckOuttmp = a.timeOut;
            if (dateCheckOuttmp.ToString() != "")
                this.dateCheckOut = a.timeOut;
            this.status = a.status;
        }

    }
}
