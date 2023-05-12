using Microsoft.AspNetCore.Mvc;

namespace HorseChess.Controllers
{
    ApiController]
    [Route("[controller]")]
    public class HorseController : Controller
    {
        [HttpGet(Name = "GetHorseMovement")]
        public string[] Get()
        {
            HorseMovement service = new HorseMovement();
            try
            {
                service.Move(7, 0, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return service.GetAllMoves();
        }
    }
}
