using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain;
using Modelo.Application.Interfaces;
using Modelo.Infra;

namespace API01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly IAlunoApplication _alunoApplication;
        private readonly ICepService _cepService;

        public AlunoController(IAlunoApplication alunoApplication, ICepService cepService) 
        {
            _alunoApplication = alunoApplication;
            _cepService = cepService;

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
        [HttpGet("BuscarCep/{cep}")]
        public async Task<IActionResult> BuscarCep(string cep)
        {
            try
            {
                var endereco = await _cepService.BuscarEnderecoPorCep(cep);
                return Ok("CEP buscado com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
