using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Receptionist:User
    {
        public static List<Room> Check_Room_avaliability()
        {
            List<Room> ava_rooms = new List<Room>();

            for (int i = 0; i < Data.rooms.Count; i++)
            {
                if (Data.rooms[i].Status)
                {
                    ava_rooms.Add(Data.rooms[i]);
                }

            }
            return ava_rooms;
        }

        public static void Checkin(string  guestid)
        {
            
            for (int i = 0; i < Data.reservations.Count; i++)
            {
                
                if (Data.reservations[i].Guest_id == guestid && Data.reservations[i].status == Status.INACTIVE)
                {
                    Data.reservations[i].status = Status.CHECKEDIN;

                    Data.reservations[i].CheckIn = DateTime.Now;
                }
            }
        }
        
        public static void Checkout(string guestid)
        {
            int roomno = default;
            for (int i = 0; i < Data.reservations.Count; i++)
            {
                if (Data.reservations[i].Guest_id == guestid && Data.reservations[i].status == Status.CHECKEDIN)
                {
                    Data.reservations[i].status = Status.CHECKEDOUT;

                    Data.reservations[i].CheckOut = DateTime.Now;
                    roomno = Data.reservations[i].Room_Number;
                }
            }
            for (int i = 0; i < Data.rooms.Count; i++)
            {
                if (Data.rooms[i].RoomNO == roomno)
                {
                    Data.rooms[i].Status = true;
                }
            }
        }


        public static bool Make_Reservation(ReservationClass reserve)
        {
            int roomno = reserve.Room_Number;
            if (Data.reservations.Select(e => e.Reservation_Id).ToList().Contains(reserve.Reservation_Id)) 
                return false;
            else
            {
                Data.reservations.Add(reserve);
                for (int i = 0; i < Data.rooms.Count; i++)
                {
                    if (Data.rooms[i].RoomNO == roomno)
                    {
                        Data.rooms[i].Status = false;
                    }
                }
                return true;
            }
        }

        public static void Cancel_Reservation(int reservation_id)
        {
            int roomno = default;
            for (int i = 0; i < Data.reservations.Count; i++)
            {   
                if (Data.reservations[i].Reservation_Id == reservation_id)
                {
                    roomno = Data.reservations[i].Room_Number;
                    Data.reservations.Remove(Data.reservations[i]);
                }      
            }
            for (int i = 0; i < Data.rooms.Count; i++)
            {
                if (Data.rooms[i].RoomNO == roomno)
                {
                    Data.rooms[i].Status = true;
                }
            }
        }

        public static bool Accept_Customer_Feedback(string guest_id, string FB)
        {
            Feedback_implemenet f;
            for (int i = 0; i < Data.guests.Count; i++)
            {
                if(Data.guests[i].Guest_ID == guest_id)
                {
                    f = new Feedback_implemenet() { Guest_ID = guest_id, FeedBack = FB };
                    Data.feedbacks.Add(f);
                    return true;
                }

            }
             return false;
        }
                   




        public static  string Generate_Bill(int reservation_id)
        {
            Bill bill = new();
            TimeSpan interval = default;
            int days = default;
            for (int i = 0; i < Data.reservations.Count; i++)
            {
                if (Data.reservations[i].Reservation_Id == reservation_id && Data.reservations[i].status == Status.CHECKEDOUT)
                {
                    string billno = "H_" + reservation_id;
                    interval = (Data.reservations[i].CheckOut - Data.reservations[i].CheckIn);
                     days= (interval.Days == 0)?1:interval.Days ;
                    var result = Data.rooms.Where(r => r.RoomNO == Data.reservations[i].Room_Number).Select(e => e).FirstOrDefault();
                    var total = result.Price * days;
                    bill.BillNo = billno;
                    bill.TotalPrice = total ;
                    Data.reservations[i].BillNo = billno;

                }
                
            }
            return $"Bill number : {bill.BillNo} , Total Price for {days} days : {bill.TotalPrice}";
        }
    }
}
