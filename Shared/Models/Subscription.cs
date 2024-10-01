using Shared.Models.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Subscription : AzureObject
    {
        public string SubscriptionId {
            get => Id;
            set => Id = value;
        }
                
        public string SubscriptionName
        {
            get => Name;
            set => Name = value;
        }
        public SubscriptionState State { get; set; }

        public Subscription() { }

        public Subscription(string subscriptionId, string subscriptionName, SubscriptionState state, IReadOnlyDictionary<string, string> tags) : base()
        {
            this.Id = subscriptionId;
            this.Name= subscriptionName;
            this.State = state;
            this.Tags = tags;
        }
    }
}
