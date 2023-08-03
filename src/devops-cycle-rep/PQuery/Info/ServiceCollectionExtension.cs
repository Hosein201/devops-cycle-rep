using Nest;

namespace PQuery.Info
{
    public static class ServiceCollectionExtension
    {
        public static void AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
        {
            var url = configuration["ELKConfiguration:url"];
            var defaultIndex = configuration["ELKConfiguration:index"];
            var userName = configuration["ELKConfiguration:userName"];
            var pass = configuration["ELKConfiguration:pass"];

            var settings = new ConnectionSettings(new Uri(url))
                .BasicAuthentication(userName, pass)
                .PrettyJson()
                .DefaultIndex(defaultIndex);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);
        }
    }
}