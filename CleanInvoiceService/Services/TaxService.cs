using CleanInvoiceService.Interfaces;
using CleanInvoiceService.Models;

namespace CleanInvoiceService.Services;

public class TaxService : ITaxService
{
    public double CalculateTax(Invoice invoice)
    {
        return invoice.Amount * 0.2;
    }
}