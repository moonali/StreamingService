using System;

namespace StreamingService.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Guid SubscriptionId { get; set; }
        public int RemainingSongsThisMonth { get; set; }

    }

}
