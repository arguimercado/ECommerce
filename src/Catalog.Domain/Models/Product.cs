namespace Catalog.Domain.Models;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public IEnumerable<string> Categories { get; set; } = new List<string>();

    public string? Description { get; set; }

    public string? ImageFile { get; set; }

    public decimal Price { get; set; }
}
