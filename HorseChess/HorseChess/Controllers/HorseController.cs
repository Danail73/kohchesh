using HorseChess.Services;
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
            // HorseServiceInterface service = new HorseService();
            HorseServiceInterface service = new HorseStaticService();

            return service.GetMoves();
        }
    }
}