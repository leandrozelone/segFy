namespace ApoliceSegfy.Api.Dto
{
    public class PolicyDto
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string Document { get; set; }
        public string Board { get; set; }
        public decimal Price { get; set; }
    }
}