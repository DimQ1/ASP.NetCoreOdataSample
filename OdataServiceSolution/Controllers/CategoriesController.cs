using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OdataServiceSolution.Model;

namespace OdataServiceSolution.Controllers
{

    [Route("api/[controller]")]
    [EnableQuery]
    public class CategoriesController : ODataController
    {
        private readonly List<Category> _categories = new List<Category>()
        {
            new Category(){ CategoryId = 1, CategoryName = "category1", Description="Category 1 description"},
            new Category(){ CategoryId = 2, CategoryName = "category2", Description="Category 2 description"},
            new Category(){ CategoryId = 3, CategoryName = "category3", Description="Category 3 description"},
            new Category(){ CategoryId = 4, CategoryName = "category4", Description="Category 4 description"},
            new Category(){ CategoryId = 5, CategoryName = "category5", Description="Category 5 description"},
            new Category(){ CategoryId = 6, CategoryName = "category6", Description="Category 6 description"},
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _categories;
        }

    }
}
