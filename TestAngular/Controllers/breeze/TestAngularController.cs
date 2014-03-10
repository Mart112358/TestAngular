using System.Linq;
using System.Web.Http;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;
using TestAngularLOB.Models;

namespace TestAngular.Controllers.breeze
{
    [BreezeController]
    public class TestAngularController : ApiController
    {
        private readonly EFContextProvider<DatabaseContext> _efContextProvider = 
            new EFContextProvider<DatabaseContext>();

        [HttpGet]
        public string Metadata()
        {
            return _efContextProvider.Metadata();
        }

        [HttpGet]
        public IQueryable<Employee> Employees()
        {
            return _efContextProvider.Context.Employees;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _efContextProvider.SaveChanges(saveBundle);
        }
    }
}