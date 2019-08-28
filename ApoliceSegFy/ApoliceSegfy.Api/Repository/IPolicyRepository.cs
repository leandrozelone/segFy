using System.Collections.Generic;
using ApoliceSegfy.Api.Dto;

namespace ApoliceSegfy.Api.Repository
{
    public interface IPolicyRepository
    {
        PolicyDto InsertPolicy(PolicyDto policeDto);         
        void UpdatePolicy(PolicyDto policeDto);
        void DeletePolicy(PolicyDto policeDto);
        List<PolicyDto> GetPolicys();
        PolicyDto GetPolicy(int id);
    }
}