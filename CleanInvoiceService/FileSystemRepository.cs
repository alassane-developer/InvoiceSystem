using CleanInvoiceService.Interfaces;

namespace CleanInvoiceService;

public class FileSystemRepository : IRepository
{
    public void Save(Invoice invoice)
    {
        // Save the invoice to the folder
        Console.WriteLine("Invoice saved ...");
    }
}
