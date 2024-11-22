using System;
using System.Collections.Generic;

namespace ServicoPagamento.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } //Lista de parcelas que será vinculdo ao contrato

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)  //Add uma parcela a lista
        {
            Installments.Add(installment);
        }
    }
}
