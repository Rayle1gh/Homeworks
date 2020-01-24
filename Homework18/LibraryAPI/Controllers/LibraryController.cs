using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Data;
using LibraryAPI.Models;
using Newtonsoft.Json;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private LibraryDataStore context;
        public LibraryController()
        {
            context = LibraryDataStore.GetInstance();
        }
        [HttpGet("list")]
        public List<LibraryModel> Index()
        {
            return context.GetBooksList();
        }
        [HttpGet("book/{id}")]
        public LibraryModel GetBook(int id)
        {
            return context.GetBook(id);
        }
        [HttpPost("add")]

        public IActionResult Add([FromQuery]LibraryDataModel model)
        {
            if (context.Add(model))
                return Content($"Success add book \"{model.Title}\"");
            else
                return Content($"Failed add book \"{model.Title}\"");
        }
        [HttpDelete("remove/{id}")]

        public List<LibraryModel> Remove(int id)
        {
            context.Remove(id);
            return context.GetBooksList();
        }
        [HttpGet("replace/{id}")]
        public LibraryModel Replace(int id, [FromQuery]LibraryDataModel model)
        {
            context.Replace(id, model);
            return context.GetBook(id);
        }
    }
}
