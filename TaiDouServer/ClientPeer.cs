using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiDouServer
{
    class ClientPeer:PeerBase
    {
        public ClientPeer(IRpcProtocol protocol,IPhotonPeer unmanagedPeer)
            :base(protocol,unmanagedPeer)
        {

        }
        protected override void OnDisconnect(PhotonHostRuntimeInterfaces.DisconnectReason reasonCode, string reasonDetail)
        {
            
        }

        //客户端发起请求时调用
        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
          
        }
    }
}
