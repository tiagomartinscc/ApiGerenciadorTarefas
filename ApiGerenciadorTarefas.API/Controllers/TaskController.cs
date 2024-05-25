using ApiGerenciadorTarefas.Application.UseCases.Task;
using ApiGerenciadorTarefas.Communication.Requests;
using ApiGerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ApiGerenciadorTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    //- Deve ser possível criar uma tarefa;
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    //- Deve ser possível visualizar todas as tarefas criadas;
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTasksUseCase().Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    //- Deve ser possível visualizar uma tarefa buscando pelo seu id;
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] uint id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);
        return Ok(response);
    }

    //- Deve ser possível editar informações de uma tarefa;
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] uint id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskUseCase().Execute(id, request);
        return NoContent();
    }

    //- Deve ser possível excluir uma tarefa.
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] uint id)
    {
        new DeleteTaskByIdUseCase().Execute(id);
        return NoContent();
    }
}
