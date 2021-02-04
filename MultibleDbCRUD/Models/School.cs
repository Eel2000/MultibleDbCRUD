using MultibleDbCRUD.Models.Abstract;

namespace MultibleDbCRUD.Models
{
    public class School : BaseEntity
    {
        public string ID_school { get; set; }
        public string SchoolName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}