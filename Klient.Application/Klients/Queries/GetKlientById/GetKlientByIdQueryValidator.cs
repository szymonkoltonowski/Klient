using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.Application.Klients.Queries.GetKlientById
{
    public class GetKlientByIdQueryValidator : AbstractValidator<GetKlientByIdQuery>
    {
        public GetKlientByIdQueryValidator()
        {
            RuleFor(v => v.id).NotEmpty();
        }
    }
}
