using Atividade_H1_1.NovaPasta;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_H1_1.Controllers;

[ApiController]
[Route("Pessoa")]
public class PessoaController : ControllerBase
{
    

    [HttpPost("CalculoIMC")]
    public IActionResult CalculoIMC(Pessoa pessoa)
    {
        CalculareConsultarIMC _calcularIMC = new CalculareConsultarIMC();

       var resultado = _calcularIMC.IMCCompleto(pessoa);

        return Ok(resultado);
        
    }
  
}
