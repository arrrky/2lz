using _2lz.Misc;

namespace _2lz.PushSender
{
    public class PushSender : IPushSender
    {
        private readonly string RegisteredAppRepositoryName = "apps.db3";
        private readonly RegisteredAppRepository _appRepository;

        public PushSender()
        {
            string dbPath = FileAccessHelper.GetLocalFilePath(RegisteredAppRepositoryName);
            _appRepository = new RegisteredAppRepository(dbPath);
        }

        public void SendPush()
        {
            throw new NotImplementedException();
        }
    }
}