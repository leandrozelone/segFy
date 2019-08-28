using System.Collections.Generic;
using System.Linq;
using ApoliceSegfy.Api.Data;
using ApoliceSegfy.Api.Dto;
using ApoliceSegfy.Api.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ApoliceSegfy.Api.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        public readonly PolicyDbContext _context;
        public PolicyRepository(PolicyDbContext context)
        {
            _context = context;
        }

        public PolicyDto InsertPolicy(PolicyDto policeDto)
        {
            var policy = convert(policeDto);

            _context.Policy.Add(policy);
            _context.SaveChanges();

            return convertDto(policy);
        }

        public void UpdatePolicy(PolicyDto policeDto)
        {
            var policy = convert(policeDto);

            _context.Entry(policy).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletePolicy(PolicyDto policeDto)
        {
            var policy = convert(policeDto);

            _context.Policy.Remove(policy);
            _context.SaveChanges();
        }

        public List<PolicyDto> GetPolicys()
        {
            return _context.Policy
            .Select(p => convertDto(p))
            .ToList();
        }

        public PolicyDto GetPolicy(int id)
        {
            return _context.Policy
            .Where(p => p.Id == id)
            .Select(p => convertDto(p))
            .FirstOrDefault();
        }

        private PolicyDto convertDto(Policy police)
        {
            return new PolicyDto
            {
                Id = police.Id,
                PolicyId = police.PolicyId,
                Document = police.Document,
                Board = police.Board,
                Price = police.Price
            };
        }

        private Policy convert(PolicyDto policeDto)
        {
            return new Policy
            {
                Id = policeDto.Id,
                PolicyId = policeDto.PolicyId,
                Document = policeDto.Document,
                Board = policeDto.Board,
                Price = policeDto.Price
            };
        }
    }
}