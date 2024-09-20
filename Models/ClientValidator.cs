using FluentValidation;
using ClientManagementAPIDB.Models;

namespace ClientManagementAPIDB.Models
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(client => client.Name)
            .NotEmpty().WithMessage("O nome do cliente é obrigatório")
            .MaximumLength(100).WithMessage("O nome do cliente deve ter no máximo 100 caracteres");

            RuleFor(client => client.Email)
            .NotEmpty().WithMessage("O email do cliente é obrigatório")
            .EmailAddress().WithMessage("O email do cliente é inválido");

            RuleFor(client => client.IsActive)
            .NotNull().WithMessage("O status do cliente é obrigatório");
        }
    }
}