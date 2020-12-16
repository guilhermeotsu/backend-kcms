namespace KCMS.Configuration
{
    public static class CollectionNames
    {
        public static string Category => "categories";
        public static string Products => "products";
    }

    public class KCMSDatabaseSettings : IKCMSDatabaseSettings
    { 
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IKCMSDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
