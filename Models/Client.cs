using System.ComponentModel.DataAnnotations;

namespace ClientManagementAPIDB.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}