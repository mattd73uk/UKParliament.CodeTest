using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UKParliament.CodeTest.Domain;
using UKParliament.CodeTest.Services;

namespace UKParliament.CodeTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return personService.Get();
        }

        [HttpGet("delete/{id}")]
        public int Delete(int id)
        {
            return personService.Delete(id);
        }

        [HttpPost("add")]
        public Person Add(Person person)
        {
            return personService.Add(person);
        }

        [HttpPost("update")]
        public Person Update(Person person)
        {
            return personService.Update(person);
        }

    }
}
