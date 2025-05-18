using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViniAPI_1_Exemplo.Model;

namespace ViniAPI_1_Exemplo.Controllers
{
    [Route("api/amigos")]

    [ApiController]
    public class AmigosController : Controller
    {
        //private static List<Amigo> ListaAmigos = new List<Amigo>()
        private static List<Amigo> ListaAmigos = [
                new Amigo(1,"Vinicius","Rosalen", 28, "PS5"),
                new Amigo(2,"Isis","Rosalen", 8, "Gabarito da Prova"),
                new Amigo(3,"Esis","Rosalen", 2, "Pontos Extras")
            ];

        public IEnumerable<Amigo> Get()
        {
            return ListaAmigos;
        }
        // GET: AmigosController

        [HttpGet("{id}")]
        public Amigo Get(int id)
        {
            Amigo? amg = ListaAmigos.Find(x => x.Id == id);

            return amg ?? new();
        }

        [HttpGet("{id}/{nome}")]

        public Amigo Get(int id, string nome)
        {
            Console.WriteLine($"id fake: {id}");
            Amigo? amg = ListaAmigos.Find(x=> x.PrimeiroNome == nome);
            return amg ?? new();
        }
    }
}
