using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class FloorInformation : BaseModel
    {
        public int Number { get; set; }
        public ICollection<SlotInformation> Slots { get; set; }
    }
}
