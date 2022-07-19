using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using laboratorio_portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace laboratorio_portal.Controllers
{

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}