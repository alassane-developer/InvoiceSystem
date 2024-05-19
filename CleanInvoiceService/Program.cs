using CleanInvoiceService;
using CleanInvoiceService.Interfaces;
using CleanInvoiceService.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
{
    services.AddScoped<IInvoiceService, InvoiceService>();
    services.AddScoped<IRepository, DatabaseRepository>();
    services.AddScoped<IRepository, FileSystemRepository>();
    services.AddTransient<IEmailService, EmailService>();
}).Build();

var invoice = new Invoice(1, 100);
var invoiceService = builder.Services.GetRequiredService<IInvoiceService>();
invoiceService.ProcessInvoice(invoice);
