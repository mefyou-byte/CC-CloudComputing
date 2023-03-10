using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using static Application.Controllers.MahlzeitController;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahlzeitController : ControllerBase
    {
        private static List<MahlzeitModel> Mahlzeits = new List<MahlzeitModel>();

        List<Model> finalList = new List<Model>();
        // get values from Service and put them together

        private IMahlzeitService mahlzeitService;

        public MahlzeitController(IMahlzeitService _mahlzeit)
        {
            mahlzeitService = _mahlzeit;
        }


        public class Model
        {
            public int Id { get; set; } 
            public string? Tag { get; set; }
			public string? Kategorie { get; set; }
			public string? Menu { get; set; }

		}


	// POST api/<ValuesController>
	[HttpPost]
        public OkObjectResult Post(MahlzeitModel mahlzeit)
        {
            string Menu = mahlzeitService.getMenufromAPI(mahlzeit);


            var counter = finalList.Count;
            finalList.Add(new Model{ Id= counter+1, Tag = mahlzeit.Tag, Menu = Menu, Kategorie = mahlzeit.Kategorie});
			
            return Ok(finalList);

        }


        // GET: api/<ValuesController>
        [HttpGet]

        public List<Model> Get()
        {
            return finalList;
        }


		[HttpPut]
		public OkObjectResult PUT(int id, Model model)
		{
            var existingItem = finalList.FirstOrDefault(x => x.Id == id);

            if (existingItem != null)
            {
                existingItem.Tag = model.Tag;
                existingItem.Kategorie = model.Kategorie;
            }
			return Ok(existingItem);

		}


		[HttpDelete]
		public OkObjectResult delete(int id)
		{
			var existingItem = finalList.FirstOrDefault(x => x.Id == id);

			if (existingItem != null)
			{
                finalList.Remove(existingItem);
			}
			return Ok("deleted!");

		}
	}





}
