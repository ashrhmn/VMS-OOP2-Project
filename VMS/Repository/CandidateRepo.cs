using System;
using System.Collections.Generic;
using System.Text;

namespace VMS.Repository
{
    class CandidateRepo
    {
        private DBConnection dbc;

        public CandidateRepo()
        {
            dbc = new DBConnection();
        }

        public List<Entity.Candidate> GetCandidateList()
        {
            return dbc.GetDataTableAsList<Entity.Candidate>("select * from candidates");
        }
    }
}
