using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IBusinessLogic
    {
        List<Person> GetAllPeople();
        List<Person> GetPeopleByLastName(string name);

        (bool, List<string>) AddPerson(Person person);

    }
}
