using MediatR;
using Microsoft.AspNetCore.Authorization;
using OnlineMuhasebeServer.Presentation.Abstraction; 

namespace OnlineMuhasebeServer.Presentation.Controller;

[Authorize(AuthenticationSchemes ="Bearer")]
public class LogsController : ApiController
{
    public LogsController(IMediator mediator) : base(mediator) {}
}
