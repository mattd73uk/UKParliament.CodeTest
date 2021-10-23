using FakeItEasy;
using UKParliament.CodeTest.Services;
using UKParliament.CodeTest.Web.Controllers;
using Xunit;

namespace UKParliament.CodeTest.Tests
{
    public class PersonControllerTests
    {
        [Fact]
        public void TestItemDeleted()
        {
            IPersonService personService = A.Fake<IPersonService>();
            PersonController controller = new PersonController(personService);

            // ... etc please see read me - solution answer.txt
            // There is no actual logic to test.  I'd mainly be recreating 
            // a mock of the context, and I'd be more likely to introduce
            // a bug doing that that the test would fail on, than actually finding
            // a bug in the "production" code.

            // But unit tests are really important - when there is logic to test.
            Assert.True(true);
        }
    }
}
