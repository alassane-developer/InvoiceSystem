using InitialInvoiceSystem;

var invoice = new Invoice(1, 100);
invoice.CalculateTotal();
invoice.Save();
invoice.Send();

Console.ReadLine();