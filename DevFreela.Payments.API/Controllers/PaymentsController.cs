using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers;

[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _paymentService; 
    public PaymentsController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PaymentInfoDTO paymentInfoDto)
    {
        var result = await _paymentService.ProcessPayment(paymentInfoDto);

        if (!result)
        {
            return BadRequest();
        }

        return NoContent();
    }
}