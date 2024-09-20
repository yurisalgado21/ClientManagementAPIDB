using System.ComponentModel.DataAnnotations;

namespace ClientManagementAPIDB.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres")]
        [MinLength(1, ErrorMessage = "O nome do cliente não pode ser vazio")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "O email do cliente é inválido")]
        public string Email { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}