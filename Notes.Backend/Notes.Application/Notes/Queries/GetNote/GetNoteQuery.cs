using MediatR;

namespace Notes.Application.Notes.Queries.GetNote
{
    public class GetNoteQuery : IRequest<NoteViewModel>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}