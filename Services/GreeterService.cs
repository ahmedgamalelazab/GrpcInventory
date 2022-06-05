using Grpc.Core;
using InventoryService;
using System.Linq;

namespace InventoryService.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly static Inventory myInventory = new Inventory(); //data that the client will ask for
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }

    public override Task<RequestResult> BuyItem(RequestLoad request, ServerCallContext context)
    {
        var result = 0;
        var target = myInventory.Items.SingleOrDefault((item) => item.Product.Id == request.ItemId);

        if (target == null)
        {
            return Task.FromResult(new RequestResult
            {
                CurrentAmout = -1
            });
        }
        //else
        myInventory.Items.ForEach((item) =>
        {
            if (item.Product.Id == request.ItemId)
            {
                item.Quantity -= 1;
                result = item.Quantity;
            }
        });

        return Task.FromResult(new RequestResult
        {
            CurrentAmout = result
        });
    }
}
