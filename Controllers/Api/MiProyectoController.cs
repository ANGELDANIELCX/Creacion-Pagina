using Microsoft.AspNetCore.Mvc;
using PAGINA_CREACION.Models;
using MongoDB.Driver;

namespace PAGINA_CREACION.Controllers.Api;

[ApiController]
[Route("mi-proyecto")]
public class MyProyectoController : ControllerBase
{
    [HttpGet("integrantes")]
    public IActionResult Integrantes()
{
    var proyecto = new MiProyecto
    {
        NombreIntegrante1 = "Angel Daniel Ramirez Hernandez",
        NombreIntegrante2 = "Jorge Luis Lozano Diaz"
    };
    return Ok(proyecto);
}
    [HttpGet("presentacion")]
    public IActionResult Presentacion()
    {
        MongoClient client = new MongoClient(CadenaConexion.Mongo_DB);
        var db = client.GetDatabase("Escuela_Jorge_Angel");
        var collection = db.GetCollection<Equipo>("Equipo");
            var lista= collection.Find(FilterDefinition<Equipo>.Empty).ToList();
            return Ok(lista);
    }

}