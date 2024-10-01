using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public abstract class AzureObject
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        public IReadOnlyDictionary<string, string> Tags { get; set; }

        protected AzureObject() { }


    }
}
