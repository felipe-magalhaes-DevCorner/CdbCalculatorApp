using Microsoft.AspNetCore.Mvc;
using System.Net;
using CdbCalculatorApp.Server.Models;
using CdbCalculatorApp.Server.Service;
namespace CdbCalculatorApp.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculoCDBController : ControllerBase
{
    [HttpPost(Name = "CalcularCdb")]
    [ProducesResponseType(typeof(CdbCalculationResult), StatusCodes.Status200OK)] 
    public IActionResult Post([FromBody] CdbRequest request)
    {
        decimal valorInicial = request.ValorInicial;
        int prazoMeses = request.PrazoMeses;

        var oServices = new CalculadoraService();
        CdbCalculationResult oRetorno = oServices.CalcularRetorno(valorInicial, prazoMeses);

        return Ok(oRetorno);
    }
}
