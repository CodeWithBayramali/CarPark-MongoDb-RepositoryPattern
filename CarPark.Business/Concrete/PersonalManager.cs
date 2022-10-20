using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.DataAccess.Abstract;
using CarPark.Entities.Concrete;

namespace CarPark.Business.Concrete
{
    public class PersonalManager : IPersonalService
    {
        private readonly IPersonalDataAccess _personalDataAccess;

        public PersonalManager(IPersonalDataAccess personalDataAccess)
        {
            _personalDataAccess = personalDataAccess;
        }

        public GetManyResult<Personal> GetPersonalsByAge()
        {
            var personalList = _personalDataAccess.AsQueryable();
            return personalList;
        }
    }
}
