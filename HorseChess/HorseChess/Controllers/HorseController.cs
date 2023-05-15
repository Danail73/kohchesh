using Microsoft.AspNetCore.Mvc;

namespace HorseChess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HorseController : Controller
    {
        [HttpGet(Name = "GetHorseMovement")]
        public string[] Get()
        {
            HorseService service = new HorseService();
            return service.GetMoves();
        }
    }
}
