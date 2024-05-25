using CleanInvoiceService.Models;

namespace CleanInvoiceService.Interfaces;

public interface ITaxService
{
    double CalculateTax(Invoice invoice);
}