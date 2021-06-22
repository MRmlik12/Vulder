using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Vulder.Search.Api.Models;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Core.ProjectAggregate.School;
using Vulder.Search.SharedKernel;

namespace Vulder.Search.Api.Controllers
{
    [ApiController]
    [FormatFilter]
    [Route("[controller]")]
    public class CreateController : ControllerBase
    {
        private readonly ISchoolRepository _repository;
        
        public CreateController(ISchoolRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Produces("application/json")]
        public ActionResult Post([FromBody]SchoolDto dto)
        {
            if (string.IsNullOrEmpty(dto.RequesterEmail) || Regex.IsMatch(dto.RequesterEmail, Regexes.Email))
                Problem("The requesterEmail is invalid");

            if (string.IsNullOrEmpty(dto.Url) || Regex.IsMatch(dto.Url, Regexes.Url))
                Problem("The url is invalid");

            var school = new School
            {
                Name = dto.Name,
                Url = dto.Url,
                KeeperEmail = dto.RequesterEmail
            };
            school.GenerateId();
            
            _repository.Create(school);
                
            return Ok("Created!");//TODO: Saturday
        }
    }
}