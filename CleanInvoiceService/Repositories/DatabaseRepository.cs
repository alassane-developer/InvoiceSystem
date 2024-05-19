using CleanInvoiceService.Interfaces;

namespace CleanInvoiceService.Repositories;

public class DatabaseRepository : IRepository
{
    public void Save(Invoice invoice)
    {
        // Save the invoice to the database
        Console.WriteLine("Invoice saved ...");
    }
}
