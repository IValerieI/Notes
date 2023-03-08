using Microsoft.EntityFrameworkCore;
using Notes.Domain;

/// Interface which implemented by NotesDbContext in Notes.Persistence

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
