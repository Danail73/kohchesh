namespace HorseChess.Services
{
    public class HorseStaticService : IHorseServiceInterface
    {
        public string[] GetMoves()
        {
            var allmoves = new string[]
            {
                "70",
                "62",
                "41",
                "20",
                "32",
                "11",
                "30",
                "51",
                "72",
                "60",
                "52",
                "31",
                "10",
                "22",
                "01",
                "13",
                "21",
                "00",
                "12",
                "33",
                "54",
                "42",
                "50",
                "71",
                "63",
                "75",
                "67",
                "46",
                "25",
                "04",
                "23",
                "02",
                "14",
                "06",
                "27",
                "35",
                "47",
                "66",
                "74",
                "53",
                "34",
                "55",
                "43",
                "64",
                "76",
                "57",
                "45",
                "37",
                "16",
                "24",
                "03",
                "15",
                "07",
                "26",
                "05",
                "17",
                "36",
                "44",
                "56",
                "77",
                "65",
                "73",
                "61",
                "40"
            };

            return allmoves;
        }
    }
}