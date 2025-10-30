using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class DocUser:User
    {
        private string department;
        private int doctorID;
        private int roomno;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int DoctorID
        {
            get { return doctorID; }
            set { doctorID = value; }
        }
        public int Roomno {  get { return roomno; } set { roomno = value; } }

        public DocUser() { }
        public DocUser(string name, int age, string username, string password, int contact_no, string department, int doctorID, int roomno): base (name, age, username, password, contact_no)
        {
            this.department = department;
            this.doctorID = doctorID;
            this.roomno = roomno;
          
        }
    }
}
