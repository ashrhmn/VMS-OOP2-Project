using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace VMS.Repository
{
    class VoteRepo
    {
        private DbConnection dbc;

        public VoteRepo()
        {
            dbc = new DbConnection();
        }

        public bool HasVoted(string username)
        {
            return dbc.DataExists("select voter from votes where voter='"+username+"'");
        }

        public string VotedCandidate(string username)
        {
            string candidate =
                dbc.GetSingleData("select * from votes where voter = '"+username+"'","candidate");
            return candidate;
        }
    }
}
