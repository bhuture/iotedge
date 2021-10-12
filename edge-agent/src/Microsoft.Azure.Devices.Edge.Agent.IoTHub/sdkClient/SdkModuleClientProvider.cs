// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.IoTHub.SdkClient
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices.Client;

    public class SdkModuleClientProvider : ISdkModuleClientProvider
    {
        public ISdkModuleClient GetSdkModuleClient(string connectionString, ITransportSettings settings, ClientOptions options = null)
        {
            ModuleClient moduleClient = ModuleClient.CreateFromConnectionString(connectionString, new[] { settings }, options);
            return new WrappingSdkModuleClient(moduleClient);
        }

        public async Task<ISdkModuleClient> GetSdkModuleClient(ITransportSettings settings, ClientOptions options = null)
        {
            ModuleClient moduleClient = await ModuleClient.CreateFromEnvironmentAsync(new[] { settings }, options);
            return new WrappingSdkModuleClient(moduleClient);
        }
    }
}
