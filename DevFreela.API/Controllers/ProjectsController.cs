using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;

        public ProjectsController(IOptions<OpeningTimeOption> option, ExempleClass exempleClass)
        {
            exempleClass.Name = "Updated at ProjectsController";
            _option = option.Value;
        }

        //api/projects/netcore
        [HttpGet]
        public IActionResult Get(string query)
        {
            // Buscar ou filtrar

            return Ok();
        }

        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o projeto

            // return NotFund();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProjectModel)
        {
            if (createProjectModel.Title.Length > 50)
            {
                return BadRequest();
            }

            // Cadastrar o projeto

            return CreatedAtAction(nameof(GetById), new { id = createProjectModel.Id }, createProjectModel);
            
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o objeto

            return NoContent();
        }

        // api/projects/3 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retorna NotFound

            // Remover

            return NoContent();
        }

        // api/projects/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult finish(int id)
        {
            return NoContent();
        }
    }
}
