using AbcManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.Entities.Concrete
{
    public class Project:IEntity
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int Progress { get; set; }
        public string IconURL { get; set; }

        public int ProjectCategoryId { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
    }
}
