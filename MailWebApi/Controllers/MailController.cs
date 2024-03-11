using MailService.Models;
using MailWebApi.LetterPresenters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MailWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly ILetterPresenter _letterPresenter;
        private readonly ILetterRegistrar _letterRegistar;
        public MailController(ILetterPresenter letterPresenter, ILetterRegistrar letterRegistrar)
        {
            _letterPresenter = letterPresenter;
            _letterRegistar = letterRegistrar;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllLetersAsync()
        {
            var letters = await _letterPresenter.DisplayAllLetters();
            var json = JsonConvert.SerializeObject(letters);
            return Ok(json);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewLetterAsync([FromBody] LetterDto letterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var letter = ConvertLetterDtoToLetter(letterDto);
            var result = await _letterRegistar.TryRegisterAsync(letter);

            if (!result.isValid)
                return BadRequest();

            return CreatedAtAction(nameof(Letter), letter);
        }
        private Letter ConvertLetterDtoToLetter(LetterDto letterDto)
        {
            var letter = new Letter()
            {
                Content = letterDto.Content,
                SubjectOfLetter = letterDto.SubjectOfLetter,
                RecipientId = letterDto.RecipientId,
                SenderId = letterDto.SenderId,
            };
            return letter;
        }
    }
}
