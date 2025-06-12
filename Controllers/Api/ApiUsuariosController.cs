using Microsoft.AspNetCore.Mvc;
using PAGINA_CREACION.Models;
using MongoDB.Driver;

[ApiController]
[Route("api/usuarios")]
public class ApiUsuariosController : ControllerBase
{
    //Métodos para hacer las operaciones CRUD
    // C = Create
    // R = Read
    // U = Update
    // D = Delete

    private readonly IMongoCollection<Usuario> collection;
    public ApiUsuariosController()
    {
        var client = new MongoClient(CadenaConexion.Mongo_DB);
        var db = client.GetDatabase("Escuela_Jorge_Angel");
        this.collection = db.GetCollection<Usuario>("Usuarios");
        
    }

    [HttpGet]
    public IActionResult ListarUsuarios()
    {
        var filter = FilterDefinition<Usuario>.Empty;
        var list = this.collection.Find(filter).ToList(); 
        return Ok(list);
    }
}