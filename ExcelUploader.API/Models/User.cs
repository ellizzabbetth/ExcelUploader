namespace ExcelUploader.API.Models
{
    public enum Status { Active, Inactive, Hold };
    public class User
    {

        //[Key]
        public int Id { get; set; }

       // [Required]
       // [StringLength(50, MinimumLength = 1, ErrorMessage = "Invalid")]
        public string FirstName { get; set; }

       // [Required]
       // [StringLength(50, MinimumLength = 1, ErrorMessage = "Invalid")]
        public string LastName { get; set; }

       // [Required]
        public int Age { get; set; }

      //  [Required]
      //  [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }


    }
    }
}