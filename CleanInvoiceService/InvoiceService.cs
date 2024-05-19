using CleanInvoiceService.Interfaces;

namespace CleanInvoiceService;

public class InvoiceService : IInvoiceService
{
    private readonly IRepository _repository;
    private readonly IEmailService _emailService;

    public InvoiceService(IRepository repository, IEmailService emailService)
    {
        _repository = repository;
        _emailService = emailService;
    }

    public void ProcessInvoice(Invoice invoice)
    {
        invoice.CalculateTotal();
        _repository.Save(invoice);
        _emailService.Send(invoice);
    }
}