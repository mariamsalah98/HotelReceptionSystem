namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user1 = new() { user_id = 1, user_Name = "mariam", Email = "mariamsalah199829@gmail.com", Password = "12345", shift = 3, Tel_No = "0109310565", type = Type.R };
            User user2 = new() { user_id = 10, user_Name = "Nour", Email = "nourhelmy@gmail.com", Password = "12345", shift = 1, Tel_No = "01099999999", type = Type.M };
            User user3 = new() { user_id = 2, user_Name = "safaa", Email = "safaa@gmail.com", Password = "12345", shift = 2, Tel_No = "010987695", type = Type.R };
            User user4 = new() { user_id = 3, user_Name = "david", Email = "david@gmail.com", Password = "12345", shift = 1, Tel_No = "01000998877", type = Type.R };
            Data.users.Add(user1);
            Data.users.Add(user2);
            Data.users.Add(user3);
            Data.users.Add(user4);


            Room room1 = new(101 ,1000,RoomTypes.Suite,RoomViews.Sea);
            Room room2 = new(102, 500, RoomTypes.Double, RoomViews.Pool);
            Room room3 = new(103, 1000, RoomTypes.Suite, RoomViews.Sea);
            Room room4 = new(104, 500, RoomTypes.Single, RoomViews.Pool);
            Room room5 = new(104, 500, RoomTypes.Double, RoomViews.Sea);
            Data.rooms.Add(room1);
            Data.rooms.Add(room2);
            Data.rooms.Add(room3);
            Data.rooms.Add(room4);
            Data.rooms.Add(room5);


            Guest guest1 = new()
            {
                Guest_ID = "298019970122234",
                Guest_Name = "sara",
                tele_no = "010000000"
            };
            Guest guest2 = new()
            {
                Guest_ID = "298092701000085",
                Guest_Name = "sara",
                tele_no = "010000000"
            };
            Data.guests.Add(guest1);
            Data.guests.Add(guest2);



            Bill bill1 = new() { BillNo = "H_1" };
            ReservationClass reservation1 = new()
            {
                Reservation_Id = 1,
                Guest_id = "298019970122234",
                CheckIn = new DateTime(2022, 3, 1),
                CheckOut = new DateTime(2022, 3, 10),
                Room_Number = 101,
                BillNo = "H_1",
                status = Status.INACTIVE
            };
            Bill bill2 = new() { BillNo = "H_2" };
            ReservationClass reservation2 = new()
            {
                Reservation_Id = 2,
                Guest_id = "298092701000085",
                CheckIn = new DateTime(2022, 3, 1),
                CheckOut = new DateTime(2022, 3, 10),
                Room_Number = 102,
                BillNo = "H_2",
                status = Status.INACTIVE
            };
            Receptionist.Make_Reservation(reservation1);
            Receptionist.Make_Reservation(reservation2);




            ApplicationConfiguration.Initialize();
            Application.Run(new EntryPage());
        }
    }
}