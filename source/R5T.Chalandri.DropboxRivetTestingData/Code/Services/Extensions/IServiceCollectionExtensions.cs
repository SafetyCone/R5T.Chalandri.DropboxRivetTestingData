using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Chalandri.Glenrothes;
using R5T.Dacia;
using R5T.Glenrothes.DropboxRivetData;
using R5T.Ilioupoli.Standard;
using R5T.Lombardy.Standard;


namespace R5T.Chalandri.DropboxRivetTestingData
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds an <see cref="ITestingDataDirectoryContentPathsProvider"/> service.
        /// </summary>
        public static IServiceCollection AddTestingDataDirectoryContentPathsProvider(this IServiceCollection services)
        {
            services.AddGlenrothesTestingDataDirectoryContentPathsProvider(
                services.AddTestingDataDirectoryPathProviderAction(),
                services.AddTestingDataDirectoryContentConventionsAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds an <see cref="ITestingDataDirectoryContentPathsProvider"/> service.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryContentPathsProvider> AddTestingDataDirectoryContentPathsProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryContentPathsProvider>(() => services.AddTestingDataDirectoryContentPathsProvider());
            return serviceAction;
        }
    }
}
