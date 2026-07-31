using KamsoftZadanieTestowe.Models;
using KamsoftZadanieTestowe.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace KamsoftZadanieTestowe.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class ParserController : ControllerBase
    {
        private readonly ParserFactory _factory;
        public ParserController(ParserFactory factory)
        {
            _factory = factory;
        }
        [HttpPost("parse-content")]
        public IActionResult Parse(ParseRequest parseRequest)
        {
            try
            {
                byte[] contentByte = Convert.FromBase64String(parseRequest.Content);
                string contentString = Encoding.UTF8.GetString(contentByte).Trim('\uFEFF', '\u200B', ' ');

                IParser Parser = _factory.GetParser(parseRequest.Type);
                var result = Parser.Parse(contentString);

                var itemList = (IEnumerable<object>)result;


                var response = new ParseResponse
                {
                    Success = true,
                    Count = itemList.Count(),
                    Items = itemList
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
