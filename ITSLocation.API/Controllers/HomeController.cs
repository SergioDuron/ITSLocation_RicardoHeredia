using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ITSLocation.API.Controllers
{
    
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        [HttpGet(Name = "GetHolaMundo")]
        public IActionResult Get()
        {
            Logger.Info("Se ha recibido una solicitud GET.");
            try
            {
                // Simulación de algún procesamiento
                var data = new { Message = "Hello, World!" };
                Logger.Debug("Procesamiento exitoso.");
                return Ok(data);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrió un error durante el procesamiento.");
                return StatusCode(500, "Error interno del servidor.");
            }
            finally
            {
                Logger.Info("Se ha completado la solicitud GET.");
            }
        }

    }
}

