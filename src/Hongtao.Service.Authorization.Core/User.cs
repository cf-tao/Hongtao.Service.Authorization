using Hongtao.Library.MongoDB.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Hongtao.Service.Authorization.Core
{
    public class User: MongoBase
    {
        public string Name { get; set; }
    }
}