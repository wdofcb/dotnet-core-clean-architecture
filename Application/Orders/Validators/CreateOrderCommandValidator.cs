using Application.Orders.Commands;
using FluentValidation;

namespace Application.Orders.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    { 
        public CreateOrderCommandValidator()
        {
            RuleFor(v => v.NumberOfItems).NotNull();
            RuleFor(v => v.CustomerId).NotNull();
        }
    }
}
