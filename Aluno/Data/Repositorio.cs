using AlunoApi.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Data
{
    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public void Adiconar<T>(T entidade) where T : class =>
            context.Add(entidade);

        public Alluno BuscarAluno(int id)
        {
            var Alluno = context.Alunos
                .FirstOrDefault(a => a.Id == id);

            return Alluno;
        }

        public void AtualizarAluno<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

         public async Task<bool> Salvar() => await context.SaveChangesAsync() > 0;

        public void ExcluirAluno <T>(T entidade) where T : class
        {
            context.Remove( entidade);
        }

        public List<Alluno> BuscarAlunos()
        {
            return context.Alunos.ToList();
        }

        public void BuscarProfessor<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }
        public void ExibirDirector<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }
    }
        
}
   
        



