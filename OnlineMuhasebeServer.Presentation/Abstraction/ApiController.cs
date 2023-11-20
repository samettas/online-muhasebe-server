using Microsoft.AspNetCore.Mvc;

namespace OnlineMuhasebeServer.Presentation.Abstraction
{
    [ApiController]
    [Route("api/[Controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
