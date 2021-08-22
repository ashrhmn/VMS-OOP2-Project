using VMS.Entity;

namespace VMS.Repository
{
    class UserDetailRepo
    {
        private readonly DbConnection _dbc;

        public UserDetailRepo()
        {
            _dbc = new DbConnection();
        }

        public UserDetail GetUserDetail(string username)
        {
            var list =
                _dbc.GetDataTableAsList<UserDetail>("select * from user_details where username='" + username + "'");
            if (list.Count != 1)
            {
                return null;
            }
            return list[0];
        }

        public bool UpdateUserDetail(UserDetail userDetail)
        {
            return _dbc.IsExecuted("update user_details set name='" + userDetail.Name + "',gender='" + userDetail.Gender + "',address='" + userDetail.Address + "',fatherName='" + userDetail.FatherName + "',motherName='" + userDetail.MotherName + "',dateOfBirth='" + userDetail.DateOfBirth + "',nid='" + userDetail.Nid + "' where username='"+userDetail.UserName+"'");
        }

        public bool NewUserDetail(UserDetail userDetail)
        {
            return _dbc.IsExecuted("insert into user_details (username, name, gender, address, fatherName, MotherName, dateOfBirth, nid) values('" + userDetail.UserName + "','" + userDetail.Name + "','" + userDetail.Gender + "','" + userDetail.Address + "','" + userDetail.FatherName + "','" + userDetail.MotherName + "','" + userDetail.DateOfBirth + "','" + userDetail.Nid + "')");
        }

        public bool SaveUserDetail(UserDetail userDetail)
        {
            if (_dbc.DataExists("select username from user_details where username='"+userDetail.UserName+"'"))
            {
                return UpdateUserDetail(userDetail);
            }
            else
            {
                return NewUserDetail(userDetail);
            }
        }

        public string GetUserFullName(string username)
        {
            return _dbc.GetSingleData("select name from user_details where username='"+username+"'","name");
        }

    }
}
