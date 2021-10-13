namespace JRod_Application.Data.Repositories
{
    public class UserRepository : Repository<DataModels.User>, IUserRepository
    {
        public UserRepository(Context context)
            : base(context)
        { }
    }
}
