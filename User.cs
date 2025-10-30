using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class User
    {
      // private int id;
        private string name;
        private int age;
        private string username;
        private string password;
        private int contact_no;


        //public int Id { get { return id; } set { id = value; } }    
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Contact_no { get { return contact_no; } set { contact_no = value; } }
        public User() { }
        public User(string name, int age, string username, string password, int contact_no)
        {
           // this.id = id;
            this.name = name;
            this.age = age;
            this.username = username;
            this.password = password;
            this.contact_no = contact_no;
            
           
        }

       

    }
}
