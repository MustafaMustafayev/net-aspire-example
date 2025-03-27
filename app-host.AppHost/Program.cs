var builder = DistributedApplication.CreateBuilder(args);

var servicea = builder.AddProject<Projects.service_a>("service-a");

builder.AddProject<Projects.service_b>("service-b")
                                    .WithExternalHttpEndpoints()
                                    .WithReference(servicea)
                                    .WaitFor(servicea);

builder.Build().Run();
