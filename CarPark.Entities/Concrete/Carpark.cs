using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class Carpark : BaseModel
    {
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public Address Address { get; set; }
        public string[] Personels { get; set; }
        public string WebSite { get; set; }
        public string[] EmailAddress { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public ICollection<FloorInformation> Floors { get; set; }
    }
}
