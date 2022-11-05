using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public DateTime LastOnline { get; set; }

        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }

        public string TeamRole { get; set; }
    }
}
