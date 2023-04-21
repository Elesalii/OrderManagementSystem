namespace OrderManagementSystem.Data.Model
{
    public class ProductModel
    {
        public int? ProductId { get; set; }
        public string? Name { get; set; }
        public long Barcode { get; set; }
        public decimal Price { get; set; }
        public int UnitType { get; set; }
        public int DiscountType { get; set; }
        public int KDVType { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
