namespace Tavern.Data {
    public class Product {
        public required string Forum_ID {get; set;}
        public string? optionalLink {get; set;}
        public string? postUser {get; set;}
        public string? title {get; set;}
        public string? category {get; set;}
        public string? description {get; set;}
        public DateTime? createdAt {get; set;}
    }
}