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
        public string Nid { get; set; }

        public UserDetail()
        {

        }

        public UserDetail(string username, string name, string fatherName, string motherName, string gender, DateTime dateOfBirth, string nid, string address)
        {
            UserName = username;
            Name = name;
            FatherName = fatherName;
            MotherName = motherName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
            Nid = nid;
        }
    }
}
