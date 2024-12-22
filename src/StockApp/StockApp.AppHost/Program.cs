var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.StockApp_ApiService>("apiservice");

builder.AddProject<Projects.StockApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
