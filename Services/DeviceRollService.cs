using diceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace diceAPI.Services
{
    public class DiceRollService
    {
        public DiceRollResponse RollDice(DiceRollRequest request)
        {
            Random rand = new Random();
            var rolls = new List<int>();

            for (int i = 0; i < request.NumberOfDice; i++)
            {
                rolls.Add(rand.Next(1, request.NumberOfSides + 1));
            }

            var highestValues = rolls.OrderByDescending(r => r).Take(request.NumberOfHighestValuesToSum);
            int sumOfHighestValues = highestValues.Sum();

            return new DiceRollResponse
            {
                Rolls = rolls,
                SumOfHighestValues = sumOfHighestValues
            };
        }
    }
}

