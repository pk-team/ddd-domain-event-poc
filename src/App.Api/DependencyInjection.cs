using App.Api.Operations;

namespace App.Api;

public static class DependencyInjection {
    public static IServiceCollection AddApi(this IServiceCollection services) {
        services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>();
            
        return services;
    }
}