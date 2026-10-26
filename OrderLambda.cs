using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// AWS Lambda sample: API Gateway handler returning JSON.
public class OrderLambda
{
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest req, ILambdaContext ctx)
    {
        var id = req.PathParameters?.GetValueOrDefault("id") ?? "1";
        return new APIGatewayProxyResponse { StatusCode = 200, Body = $"{{\"id\": \"{id}\", \"status\": \"Paid\"}}", Headers = new Dictionary<string, string> { ["Content-Type"] = "application/json" } };
    }
}
