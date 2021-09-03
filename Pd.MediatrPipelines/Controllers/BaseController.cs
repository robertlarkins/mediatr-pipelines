using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Pd.MediatrPipelines.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? mediator;

        /// <summary>
        /// Gets the Mediator object.
        /// </summary>
        protected IMediator Mediator =>
            mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;
    }
}