using CleanInvoiceService.Models;

namespace CleanInvoiceService.Interfaces
{
    public interface IEmailService
    {
        void Send(Invoice invoice);
    }
}