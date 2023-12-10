using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Commands.CreateBookEntry;
using OnlineMuhasebeServer.Presentation.Abstraction; 

namespace OnlineMuhasebeServer.Presentation.Controller;

public class BookEntriesController : ApiController
{
    public BookEntriesController(IMediator mediator) : base(mediator) {}

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateBookEntry(CreateBookEntryCommand request, CancellationToken cancellationToken)
    {
        CreateBookEntryCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}