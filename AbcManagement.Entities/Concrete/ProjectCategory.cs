using AbcManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.Entities.Concrete
{
    public class ProjectCategory:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Project> Projects { get; set; }
    }
}
