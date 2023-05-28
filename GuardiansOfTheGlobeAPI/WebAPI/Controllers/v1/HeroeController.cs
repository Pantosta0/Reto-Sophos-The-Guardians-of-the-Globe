using Application.Features.Heroes.Commands.CreateHeroeCommand;
using Application.Features.Heroes.Commands.DeleteHeroeCommand;
using Application.Features.Heroes.Commands.UpdateHeroeCommand;
using Microsoft.AspNetCore.Mvc;

namespace API_Rest.Controllers.v1
{
    [ApiVersion("1.0")]
    public class HeroeController : BaseApiController
    {
        //POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateHeroeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //PUT api/<controller>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateHeroeCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]    
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteHeroeCommand { Id = id })); 
        }

    }
}
