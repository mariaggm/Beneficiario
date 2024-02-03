using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Service.Service
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _repository;
        public BeneficiarioService(IBeneficiarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> PostAsync(BeneficiarioCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
