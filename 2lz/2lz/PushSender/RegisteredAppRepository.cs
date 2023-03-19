using SQLite;

namespace _2lz.PushSender
{
    public class RegisteredAppRepository
    {
        public string StatusMessage { get; set; }

        private string _dbPath;
        private SQLiteAsyncConnection _connection;

        public RegisteredAppRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        private async Task Init()
        {
            if (_connection == null)
            {
                return;
            }

            _connection = new SQLiteAsyncConnection(_dbPath);
            await _connection.CreateTableAsync<RegisteredApp>();
        }

        public async Task AddNewApp(string appName, string appId)
        {
            try
            {
                await Init();

                if (string.IsNullOrEmpty(appName) || string.IsNullOrEmpty(appId))
                {
                    throw new Exception("Invalid data");
                }

                await _connection.InsertAsync(new RegisteredApp { Id = appId, Name = appName });

                StatusMessage = string.Format($"App added. Name: {appName}. Id: {appId}");
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format($"Failed to add. Name: {appName}. Id: {appId}. {ex.Message}");
            }
        }

        public async Task<List<RegisteredApp>> GetAllApps()
        {
            try
            {
                await Init();
                return await _connection.Table<RegisteredApp>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format($"Failed to retrieve data. {ex.Message}");
            }

            return new List<RegisteredApp>();
        }
    }
}
