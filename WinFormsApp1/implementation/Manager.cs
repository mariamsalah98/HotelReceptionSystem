using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Manager : User
    {
        public List<User> View_Receptionist_info()
        {
            List<User> managers = new List<User>();
            for (int i = 0; i < Data.users.Count; i++)
                if (Data.users[i].type == Type.R) managers.Add(Data.users[i]);
            return managers;
        }

        public static void Add_Receptionist_info(User user)
        {
            Data.users.Add(user);
        }

        public static void Delete_Receptionist_info(int id)
        {
            for (int i = 0; i < Data.users.Count; i++)
            {
                if (Data.users[i].user_id == id)
                    Data.users.Remove(Data.users[i]);
            }

        }

        public static void UpdateRoom(int RoomNo, int newPrice)
        {
            if (Data.rooms.Count == 0) { return; }
            for (int i = 0; i < Data.rooms.Count; i++)
            {
                if (Data.rooms[i].RoomNO == RoomNo)
                {
                    Data.rooms[i].Price = newPrice;
                }
            }
        }
        public static void AddRoom(Room NewRoom)
        {
            Data.rooms.Add(NewRoom);
        }


        //public static List<Feedback> View_Customer_Feedback()
        //{
        //    List<Feedback> feedbacks = new List<Feedback>();
        //    for (int i = 0; i < Data.guests.Count; i++)
        //    {
        //        Feedback feedback = new()
        //        {
        //            guest_id = Data.guests[i].Guest_ID,
        //            guest_name = Data.guests[i].Guest_Name,
        //            feedback = Data.guests[i].Feedback
        //        };
        //        feedbacks.Add(feedback);
        //    }
        //    return feedbacks;


        //}
    }
}
