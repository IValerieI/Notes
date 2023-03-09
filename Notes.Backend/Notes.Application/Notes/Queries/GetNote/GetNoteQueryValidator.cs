using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNote
{
    public class GetNoteQueryValidator : AbstractValidator<GetNoteQuery>
    {
        public GetNoteQueryValidator()
        {
            RuleFor(note => note.Id).NotEqual(Guid.Empty);
            RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
    }
}