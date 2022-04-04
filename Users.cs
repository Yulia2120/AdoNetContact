using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetContact
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string DataAdded { get; set; }

        public Users() { }

    }
}
