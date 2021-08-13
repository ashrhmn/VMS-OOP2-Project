using System;
using System.Collections.Generic;
using System.Text;
using VMS.Entity;

namespace VMS.Repository
{
    class UserDetailRepo
    {
        private DbConnection dbc;

        public UserDetailRepo()
        {
            dbc = new DbConnection();
        }

        public UserDetail GetUserDetail(string username)
        {
            var list =
                dbc.GetDataTableAsList<UserDetail>("select * from user_details where username='" + username + "'");
            if (list.Count != 1)
            {
                return null;
            }
            return list[0];
        }

        public bool UpdateUserDetail(UserDetail userDetail)
        {
            return dbc.IsExecuted("update user_details set name='" + userDetail.Name + "',gender='" + userDetail.Gender + "',address='" + userDetail.Address + "',fatherName='" + userDetail.FatherName + "',motherName='" + userDetail.MotherName + "',dateOfBirth='" + userDetail.DateOfBirth + "',nid='" + userDetail.NID + "' where username='"+userDetail.UserName+"'");
        }

        public bool NewUserDetail(UserDetail userDetail)
        {
            return dbc.IsExecuted("insert into user_details (username, name, gender, address, fatherName, MotherName, dateOfBirth, nid) values('" + userDetail.UserName + "','" + userDetail.Name + "','" + userDetail.Gender + "','" + userDetail.Address + "','" + userDetail.FatherName + "','" + userDetail.MotherName + "','" + userDetail.DateOfBirth + "','" + userDetail.NID + "')");
        }

        public bool SaveUserDetail(UserDetail userDetail)
        {
            if (dbc.DataExists("select username from user_details where username='"+userDetail.UserName+"'"))
            {
                return UpdateUserDetail(userDetail);
            }
            else
            {
                return NewUserDetail(userDetail);
            }
        }

    }
}
