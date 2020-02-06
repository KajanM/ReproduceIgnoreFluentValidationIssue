using System.Collections.Generic;
using FluentValidation;

namespace IgnoreValidation.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; }
    }

    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty();

            RuleFor(s => s.SupportingDocuments)
                .NotEmpty();
        }
    }
    
    
}