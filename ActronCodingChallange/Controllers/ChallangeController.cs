
using ActronCodingChallange.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ActronCodingChallange.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ChallangeController : ControllerBase
    {
        private readonly IRepository _repository;
        public ChallangeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("calculateNumber")]
        public async Task<IActionResult> CalculateLargestNumber([FromBody] int[] array)
        {
            if (array.Length == 0)
                return BadRequest(new { message = "Invalid input array [empty array]" });

            if( array.Any(a => a < 0))
                return BadRequest(new { message = "Invalid input array [non positive integers]" });

            try
            {
                var resultArray = _repository.LargestNumberFormation(array);
                return Ok(resultArray);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }  
        } 
    }
}
