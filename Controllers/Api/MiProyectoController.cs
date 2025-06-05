using Microsoft.AspNetCore.Mvc;
using PAGINA_CREACION.Models;

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

}