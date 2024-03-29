﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public string  UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Error in reservation: Reservation dates for update must be future dates";
            }

            if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }
        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in:"
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nigths";
        }
    }
}
