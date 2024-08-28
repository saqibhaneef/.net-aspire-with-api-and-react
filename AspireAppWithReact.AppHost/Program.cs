
var builder = DistributedApplication.CreateBuilder(args);

var api=builder.AddProject<Projects.AspireAppWithReact_Api>("weatherapi");

builder.AddNpmApp("react", "../AspireAppWithReact.Web","Dockerfile")
    .WithReference(api)
    .WithEnvironment("BROWSER", "none") // Disable opening browser on npm start
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();


builder.Build().Run();
