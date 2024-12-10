namespace Tavern.Data {
    public class Users
    {
        public required string User_ID {get; set;}
        public string? First_Name {get; set;}
        public string? Last_name {get; set;}
        public string? Username {get; set;}
        public string? User_Password {get; set;}
        public string? Email {get; set;}
        public bool? User_Role {get; set;}
    }
}