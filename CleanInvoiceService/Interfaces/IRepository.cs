﻿using CleanInvoiceService.Models;

namespace CleanInvoiceService.Interfaces;

public interface IRepository
{
    void Save(Invoice invoice);
}
