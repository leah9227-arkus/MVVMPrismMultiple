using MVVMPractice.Connections.Repos;

namespace MVVMPractice.Connections
{
    public class Repositories : IRepositories
    {
        public IBeerRepository BeerRepository { get; }

        public Repositories()
        {
            BeerRepository = new BeerRepository();
        }
    }
}
