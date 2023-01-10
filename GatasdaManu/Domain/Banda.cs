using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GatasdaManu.Domain
{
    public class Banda
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]

        public string _id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Year")]
        public int Year { get; set; }
    }
}

