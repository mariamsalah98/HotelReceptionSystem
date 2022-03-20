using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum Type { M, R }
    internal class User
    {
        public int user_id { get; set; }
        public string user_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Tel_No { get; set; }
        public int shift { get; set; }

        public Type type { get; set; }
        public User() { }
        public User(int id, string name, string pass, string mail, string mob, int shi, Type T)
        {
            user_id = id;
            user_Name = name;
            Password = pass;
            Email = mail;
            Tel_No = mob;
            shift = shi;
            type = T;
        }
        public static bool login(string username, string pass, Type type)
        {
            for (int i = 0; i < Data.users.Count; i++)
            {
                if (Data.users[i].user_Name == username && Data.users[i].Password == pass && Data.users[i].type == type)
                    return true;

            }
            return false;
        }

        public static List<ReservationClass> View_Reservation_List()
        {
            //for (int i = 0; i < Data.reservations.Count; i++)
            //{
            //    Console.WriteLine($"id : {Data.reservations[i].Reservation_Id} guestid : {Data.reservations[i].Guest_ID} chieckinDate : " +
            //        $"{Data.reservations[i].CheckIn} checkoutDate : {Data.reservations[i].CheckOut} RoomNumber : {Data.reservations[i].Room_Number} BillNo :{Data.reservations[i].Bill_Number} Status : {Data.reservations[i].status}");
            //}
            return Data.reservations;

        }



        

    }
}
