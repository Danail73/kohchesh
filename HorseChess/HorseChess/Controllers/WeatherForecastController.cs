using Microsoft.AspNetCore.Mvc;

namespace HorseChess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public static int[,] chessboard = new int[8, 8];
        public static string[] allmoves = new string[64];
        public static bool Check(int x, int y)
        {
            if (x < 0 || y < 0 || x >= 8 || y >= 8 || chessboard[x, y] != 0)
                return false;
            return true;
        }
        public static void Move1(int x, int y, int index)
        {
            int[,] moves = { { -2, -1 }, { -1, -2 }, { +1, -2 }, { +2, -1 },
                { +2, +1 }, { +1, +2 }, { -1, +2 }, { -2, +1 } };
            for (int i = 0; i < 8; i++)
            {
                if (Check(x + moves[i, 0], y + moves[i, 1]))
                    Move( x + moves[i, 0], y + moves[i, 1], index);
            }
        }
        public static void Move( int x, int y, int index)
        {

            index++;
            chessboard[x, y] = index;
            if (index == chessboard.GetLength(1) * chessboard.GetLength(0))
            {
                throw new Exception("Done");
            }
            else
            {
                Move1(x, y, index);
                chessboard[x, y] = 0;
            }
        }

        public static void FindAllMoves() {
            var pos = 1;
            for (var i = 0; i < 8; i++)
            {
                var i1 = i;
                for (var j = 0; j < 8; j++)
                {
                    var j1 = j;
                    pos = chessboard[i,j];
                    allmoves[pos - 1] = i1.ToString() + j1.ToString();
                }
            }
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string[] Get()
        {
            try
            {
                Move(7, 0, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            FindAllMoves();
            return allmoves;
        }
    }
}