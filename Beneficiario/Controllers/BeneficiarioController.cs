using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Beneficiario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioService _beneficiarioService;
        public BeneficiarioController(IBeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }

        [HttpPost]
        [Route("CadastrarBeneficiario")]
        public async Task<IActionResult> PostAsync(BeneficiarioCommand command)
        {
            return Ok(await _beneficiarioService.PostAsync(command));
        }
    }
}
