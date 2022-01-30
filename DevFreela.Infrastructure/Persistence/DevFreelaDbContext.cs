using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto 1", 1 , 1, 10000),
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto 2", 1 , 1, 20000),
                new Project("Meu projeto ASPNET Core", "Minha Descrição de Projeto 3", 1 , 1, 30000),
            };

            Users = new List<User>
            {
                new User("Henrique Oliveira", "henriqueoliveira@henrique.com.br", new DateTime(1999, 1, 1)),
                new User("Robert C Martin", "robertcmartin@cmartin.com.br", new DateTime(1950, 1, 1)),
                new User("Anderson", "Anderson@cmartin.com.br", new DateTime(1980, 1, 1)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
