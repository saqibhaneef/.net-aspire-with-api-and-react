var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireAppWithReact_Api>("aspireappwithreact-api");

builder.Build().Run();
