namespace AkademiApp.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();//Liste oluşturma işlemi yaptım...
        public static IEnumerable<Candidate> Applications = applications;//Listeyi Çağırma işlemi yaptım...

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);//Listeye kişi ekledim..
        }
    }
}
