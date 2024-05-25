using CleanInvoiceService.Models;

namespace CleanInvoiceService.Interfaces;

public interface IInvoiceService
{
    void ProcessInvoice(Invoice invoice);
}