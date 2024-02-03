using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Domain.Commands
{
    public class BeneficiarioCommand
    {
        public int BeneficiarioId { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string estado { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int Cep { get; set; } 


    }
}
