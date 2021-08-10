using System;
using System.Collections.Generic;
using System.Text;

namespace VMS.Entity
{
    class UserDetail
    {
        private string UserName { get; set; }
        private string Name { get; set; }
        private string FatherName { get; set; }
        private string MotherName { get; set; }
        private string Gender { get; set; }
        private DateTime DateOfBirth { get; set; }
        private string Address { get; set; }
        private string NID { get; set; }

        public UserDetail()
        {

        }
    }
}
