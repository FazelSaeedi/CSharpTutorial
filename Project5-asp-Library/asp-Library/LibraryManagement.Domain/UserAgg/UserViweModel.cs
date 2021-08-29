namespace LibraryManagement.Domain.UserAgg
{
    public class UserViweModel
    {
        public long id{ get; set; }
        public string userName { get; set; }
        public string phone { get; set; }
        public bool isActive { get; set; }
        public string CreationDate { get; set; }
    }
}
