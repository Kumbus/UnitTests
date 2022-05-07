namespace Classes
{
    public interface IUsersRepository
    {
        bool Login(string user, string password);
    }

    public class Authentication
    {
        private readonly IUsersRepository _usersRepository;

        public Authentication(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public string Login(string user, string password)
        {
            var isAuthenticated = _usersRepository.Login(user, password);//data from database

            if (!isAuthenticated)
                return "User or password is incorrect.";

            return string.Empty;
        }
    }
}
