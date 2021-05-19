using Hongtao.Library.MongoDB.Models;

namespace Hongtao.Service.Authorization.Core
{
    public class SecurityInfo : MongoBase
    {
        public string UserId { get; set; }
        public string Hashed { get; set; }
        public string Salt { get; set; }
    }
}