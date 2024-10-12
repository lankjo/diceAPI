namespace diceAPI.Models
{
    public class DiceRollRequest
    {
        public int NumberOfDice { get; set; }
        public int NumberOfSides { get; set; }
        public int NumberOfHighestValuesToSum { get; set; }
    }

    public class DiceRollResponse
    {
        public List<int> Rolls { get; set; }
        public int SumOfHighestValues { get; set; }
    }
}

