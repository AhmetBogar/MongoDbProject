namespace MongoDbProject.Settings
{
    public interface IDatabaseSettings
    {
        public string CommentCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
