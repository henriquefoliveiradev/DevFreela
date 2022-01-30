using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SkilViewModel> GetAll()
        {
            var skill = _dbContext.Skills;

            var skillsViewModel = skill
                .Select(s => new SkilViewModel(s.Id, s.Description))
                .ToList();

            return skillsViewModel;
        }
    }
}
