namespace MongoDbProject.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CommentCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
