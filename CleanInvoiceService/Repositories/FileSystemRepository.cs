using CleanInvoiceService.Interfaces;
using CleanInvoiceService.Models;

namespace CleanInvoiceService.Repositories;

public class FileSystemRepository : IRepository
{
    public void Save(Invoice invoice)
    {
        // Save the invoice to the folder
        Console.WriteLine("Invoice saved ...");
    }
}
