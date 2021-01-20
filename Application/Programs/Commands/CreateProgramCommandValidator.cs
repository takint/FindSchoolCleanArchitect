﻿using Application.Common.Interfaces;
using FluentValidation;

namespace Application.Programs.Commands
{
    public class CreateProgramCommandValidator : AbstractValidator<CreateProgramCommand>
    {
        public readonly IApplicationDbContext _context;

        public CreateProgramCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(p => p.ProgramData.SchoolId)
                .NotEmpty().WithMessage("SchoolId is required");

            RuleFor(p => p.ProgramData.ProgramCategoryId)
                .NotEmpty().WithMessage("ProgramCatergoryId is required");

            RuleFor(p => p.ProgramData.ProgramName)
               .NotEmpty().WithMessage("Program Name is required");

            RuleFor(p => p.ProgramData.ProgramLevel)
               .NotEmpty().WithMessage("Program Level is required");
        }
    }
}
