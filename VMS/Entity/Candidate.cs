namespace VMS.Entity
{
    class Candidate
    {
        private string Username { get; set; }
        public bool IsCandidate { get; set; }


        public Candidate()
        {

        }
        public Candidate(string username, bool isCandidate)
        {
            Username = username;
            IsCandidate = isCandidate;
        }


    }
}
