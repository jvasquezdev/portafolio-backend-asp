using Microsoft.AspNetCore.Mvc;

namespace PortafolioBackendAsp.Controllers
{
    /// <summary>
    /// Controlador que gestiona la información del perfil del portafolio.
    /// Actúa como el primer microservicio (API estática) para el frontend.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        /// <summary>
        /// Realiza una petición GET para obtener los datos principales del portafolio.
        /// </summary>
        /// <returns>Un objeto JSON con los datos del usuario y un código HTTP 200 (OK).</returns>
        [HttpGet]
        public IActionResult GetProfile()
        {
            var profileData = new
            {
                name = "Jorge Vásquez",
                title = "Especialista en Soluciones Tecnológicas",
                skills = new[] { "Angular", "ASP.NET Core", "Laravel", "Python" },
                status = "Operativo y conectado"
            };

            return Ok(profileData);
        }
    }
}