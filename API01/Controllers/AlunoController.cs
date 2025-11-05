using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain;

namespace API01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public AlunoController() 
        {

        }
        [HttpGet("BuscarDadosAlunos/{id}")]
        public async Task<IActionResult> BuscarDadosAlunos(int id)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.Id = id;
                aluno.Nome = "Davi";
                aluno.Matricula = "2024001";
                aluno.Cep = "12345-678";
                aluno.Endereco = "Rua das Flores, 123";
                aluno.Bairro = "Jardim Primavera";
                aluno.Cidade = "São Paulo";

                return Ok("API de Alunos funcionando!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            } 
        }
    }
}
