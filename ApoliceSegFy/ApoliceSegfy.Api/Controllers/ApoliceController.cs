using System.Collections.Generic;
using ApoliceSegfy.Api.Dto;
using ApoliceSegfy.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApoliceSegfy.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApoliceController : ControllerBase
    {
        private readonly IPolicyRepository _repository;
        public ApoliceController(IPolicyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<PolicyDto>> Get()
        {
            return _repository.GetPolicys();
        }

        [HttpGet("{id}")]
        public ActionResult<PolicyDto> Get(int id)
        {
            return _repository.GetPolicy(id);
        }

        [HttpPost]
        public ActionResult<PolicyDto> Post([FromBody] PolicyDto policyDto)
        {
            return _repository.InsertPolicy(policyDto);
        }

        [HttpPut]
        public void Put([FromBody] PolicyDto policyDto)
        {
            _repository.UpdatePolicy(policyDto);
        }

        [HttpDelete]
        public void Delete([FromBody] PolicyDto policyDto)
        {
            _repository.DeletePolicy(policyDto);
        }
    }
}
