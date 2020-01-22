using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Chalandri.Glenrothes;
using R5T.Glenrothes.DropboxRivetData;
using R5T.Ilioupoli.Standard;
using R5T.Lombardy.Standard;


namespace R5T.Chalandri.DropboxRivetTestingData
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTestingDataDirectoryContentPathsProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<ITestingDataDirectoryContentPathsProvider, TestingDataDirectoryContentPathsProvider>()
                .AddTestingDataDirectoryPathProvider()
                .AddTestingDataDirectoryContentConventions()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
