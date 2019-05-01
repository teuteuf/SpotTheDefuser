using Main.Domain.Network;
using Mirror;
using Mirror.LiteNetLib4Mirror;
using Zenject;

namespace Main.Infrastructure.Network
{
    public class SpotTheDefuserNetworkManager : LiteNetLib4MirrorNetworkManager, ISpotTheDefuserNetworkManager
    {
        private ISpotTheDefuserNetworkDiscovery _spotTheDefuserNetworkDiscovery;

        [Inject]
        public void Init(ISpotTheDefuserNetworkDiscovery spotTheDefuserNetworkDiscovery)
        {
            _spotTheDefuserNetworkDiscovery = spotTheDefuserNetworkDiscovery;
        }

        public void Host()
        {
            StartHost();
        }

        public void Join(string hostAddress)
        {
            networkAddress = hostAddress;
            StartClient();
        }

        public override void OnClientConnect(NetworkConnection networkConnection)
        {
            base.OnClientConnect(networkConnection);
            if (networkConnection.address != "localServer")
            {
                _spotTheDefuserNetworkDiscovery.StopBroadcastingOnLAN();
            }
        }
    }
}