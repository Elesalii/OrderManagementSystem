namespace OrderManagementSystem.Data.Model
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public long PhoneNumber { get; set;}
        public long TaxNo { get; set; }
        public string? TaxAdress { get; set;}
        public DateTime CreatedOn { get; set; }
    }
}
