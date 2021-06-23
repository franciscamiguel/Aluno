using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Modelo
{
    public class Alluno
    {
        public int Id { get; set; }

        public string NomeAluno { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Sexo { get; set; }
        public string Nascimento { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Turma { get; set; }
        public string Curso { get; set; }
        public int Ano { get; set; }
        public string Turno { get; set; }
        public DateTime DataMAtricula { get; set; }
        public DateTime DataValidade { get; set; }

        internal static void RemoveAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal static void Update(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Alluno item)
        {
            throw new NotImplementedException();
        }

        internal static int FindIndex(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
