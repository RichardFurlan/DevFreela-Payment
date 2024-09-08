using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services;

public class PaymentService : IPaymentService
{
    public Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDto)
    {
        return Task.FromResult(true);
    }
}