using Shared.Models.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ApplicationPlan : AzureObject
    {
        public string ApplicationPlanId => Id;
        public string ApplicationPlanName => Name;
        public ApplicationPlanType ApplicationPlanType { get; set; }

        public ApplicationPlan(string applicationPlanId, string applicationPlanName,ApplicationPlanType applicationPlanType, IReadOnlyDictionary<string, string> tags) : base()
        {
            Id = applicationPlanId;
            Name = applicationPlanName;
            ApplicationPlanType = applicationPlanType;
            Tags = tags;
        }
    }
}
