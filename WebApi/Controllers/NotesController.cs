using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("[controller]")]
[ApiController]
public class NotesController : ControllerBase
{
    private readonly INotesService notesService;
    public NotesController(INotesService notesService)
    {
        this.notesService = notesService;
    }

    [HttpGet()]
    public void GetAllTasks()
    {
        notesService.GetAllNotes();
    }
}
