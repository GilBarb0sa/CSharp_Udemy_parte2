namespace ServicoPagamento.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);  // Calcula os juros para a parcela no mês
        double Interest(double amount, int months);  // Calcula a taxa de pagamento para a parcela
    }
}
