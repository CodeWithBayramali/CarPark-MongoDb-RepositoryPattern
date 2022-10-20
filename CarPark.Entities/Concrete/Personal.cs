using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDbGenericRepository.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    [CollectionName("Personal")]
    public class Personal : MongoIdentityUser
    {
        public Personal()
        {
            CreatedDate = DateTime.Now;
            Status = 1;
        }
        public PersonalContact PersonalContact { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
