using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    public class Member
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
        public List<MemberAddress> address;


        public Member(string _fname, string _lname, byte _gender, byte _maritalStatus, string _maidenName, string _nic, DateTime _dob, DateTime _entryDate, List<MemberAddress> _address)
        {
            fName = _fname;
            lName = _lname;
            gender = _gender;
            maritalStatus = _maritalStatus;
            maidenName = _maidenName;
            nic = _nic;
            dob = _dob;
            entryDate = _entryDate;
            address = _address;

        }
    }
    public class MemberAddress{

    }

}
