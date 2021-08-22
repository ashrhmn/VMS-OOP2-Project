using System;
using System.Data;

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

        public Boolean VoteCandidate(string username, string candidate)
        {
            return dbc.IsExecuted("insert into votes(voter, candidate) values('"+ username + "','"+ candidate + "')");
        }

        public int VoteCount(string candidate)
        {
            return dbc.DataCount("select voter from votes where candidate='"+candidate+"'");
        }

        public DataTable CandidateListDataTable()
        {
            return dbc.GetDataTable("select username as candidate from candidates");
        }
        public DataTable CandidateResultDataTable()
        {
            return dbc.GetDataTable("select username as candidate, (select count(voter) from votes where candidate=username) as voteCount from candidates");
        }
    }
}
