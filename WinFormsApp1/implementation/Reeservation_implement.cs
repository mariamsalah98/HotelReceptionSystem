using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public enum Status {CHECKEDIN , CHECKEDOUT ,INACTIVE }
    public class ReservationClass
    {
        public int Reservation_Id { get; set; }
        public string Guest_id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
       public int Room_Number { get; set; }
       public  string BillNo { get; set; }
       public  Status status { get; set; }


    }
}
