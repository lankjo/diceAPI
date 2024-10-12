using Microsoft.AspNetCore.Mvc;
using diceAPI.Models;
using diceAPI.Services;

namespace diceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiceRollController : ControllerBase
    {
        private readonly DiceRollService _diceRollService;

        public DiceRollController()
        {
            _diceRollService = new DiceRollService();
        }

        [HttpPost]
        public IActionResult RollDice([FromBody] DiceRollRequest request)
        {
            if (request.NumberOfDice <= 0 || request.NumberOfSides <= 0 || request.NumberOfHighestValuesToSum < 0)
            {
                return BadRequest("Invalid input parameters.");
            }

            var result = _diceRollService.RollDice(request);
            return Ok(result);
        }
    }
}

