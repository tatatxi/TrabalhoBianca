using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoBianca
{
    public class Aluno
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNasc { get; set; }

        public int idade()
        {
            int idadeAluno = DateTime.Today.Year - this.DataNasc.Year;

            return idadeAluno;
        }

        public string nomeCompleto()
        {
            return string.Concat(Nome + Sobrenome);
        }

        public int validaNome()
        {
            int i = 0;
            string n = Nome;
            string s = Sobrenome;

            if (n.Contains("Ç") || n.Contains("ç") || s.Contains("Ç") || s.Contains("ç"))
            {
                i = +1;
            }
            if (n.Contains("@") || s.Contains("@"))
            {
                
                i = +2;
            }
            return i;
        }

        public string erroValidacao(int i)
        {
            string erro;
            if (validaNome() == 1)
            {
                erro = "Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome";
                return erro;
            }
            else if (validaNome() == 2)
            {
                erro = "Este nome não pode ser usado contém caracter '@' que é inválido";
                return erro;
            }

            return "";
        }

    }
}
