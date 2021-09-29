// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.IoTHub.SdkClient
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices.Client;

    public interface ISdkModuleClientProvider
    {
        ISdkModuleClient GetSdkModuleClient(string connectionString, ITransportSettings settings, ClientOptions options = null);

        Task<ISdkModuleClient> GetSdkModuleClient(ITransportSettings settings, ClientOptions options = null);
    }
}
