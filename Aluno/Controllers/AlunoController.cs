
using AlunoApi.Bussiness;
using AlunoApi.Data;
using AlunoApi.Modelo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly AlunoBussiness alunoBusiness;

        public AlunoController(AlunoBussiness alunoBusiness)
        {
            this.alunoBusiness = alunoBusiness;
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <returns></returns>
        [HttpGet("buscar-aluno/{id}")]
        public async Task<IActionResult> BuscarAluno(int id)
        {
            var aluno = alunoBusiness.BuscarAluno(id);
            return Ok(aluno);
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <returns></returns>
        [HttpGet("exibir-alunos")]
        public ActionResult ExibirAlunos()
        {
            var alunos = alunoBusiness.ExibirAlunos();
            return Ok(alunos);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="aluno"></param>
        /// <returns></returns>
        [HttpPost("salvar-aluno")]
        public async Task<IActionResult> SalvarAluno(Alluno aluno)
        {
            var _aluno = await alunoBusiness.SalvarAluno(aluno);

            return Ok(_aluno);
        }

        [HttpPut("atualizar-aluno")]
        public async Task<ActionResult> AtualizarAluno([FromBodyAttribute] Alluno aluno)
        {

            var _aluno = await alunoBusiness.AtualizarAluno(aluno);

            return Ok(_aluno);

        }

        [HttpDelete("excluir-aluno/{id}")]
        public async Task<ActionResult> ExcluirAluno(int id)
        {
            var aluno = alunoBusiness.BuscarAluno(id);

            alunoBusiness.ExcluirAluno(aluno);
            return Ok();
        }

    }
}
