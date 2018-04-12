using Daxx.TestTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace Daxx.TestTask.Web.Controllers
{
    /// <summary>
    /// API controller to manipulate characters in strings
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class CharacterConverterController : Controller
    {
        private readonly ICharacterConverterService characterConverterService;

        public CharacterConverterController(ICharacterConverterService characterConverterService)
        {
            this.characterConverterService = characterConverterService;
        }

        /// <summary>
        /// GET api/CharacterConverter/ReverseTokens?source=I%20love%20programming
        /// Converts source string to string with reversed letters in each token (word)
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>converted string</returns>
        [HttpGet]
        public string ReverseTokens(string source)
        {
            var chars = source?.ToCharArray();
            characterConverterService.ReverseTokens(ref chars);
            return new string(chars);
        }
    }
}