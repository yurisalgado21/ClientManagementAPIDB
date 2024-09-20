using ClientManagementAPIDB.Models;
using FluentValidation;


public class ClientValidator : AbstractValidator<Client>
{
    public ClientValidator()
    {
        RuleFor(client => client.Name)
        .NotNull().WithMessage("O nome do cliente é obrigatório")
        .NotEmpty().WithMessage("O nome do cliente não pode ser vazio")
        .MaximumLength(100).WithMessage("O nome do cliente deve ter no máximo 100 caracteres");

        RuleFor(client => client.Email)
        .NotNull().WithMessage("O email do cliente é obrigatório")
        .NotEmpty().WithMessage("O email do cliente não pode ser vazio")
        .EmailAddress().WithMessage("O email do cliente é inválido");
    }
}
