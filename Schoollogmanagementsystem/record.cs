using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoollogmanagementsystem
{
    public class record
    {
        [BsonID]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string studentID { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
       public string gender { get; set; }
        public decimal contactno { get; set; }
        public int age { get; set; }
        public int gradelvl { get; set; }
        public string guardianname { get; set; }        
    }
}
