using FluentValidation;
using InternSystem.Application.Features.User.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystem.Application.Features.User.Commands
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(model => model.HoVaTen)
                .NotEmpty()
                .MinimumLength(10);
        }
    }
    public class CreateUserCommand : IRequest<GetUserDetailResponse>
    {
        public string? HoVaTen { get; set; }
    }
}
