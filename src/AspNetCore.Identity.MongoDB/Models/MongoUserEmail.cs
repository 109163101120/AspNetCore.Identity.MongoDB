using System;

namespace AspNetCore.Identity.MongoDB.Models
{
    public class MongoUserEmail : MongoUserContactRecord
    {
        public MongoUserEmail(string email) : base(email)
        {
        }

        public string NormalizedValue { get; private set; }

        public virtual void SetNormalizedEmail(string normalizedEmail)
        {
            NormalizedValue = normalizedEmail ?? throw new ArgumentNullException(nameof(normalizedEmail));
        }
    }
}
