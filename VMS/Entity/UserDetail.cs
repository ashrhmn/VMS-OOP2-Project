using System;

namespace VMS.Entity
{
    class UserDetail
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string NID { get; set; }

        public UserDetail()
        {

        }

        public UserDetail(string username, string name, string fatherName, string motherName, string gender, DateTime dateOfBirth, string nid, string address)
        {
            this.UserName = username;
            this.Name = name;
            this.FatherName = fatherName;
            this.MotherName = motherName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.NID = nid;
        }
    }
}
