using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Pd.MediatrPipelines.PipelineBehaviors
{
    /// <summary>
    /// https://github.com/jbogard/MediatR/wiki/Behaviors
    /// </summary>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <seealso cref="MediatR.IPipelineBehavior&lt;TRequest, TResponse&gt;" />
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            this.logger = logger;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            logger.LogInformation($"Handling {typeof(TRequest).Name}");
            var response = await next();
            logger.LogInformation($"Handled {typeof(TResponse).Name}");

            return response;
        }
    }
}