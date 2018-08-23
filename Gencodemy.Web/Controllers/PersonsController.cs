using System.Web.Http;
using Gencodemy.Services.Persons;
using Gencodemy.Services.Persons.Commands;

namespace Gencodemy.Web.Controllers
{
    [RoutePrefix("api/persons")]
    public class PersonsController : ApiController
    {
        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(CreatePerson command)
        {
            // Crée une nouvelle personne
            var servicePerson = new PersonsService();

            var newPerson = servicePerson.CreatePerson(command);

            return Ok(newPerson);
        }
    }
}