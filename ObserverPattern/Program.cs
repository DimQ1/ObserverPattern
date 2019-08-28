using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            company.AddCandidates(new Candidate
            {
                Name = "Dima"
            });

            company.AddCandidates(new Candidate
            {
                Name = "Josh"
            });


            company.AddOpportunity(new Opportunity
            {
                Name = "Team lead!"
            });
        }
    }
}
