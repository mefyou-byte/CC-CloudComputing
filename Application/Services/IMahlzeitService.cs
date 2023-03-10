using Application.Models;
using Newtonsoft.Json;

namespace Application.Services
{
    public interface IMahlzeitService
    {
        string getMenufromAPI(MahlzeitModel model);
    }

    public class MahlzeitService: IMahlzeitService
    {

        // api call to get one menu 

        public string getMenufromAPI(MahlzeitModel model)
        {
            Task task = MakeAPiCall("chicken");

			Console.WriteLine(task);	
			return "Chicken";

		
        }

       

        public static async Task MakeAPiCall(String kategorie)
		{
			// create an instance of HttpClient
			using var httpClient = new HttpClient();

			// make a GET request to the specified URL
			var response = await httpClient.GetAsync("https://www.themealdb.com/api/json/v1/1/filter.php?i=" + kategorie);

			// read the response content as a string
			var responseContent = await response.Content.ReadAsStringAsync();


			// deserialize the response content as a JSON object

			var mealsoriginal = JsonConvert.DeserializeObject(responseContent);
  
            
			Console.WriteLine("AUSGABE");

			Console.WriteLine(mealsoriginal);

		
		}
		public class Meal
		{
			public IList<meals>? meals { get; set; }		
			
		}


	}

    public class meals
    {
		public string? strMeal { get; set; }
		public string? strMealThumb { get; set; }
		public int idMeal { get; set; }
	}
}
