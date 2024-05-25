using CleanInvoiceService.Interfaces;
using CleanInvoiceService.Models;

namespace CleanInvoiceService;

public class EmailService : IEmailService
{
    public void Send(Invoice invoice)
    {
        // Send the invoice to the customer
        Console.WriteLine("Invoice sent ...");
    }
}