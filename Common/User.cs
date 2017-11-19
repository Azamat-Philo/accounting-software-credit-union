using DataBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    public class User
    {
        Entities db = new Entities();
        public int userId;
        public string userName;
        public byte[] salt;
        public string pwd;
        public string fName;
        public string lName;
        public string designation;
        public bool active;
        public bool uDelete;
        public DateTime? dateCreated;
        public DateTime? dateModified;
        public static int userIdSession;
        public static string userNameSession;
        public static int userIdEdit;


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

        public int CreateUser(User usr)
        {
            int t = 0;
            try
            {
                Entities db = new Entities();
                tblUser user = new tblUser();
                user.fname = usr.fName;
                user.lname = usr.lName;
                user.userName = usr.userName;
                user.uDelete = false;
                user.active = usr.active;
                user.dateCreated = DateTime.Now;
                byte[][] crypt = Common.CryptographyClass.ComputeHash(usr.pwd, "SHA512", null);
                user.pwd = crypt[0];
                user.salt = crypt[1];
                db.tblUsers.Add(user);
                db.SaveChanges();
                t=user.userId;
            }
            catch (Exception e)
            {
                
            }
            return t;
        }

        public int EditUser(User usr)
        {
            int t = 0;
            try
            {
                Entities db = new Entities();
                tblUser user = new tblUser();
                user = (from x in db.tblUsers
                              where x.userId == usr.userId
                        select x).First();
                
                user.userId = Convert.ToInt16(usr.userId);
                user.fname = usr.fName;
                user.lname = usr.lName;
                user.userName = usr.userName;
                user.uDelete = false;
                user.active = usr.active;
                user.dateModified = DateTime.Now;
                db.SaveChanges();
                t = user.userId;
            }
            catch (Exception e)
            {

            }
            return t;
        }

        public int AddPermission(DataGridView dataGridView1,int userId) {
            foreach (DataGridViewRow row in dataGridView1.Rows){
              
                int id = Convert.ToInt16(row.Cells["PermissionId"].Value);
                var permission = db.tblPermissions.Where(s => s.permissionId == id).FirstOrDefault<tblPermission>();
                tblUserPermission usrPermission = new tblUserPermission();
                usrPermission.userId = Convert.ToInt16(userId);
                usrPermission.permissionId = permission.permissionId;
                usrPermission.dateCreated = DateTime.Now;
                usrPermission.uDelete = false;
                db.tblUserPermissions.Add(usrPermission);
                db.SaveChanges();
            }
            return 1;

        }
        public int EditPermission(DataGridView dataGridView1, int userIdEdit)
        {
            (from u in db.tblUserPermissions
                        where u.userId == userIdEdit
                        select u).ToList().ForEach(x => x.uDelete = true);
            /*foreach (var t in stud){
                t.uDelete = true;
            }*/
            int i = this.AddPermission(dataGridView1, userId);
            return i;

        }
    }
}
