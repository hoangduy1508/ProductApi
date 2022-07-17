namespace ProductApi.Models
{
    public class ProductCreationDto
    {

        public string Name { get; set; }

        public string? Description { get; set; }
        public int CategoryId { get; set; }
    }
}
