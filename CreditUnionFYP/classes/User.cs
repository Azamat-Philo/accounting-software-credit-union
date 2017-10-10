using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditUnionFYP
{
    public class User
    {
        private int userId;
        public string userName;
        private string salt;
        private string pwd;
        public string fName;
        public string lName;
        public string designation;
        public bool active;
        public bool uDelete;
        private DateTime? dateCreated;
        public DateTime? dateModified;

        public User()
        {
           userId = 0;
           userName = null;
           salt = null;
           pwd = null;
           fName = null;
           lName = null;
           designation = null;
           active = false;
           uDelete = false;
           dateCreated =  DateTime.Today;
           dateModified = DateTime.Today;
        }
    }
}
