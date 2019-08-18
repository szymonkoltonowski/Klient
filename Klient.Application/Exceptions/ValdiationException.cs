using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace Klient.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("Wystąpił jeden lub więcej błędów sprawdzania poprawności.")
        {
            Failures = new Dictionary<string, string[]>();
        }

        public ValidationException(List<ValidationFailure> failures)
            : this()
        {
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                Failures.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Failures { get; }
    }
}