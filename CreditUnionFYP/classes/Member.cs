using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditUnionFYP.classes
{
    class Member
    {
        public string fName;
        public string lName;
        public byte gender;
        public byte maritalStatus;
        public string maidenName;
        public string nic;
        public DateTime dob;
        public DateTime entryDate;
        public DateTime createdDate;
        public byte createdBy;
        public byte paidEntry;


        public Member(string _fname, string _lname, byte _gender, byte _maritalStatus, string _maidenName, string _nic, DateTime _dob,DateTime _entryDate)
        {
            fName = _fname;
            lName = _lname;
            gender = _gender;
            maritalStatus = _maritalStatus;
            maidenName = _maidenName;
            nic = _nic;
            dob = _dob;
            entryDate = _entryDate;
        }
    }
}
