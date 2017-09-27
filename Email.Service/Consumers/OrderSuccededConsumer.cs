using System.Threading.Tasks;
using MassTransit;
using Shared.Payment.Contracts;

namespace Email.Service.Consumers
{
    public class OrderSuccededConsumer : IConsumer<IPaymentProcessSucceded>
    {
        public Task Consume(ConsumeContext<IPaymentProcessSucceded> context)
        {
            // send email 
            return Task.CompletedTask;
        }
    }
}