using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.CreateNote;
using System.ComponentModel.DataAnnotations;

namespace Notes.WebApi.Models
{
    public class CreateNote : IMapWith<CreateNoteCommand>
    {
        //public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNote, CreateNoteCommand>();
        }
    }
}