using ClassLibrary.Data;
using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DataAccessSqlServer : IDataAccess
    {
        IDatabaseData _db;
        public DataAccessSqlServer(IDatabaseData databaseData)
        {
            _db = databaseData;
            
        }
        public List<Person> GetPeople()
        {
            var people = _db.LoadPeopleData().ToList();
            if (people != null)
                return people;
            return null;
        }

        public List<Person> GetPeopleByLastName(string lastname)
        {
            var people = _db.LoadPeopleDataByLastName(lastname).ToList();
            if (people!= null)
                return people;
            return null;
        }
        public bool AddPerson(Person p)
        {
            _db.InsertPerson(p.FirstName,p.LastName,p.EmailAddress,p.PhoneNumber);
            return true;
        }
    }
}
