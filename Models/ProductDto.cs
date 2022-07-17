namespace ProductApi.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
        public string CategoryName { get; set; }
    }

}
