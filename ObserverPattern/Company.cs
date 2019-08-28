using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public class Company
    {
        private List<Candidate> candidates;
        private ObservableCollection<Opportunity> opportunities;

        public Company()
        {
            this.candidates = new List<Candidate>();
            this.opportunities = new ObservableCollection<Opportunity>();

            this.opportunities.CollectionChanged += CollectionChangeEvent;

        }

        private void CollectionChangeEvent(object sender, NotifyCollectionChangedEventArgs eventArgs)
        {
            if (eventArgs.Action == NotifyCollectionChangedAction.Add)
            {
                this.candidates.ForEach(candiate => candiate.Notify((eventArgs.NewItems[0] as Opportunity).Name));
            }
        }

        public void AddCandidates(Candidate candidate)
        {
            this.candidates.Add(candidate);
        }

        public void RemoveCandidate(Candidate candidate)
        {
            this.candidates.Remove(candidate);
        }

        public void AddOpportunity(Opportunity opportunity)
        {
            this.opportunities.Add(opportunity);
        }
    }
}
