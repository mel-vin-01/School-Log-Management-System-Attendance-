using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoollogmanagementsystem
{
   public class Userrecord
    {
        [BsonID]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string password { get; set; }
        public string date { get; set; }

    }
}
