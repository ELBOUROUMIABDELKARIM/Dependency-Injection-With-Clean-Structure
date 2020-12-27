using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IDataAccess
    {
        List<Person> GetPeople();
        List<Person> GetPeopleByLastName(string lastname);
        bool AddPerson(Person person);
    }
}
