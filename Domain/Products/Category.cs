﻿namespace IWantApp.Domain.Products;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string CraetedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
}
