using System;

namespace StorageAPI.Models;

public class Product
{
    public int Id { get; }
    public string Name { get; }
    public int Price { get; }
    public string Category { get; }
    public string Shelf { get; }
    public int Count { get; }
    public string Description { get; }
}
