using MultibleDbCRUD.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Models
{
    public class Student : BaseEntity
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID_school { get; set; }

        public School School { get; set; }
    }
}
