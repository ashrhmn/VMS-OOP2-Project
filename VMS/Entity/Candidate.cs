namespace VMS.Entity
{
    class Candidate
    {
        public bool IsCandidate { get; set; }


        public Candidate()
        {

        }
        public Candidate(string username, bool isCandidate)
        {
            IsCandidate = isCandidate;
        }


    }
}
