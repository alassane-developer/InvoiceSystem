namespace CleanInvoiceService;

public class Invoice
{
    private double _total;

    public int Id { get; set; }
    public double Amount { get; set; }


    public Invoice(int id, double amount)
    {
        Id = id;
        Amount = amount;
    }

    public void CalculateTotal()
    {
        var tax = Amount * 0.2;
        _total = Amount + tax;

        Console.WriteLine($"Invoice total : {_total}");
    }
}
