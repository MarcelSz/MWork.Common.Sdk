namespace MWork.Common.Sdk.CQRS
{
    public interface IBusMediator : ICommandBus, IEventBus, IQueryBus
    {
    }
}