using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Context;
using CarPark.DataAccess.Repository;
using CarPark.Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.DataAccess.Concrete
{
    public class PersonalDataAccess : MongoRepositoryBase<Personal>, IPersonalDataAccess
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<Personal> _collection;
        public PersonalDataAccess(IOptions<MongoSettings> settings) : base(settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<Personal>();
        }


    }
}
