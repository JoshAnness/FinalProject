using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using FinalProject.Models;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportController : ControllerBase
    {
        private readonly ILogger<SportController> _logger;
        private readonly SportContext _ctx;
        public SportController(ILogger<SportController> logger, SportContext ctx )
        {
            _logger = logger;
            _ctx = ctx;
        }

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Get))]
        public IActionResult Get(int? id)
        {
           

            if (id == null || id < 1)
                return Ok(_ctx.Sport.Take(10).ToList());

            var member = _ctx.Sport.Find(id);
            if (member == null)
                return NotFound();

            return Ok(member);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Sport Sport_information)
        {
            if (Sport_information.ID == null || Sport_information.ID < 1)
                return BadRequest("Invalid member Id");

            var dbSport = _ctx.Sport.Find(Sport_information.ID);
            if (dbSport == null)
                return NotFound();

            dbSport.FullName = Sport_information.FullName;
            dbSport.FavoriteSport = Sport_information.FavoriteSport;
            dbSport.When = Sport_information.When;
            _ctx.Sport.Update(dbSport);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();


            return StatusCode(500, "Error occured on the server. Please try again in a few minutes.");
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Post))]
        public IActionResult Post(Sport Sport_information)
        {
            if (string.IsNullOrEmpty(Sport_information.FullName))
            {
                return BadRequest("Must include a Full Name for the member.");
            }
            Sport_information.ID = null;
            _ctx.Sport.Add(Sport_information);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

        [HttpDelete]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int? id, Sport Sport_information)
        {
            if (id == null || id < 1)
                return BadRequest("Invalid member Id");

            var member = _ctx.Sport.Find(id);
            if (member == null)
                return NotFound();

            _ctx.Sport.Remove(member);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

    }
}