using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Card Holder Name:")]
        public string CardHolderName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        [Display(Name = "Card Holder Number:")]
        [DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ExpiryDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecretCode { get; set; }
    }
}
