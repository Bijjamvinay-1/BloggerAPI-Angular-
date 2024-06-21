

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace blogger.Controllers
{
    public class CategoriesController:ControllerBase
    {
        private readonly CategoriesController _dbCategory;

        public CategoriesController(CategoriesController dbCategory)
        {
            _dbCategory = dbCategory;
        }
    
    }
}
