namespace CommunityPOS.EB.Domain.Dtos
{
    public class ProductDto
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double UnitsInStock { get; set; }
        public string Barcode { get; set; }
        public string Measure { get; set; }
    }
}
