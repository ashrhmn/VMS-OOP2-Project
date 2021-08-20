using System.Collections.Generic;
using System.Data;

namespace VMS.Repository
{
    class CandidateRepo
    {
        private DbConnection _dbc;

        public CandidateRepo()
        {
            _dbc = new DbConnection();
        }


        public DataTable GetCandidateDataTable()
        {
            return _dbc.GetDataTable(("select username, (select case when username in (select username from candidates) then 'Yes' else 'No' end) as isCandidate from user_credentials where role='General Public'"));
        }
        public DataTable GetCandidateListTable()
        {
            return _dbc.GetDataTable(("select username from candidates"));
        }

        public bool SetUserAsCandidate(string username)
        {
            return _dbc.IsExecuted(("insert into candidates values('"+username+"')"));
        }

        public bool RemoveUserFromCandidate(string username)
        {
            return _dbc.IsExecuted("delete from candidates where username='"+username+"'");
        }
    }
}
