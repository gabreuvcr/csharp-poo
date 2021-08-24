using System;

namespace Rental.Entities
{
    class Invoice
    {
        private double BasicPayment { get; set; }   
        private double Tax { get; set; }

        private double TotalPayment => BasicPayment + Tax;

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment:F2}\n"
                + $"Tax: {Tax:F2}\n"
                + $"Total payment: {TotalPayment:F2}";
        }

    }
}
