using StreamingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingService.Repositories.Interface
{
   public interface ISubscriptionReposotory
    {
       public Subscription getSubscriptionById(Guid Id);
    }
}
