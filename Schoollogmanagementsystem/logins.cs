using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoollogmanagementsystem
{
    public class logins
    {
        [BsonID]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string studentID { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string date { get; set; }  
        public string timein { get; set; }
        public string timeout { get; set; }
        public bool HasLoggedIn { get; set; }
        public bool HasLoggedOut { get; set; }
    }
}
