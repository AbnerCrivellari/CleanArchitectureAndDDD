using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThisneyTicket.Application.Interfaces;
using ThisneyTicket.Application.ViewModel;

namespace ThisneyTicket.API.Controllers
{
    [ApiController]
    [Route("Event")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult<EventViewModel>> Get()
        {
            return Ok(await _eventService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventViewModel>> GetById([FromQuery] int id)
        {
            return Ok(await _eventService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EventViewModel eventView)
        {
            var response = await _eventService.Create(eventView);
            return Created(nameof(Get), response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] EventViewModel eventView)
        {
            var response = await _eventService.Update(eventView);
            if (response == null)
                return NoContent();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] EventViewModel eventView)
        {
            _eventService.Delete(eventView);
            return NoContent();
        }
    }
}
