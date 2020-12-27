using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ClassLibrary.Data
{
    public class SqlData : IDatabaseData
    {

        public IEnumerable<Person> LoadPeopleData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("SampleDB")))
            {
                return connection.Query<Person>("dbo.People_GetAll");
            }
        }

        public IEnumerable<Person> LoadPeopleDataByLastName(string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("SampleDB")))
            {
                return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { Lastname = lastname });
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName ,LastName = lastName , EmailAddress = emailAddress,PhoneNumber = phoneNumber});
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
