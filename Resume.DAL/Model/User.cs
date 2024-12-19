using Resume.DAL.Model.Common;

namespace Resume.DAL.Model
{
    public class User: BaseEntity<int>
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
        public bool IsActive{ get; set; }
    }
}
