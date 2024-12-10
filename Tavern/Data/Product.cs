namespace Tavern.Data {
    public class Product {
        public required string Product_ID {get; set;}
        public string? Item_Type {get; set;}
        public double? Price {get; set;}
        public string? Item_Name {get; set;}
        public string? Image {get; set;}
        public string? Item_Desc {get; set;}
        public int? Stock_num {get; set;}
        public string? Color {get; set;}
    }
}