namespace DevFreela.Payments.API.Models;

public record PaymentInfoDTO(int IdProject, string CreditCardNumber, string Cvv, string ExpiresAt, string FullName, decimal Amount);