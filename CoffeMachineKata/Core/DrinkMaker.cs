using System;
using System.Linq;

namespace Core
{
    public class DrinkMaker
    {
        private string[] _commandInstructions;
        public DrinkMaker(string command)
        {
            if (command.Count(x => x == ':') < 1 && command.Count(x => x == ':') > 2)
                throw new ArgumentException("Comando nel formato non corretto");

            _commandInstructions = command.Split(":");
            switch (_commandInstructions.FirstOrDefault())
            {
                case "T":
                    DrinkType = DrinkType.Tea;
                    break;
                case "H":
                    DrinkType = DrinkType.Chocolate;
                    break;
                case "C":
                    DrinkType = DrinkType.Coffe;
                    break;
                case "M":
                    DrinkType = DrinkType.Service;
                    break;
            }
            if (int.TryParse(_commandInstructions.ElementAt(1), out int sugar) && sugar > 0 && sugar <= 2)
            {
                Sugar = sugar;
            }   
        }

        public DrinkType DrinkType { get; }
        public int Sugar { get; }
        public bool IsStickPresent => Sugar > 0 && DrinkType != DrinkType.Service;
    }

    public enum DrinkType
    {
        Tea = 1,
        Coffe = 2,
        Chocolate = 4,
        Service = 8
    }
}
