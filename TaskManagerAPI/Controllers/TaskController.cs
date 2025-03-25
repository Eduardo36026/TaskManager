using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCase.CreateTask;
using TaskManager.Application.UseCase.EditTask;
using TaskManager.Application.UseCase.GetAll;
using TaskManager.Application.UseCase.GetById;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestTaskJson request)
        {
            var response = new CreateTaskUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllUseCase();
                
            var response = useCase.Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            return NoContent();

        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new GetByIdUseCase().Execute(id);

            
            return Ok(response);
        }


        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditTask([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new EditTaskUseCase();

            useCase.Execute(id, request);


            return NoContent();

        }


        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteTask([FromRoute] int id)
        {


            return NoContent();


        }

    }
}
