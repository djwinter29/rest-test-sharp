using Microsoft.AspNetCore.Mvc;

namespace RESTServer.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TrackController : ControllerBase
    {

        private readonly ILogger<TrackController> _logger;

        public TrackController(ILogger<TrackController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// single object
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("speed")]
        public SpeedInfo GetSpeed()
        {
            return new SpeedInfo
            {
                Date = DateTime.Now,
                Speed = Random.Shared.Next(-20, 55),

            };
        }


        /// <summary>
        /// array
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("poistion")]
        public IEnumerable<PositionInfo> GetPosition()
        {
            return Enumerable.Range(1, 5).Select(index => new PositionInfo
            {
                Date = DateTime.Now.AddDays(index),
                x = Random.Shared.Next(-20, 55),
                y = Random.Shared.Next(-20, 55),
                z = Random.Shared.Next(-20, 55),

            })
            .ToArray();
        }

        /// <summary>
        /// return as array
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("rotation")]
        public IEnumerable<RotationInfo> GetRotation()
        {
            return Enumerable.Range(1, 5).Select(index => new RotationInfo
            {
                Date = DateTime.Now.AddDays(index),
                x = Random.Shared.Next(-20, 55),
                y = Random.Shared.Next(-20, 55),
                z = Random.Shared.Next(-20, 55),

            })
            .ToArray();
        }

        /// <summary>
        /// return as single object
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("system")]
        public RotationInfo GetSystem()
        {
            return new RotationInfo
            {
                Date = DateTime.Now,
                x = Random.Shared.Next(-20, 55),
                y = Random.Shared.Next(-20, 55),
                z = Random.Shared.Next(-20, 55),

            };
        }

        /// <summary>
        /// return google.com
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("google")]
        public ContentResult GetGoogle()
        {
            HttpClient client = new HttpClient();
            var response = client.Send(new HttpRequestMessage(HttpMethod.Get, "https://www.google.com"));
            using var reader = new StreamReader(response.Content.ReadAsStream()); 

            return new ContentResult
            {
                Content = reader.ReadToEnd(),
                ContentType = "text/html"
            };


        }

    }
}