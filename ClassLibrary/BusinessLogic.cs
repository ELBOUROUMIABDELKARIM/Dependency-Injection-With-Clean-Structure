using ClassLibrary.Validators;
using FluentValidation.Results;
using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        IDataAccess _dataAccess;
        public BusinessLogic(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public List<Person> GetAllPeople()
        {
            var people = _dataAccess.GetPeople();
            if (people.Count>0)
            {
                return people;
            }
            MessageBox.Show("No people in the list");
            return null;
        }

        public List<Person> GetPeopleByLastName(string name)
        {
            if (name.All(Char.IsLetter))
            {
                var people = _dataAccess.GetPeopleByLastName(name);
                if(people.Count > 0)
                {
                    return people;
                }
                else
                {
                    MessageBox.Show("No People");
                    return null;
                }
            }
            MessageBox.Show("Invalid Name");
            return null;
        }

        [Obsolete]
        public (bool,List<string>) AddPerson(Person person)
        {
            PersonValidator validator = new PersonValidator();
            List<string> errorsList = new List<string>();
            var results = validator.Validate(person);
            if (results.IsValid)
            {
                bool dbAdded = _dataAccess.AddPerson(person);
                if (dbAdded)
                {
                    return (true, null);
                }
            }
            else if(results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errorsList.Add($" {failure.PropertyName} : {failure.ErrorMessage}");
                }
                return (false,errorsList);
            }
            errorsList.Add("Logic Error");
            return (false, errorsList);
        }
    }
}
