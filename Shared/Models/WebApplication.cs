using Shared.Models.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    internal class WebApplication : AzureObject
    {
        public string WebApplicationId => Id;
        public string WebApplicationName => Name;
        public WebApplicationStatus Status {  get; set; }

        public WebApplication() { }

        public WebApplication(string webApplicationId, string webApplicationName, WebApplicationStatus status, IReadOnlyDictionary<string, string> tags) : base()
        {
            Id = webApplicationId;
            Name = webApplicationName;
            Status = status;
            Tags = tags;
        }

    }
}
