using AlunoApi.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Data
{
    public interface IRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        Alluno BuscarAluno(int id);

        List<Alluno> BuscarAlunos();

        void AtualizarAluno<T>(T entidade) where T : class;

        void ExcluirAluno<T>(T entidade) where T : class;

        void BuscarProfessor<T>(T entidade) where T : class;

        void  ExibirDirector<T>(T entidade) where T : class;


    }
    
  
    
}
