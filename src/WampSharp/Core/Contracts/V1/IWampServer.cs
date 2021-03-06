namespace WampSharp.Core.Contracts.V1
{
    /// <summary>
    /// An object version of <see cref="IWampServer{TMessage}"/>
    /// </summary>
    public interface IWampServer : IWampServer<object>
    {
    }

    /// <summary>
    /// Contains all methods of WAMP server.
    /// </summary>
    public interface IWampServer<TMessage> : IWampAuxiliaryServer, IWampRpcServer<TMessage>, IWampPubSubServer<TMessage>
    {
    }
}