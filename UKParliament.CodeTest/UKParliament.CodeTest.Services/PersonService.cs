using System.Collections.Generic;
using System.Linq;
using UKParliament.CodeTest.Data;
using UKParliament.CodeTest.Domain;

namespace UKParliament.CodeTest.Services
{
    // Sooooo... let's talk about this.
    // On the one hand with have the great Julie Lerman and others, who say the DbContext /is/ a repository implementation, 
    // no need to implement IRepository and inject; alternatively you can very much argue that separation of 
    // concerns means we want to wrap in a custom IRepository and inject...
    // I'm pleading demo project and going with Lerman!  The trade-off is introducing EntityFrameworkCore concepts into our service layer,
    // which can be argued to be a pollution.  But on the other hand, how often do we honestly change our data provider?
    // We could easily evaluate that we are spending more time on separation
    // than we are saving in the unusual event we want to change provider
    // and not rewrite the entire app anyway?
    public class PersonService : IPersonService
    {
        private readonly PersonManagerContext personManagerContext;

        public PersonService(PersonManagerContext personManagerContext)
        {
            this.personManagerContext = personManagerContext;
            this.personManagerContext.Database.EnsureCreated();
        }

        public List<Person> Get()
        {
            List<Person> result = personManagerContext.People.ToList();
            return result;
        }

        public int Delete(int id)
        {
            personManagerContext.People.Remove(personManagerContext.People.SingleOrDefault(x => x.Id == id));
            personManagerContext.SaveChanges();
            return id;
        }

        public Person Add(Person person)
        {
            personManagerContext.People.Add(person);
            personManagerContext.SaveChanges();
            return person;
        }

        public Person Update(Person person)
        {
            personManagerContext.People.Update(person);
            personManagerContext.SaveChanges();
            return person;
        }
    }
}
