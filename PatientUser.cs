using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class PatientUser : User
    {
        private int patientID;
        private string bloodGroup;
        private string gender;
       
        private string address;

        public string BloodGroup {  get { return bloodGroup; } set { bloodGroup = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int PatientID { get { return patientID; } set { patientID = value; } }
        public string Address { get { return address; } set { address = value; } }

        public PatientUser() { }
        public PatientUser( string name, int age, string username, string password, int contact_no,int patientID, string bloodGroup, string gender,string address) : base( name, age, username, password, contact_no)
        {
            this.patientID = patientID;
            this.bloodGroup = bloodGroup;
            this.gender = gender;
            this.address = address;
        }


    }
}
