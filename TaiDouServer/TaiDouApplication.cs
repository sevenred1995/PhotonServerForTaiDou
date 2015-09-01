using Photon.SocketServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaiDouServer
{
    class TaiDouApplication:ApplicationBase
    {

        protected override PeerBase CreatePeer(InitRequest initRequest)
        {
            return new ClientPeer(initRequest.Protocol, initRequest.PhotonPeer);
        }

        protected override void Setup()
        {
           
        }

        protected override void TearDown()
        {
            
        }
    }
}
