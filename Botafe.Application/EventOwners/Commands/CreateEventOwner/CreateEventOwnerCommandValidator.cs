using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botafe.Application.EventOwners.Commands.CreateEventOwner
{
    public class CreateEventOwnerCommandValidator : AbstractValidator<CreateEventOwnerCommand>
    {
        public CreateEventOwnerCommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(10);
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
