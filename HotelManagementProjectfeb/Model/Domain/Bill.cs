﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementProjectfeb.Model.Domain
{
    public class Bill
    {
        [Key]
        public Guid Bill_id { get; set; }

        public int stay_dates { get; set; }

        public decimal total_bill { get; set; }
        //room price = adult*1000+child*500 *stay_dates
        public Guid Room_id { get; set; }
              
        public Guid Reservation_id { get; set; }
        public Reservation Reservations { get; set; }

       public Room Rooms { get; set; }

    }
}
