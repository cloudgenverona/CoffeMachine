using System;
using System.Linq;

namespace Core
{
    public class DrinkMaker
    {
        private string[] _commandInstructions;
        public DrinkMaker(string command, int money)
        {
            if (command.Count(x => x == ':') < 1 && command.Count(x => x == ':') > 2)
                throw new ArgumentException("Comando nel formato non corretto");
            int r = 0;
            _commandInstructions = command.Split(":");
            switch (_commandInstructions.FirstOrDefault())
            {
                case "T":
                    DrinkType = DrinkType.Tea;
                    r = money - 40;
                    break;
                case "H":
                    DrinkType = DrinkType.Chocolate;
                    r = money - 50;
                    break;
                case "C":
                    DrinkType = DrinkType.Coffe;
                    r = money - 60;
                    break;
                case "M":
                    DrinkType = DrinkType.Service;
                    break;
            }
            if (int.TryParse(_commandInstructions.ElementAt(1), out int sugar) && sugar > 0 && sugar <= 2)
            {
                Sugar = sugar;
            }
            if (command.Count(x => x == ':') == 1)
            {
                Message = _commandInstructions.ElementAt(1);
            }
            if (r < 0)
            {
                Message = $"Mancano {-r} centesimi";
                DrinkType = DrinkType.Service;
            }
        }

        public DrinkType DrinkType { get; }
        public int Sugar { get; }
        public bool IsStickPresent => Sugar > 0 && DrinkType != DrinkType.Service;
        public string Message { get; }
    }

    public enum DrinkType
    {
        Tea = 1,
        Coffe = 2,
        Chocolate = 4,
        Service = 8
    }
}
