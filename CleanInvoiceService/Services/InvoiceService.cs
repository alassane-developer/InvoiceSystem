using CleanInvoiceService.Interfaces;
using CleanInvoiceService.Models;

namespace CleanInvoiceService.Services;

public class InvoiceService : IInvoiceService
{
    private readonly ITaxService _taxService;
    private readonly IRepository _repository;
    private readonly IEmailService _emailService;

    public InvoiceService(ITaxService taxService, IRepository repository, IEmailService emailService)
    {
        _taxService = taxService;
        _repository = repository;
        _emailService = emailService;
    }

    public void ProcessInvoice(Invoice invoice)
    {
        var tax = _taxService.CalculateTax(invoice);
        // use the tax value if needed
        _repository.Save(invoice);
        _emailService.Send(invoice);
    }
}