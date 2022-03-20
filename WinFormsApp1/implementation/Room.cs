using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum RoomTypes {Single,Double,Suite}

    public enum RoomViews {Sea,Pool}
    internal class Room
    {
        public int RoomNO { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; } = true;
        public RoomTypes Room_Type { get; set; }
        public RoomViews Room_Views { get; set; }

        public Room(int _roomNo, int _rPrice,  RoomTypes rT, RoomViews rV)
        {
            RoomNO = _roomNo;
            Price = _rPrice;
            Room_Type = rT;
            Room_Views = rV;
        }

        public void ChangeRoomStatus()
        {
            Status = !Status;
        }
        public void UpdateRoom(int _roomNo, int _rPrice, RoomTypes rT)
        {
            RoomNO = _roomNo;
            Price = _rPrice;
            Room_Type = rT;
        }
    }
}
