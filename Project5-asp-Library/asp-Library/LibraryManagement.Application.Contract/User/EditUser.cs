namespace LibraryManagement.Application.Contract.User
{
    public class EditUser : CreateUser
    {
        public long id { get; set; }
        public bool isActive{ get; set; }
    }
}
