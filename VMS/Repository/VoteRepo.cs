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
            return dbc.DataExists("select username as voter from votes where username='"+username+"'");
        }

        public string VotedCandidate(string username)
        {
            string candidate =
                dbc.GetSingleData("select * from votes where username = '"+username+"'","candidate");
            return candidate;
        }

        public Boolean VoteCandidate(string username, string candidate)
        {
            return dbc.IsExecuted("insert into votes(username, candidate) values('"+ username + "','"+ candidate + "')");
        }

        public int VoteCount(string candidate)
        {
            return dbc.DataCount("select username from votes where candidate='"+candidate+"'");
        }

        public DataTable CandidateListDataTable()
        {
            return dbc.GetDataTable("select username as candidate from candidates");
        }
        public DataTable CandidateResultDataTable()
        {
            return dbc.GetDataTable("select candidates.username as candidate, (select count(votes.username) from votes where votes.candidate=candidates.username) as voteCount from candidates");
        }
    }
}
