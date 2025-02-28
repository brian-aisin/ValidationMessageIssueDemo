using FluentValidation;

namespace ValidationMessageIssueDemo.Shared
{
    public class ToDo
    {
        public string? Line { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class ToDoValidator: AbstractValidator<ToDo>
    {
        public ToDoValidator()
        {
            RuleFor(x => x.Line)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please select a line");

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please enter a name");

            RuleFor(x => x.Description)
                .MaximumLength(50)
                .WithMessage("Description has a max length of 50 characters");
        }
    }
}
