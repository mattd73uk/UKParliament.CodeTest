using System.Collections.Generic;
using UKParliament.CodeTest.Domain;

namespace UKParliament.CodeTest.Services
{
    public interface IPersonService
    {
        List<Person> Get();
        int Delete(int id);
        Person Update(Person person);
        Person Add(Person person);
    }
}