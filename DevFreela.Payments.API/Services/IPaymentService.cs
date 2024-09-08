using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services;

public interface IPaymentService
{
    Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDto);
}