using AlunoApi.Data;
using AlunoApi.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Bussiness
{
    public class AlunoBussiness
    {
        private readonly IRepositorio repositorio;
        public AlunoBussiness(IRepositorio repositorio)
        {
                this.repositorio = repositorio;
            
        }

        public Alluno BuscarAluno(int id)
        {
            var aluno = repositorio.BuscarAluno(id);
            return aluno;
        }

        public List<Alluno> ExibirAlunos()
        {
            var alunos = repositorio.BuscarAlunos();
            return alunos;
        }

        public async Task<Alluno> SalvarAluno(Alluno aluno)
        {
            repositorio.Adiconar(aluno);

            if (await repositorio.Salvar())
                return aluno;

            return null;
        }
        public async Task<Alluno> AtualizarAluno(Alluno aluno)
        {
            repositorio.AtualizarAluno(aluno);

            if (await repositorio.Salvar())
                return aluno;

            return null;

        }

        public async void ExcluirAluno(Alluno aluno)
        {
            repositorio.ExcluirAluno(aluno);
            await repositorio.Salvar();
        }
    }
}
