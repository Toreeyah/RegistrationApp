using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Domain.Common
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }   
        public DateTime CreatedOn { get;set; }

    }
}
