﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public Bill(int id,DateTime? datecheckin,DateTime? datecheckout,int status)
        {
            this.ID = id;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }
            
            this.Status = (int)row["status"];
        }

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
