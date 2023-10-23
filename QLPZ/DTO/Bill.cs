using Quanlyquanan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquanan.DTO
{
    class Bill
    {

        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;

        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)row["dateCheckOut"];
            this.status = (int)row["status"];

            //if (row["discount"].ToString() != "")
            //    this.Discount = (int)row["discount"];
        }

        private int iD;

        public int ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get
            {
                return dateCheckIn;
            }
            set
            {
                dateCheckIn = value;
            }
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get
            {
                return dateCheckOut;
            }
            set
            {
                dateCheckOut = value;
            }
        }

        private int status;
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
