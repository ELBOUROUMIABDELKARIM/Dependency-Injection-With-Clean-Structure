using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public interface IDatabaseData
    {
        IEnumerable<Person> LoadPeopleData();
        IEnumerable<Person> LoadPeopleDataByLastName(string name);
        void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber);
    }
}
