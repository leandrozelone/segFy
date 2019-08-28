namespace ApoliceSegfy.Api.Data.Model
{
    public class Policy
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string Document { get; set; }
        public string Board { get; set; }
        public decimal Price { get; set; }
    }
}