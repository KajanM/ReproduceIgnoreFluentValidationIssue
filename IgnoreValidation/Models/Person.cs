using System.Collections.Generic;
using FluentValidation;

namespace IgnoreValidation.Models
{
    public class Person
    {
        public string Name { get; set; }

        public List<Skill> Skills { get; set; }
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty();
        }
    }
    
}