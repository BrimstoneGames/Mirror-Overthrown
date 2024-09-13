using UnityEngine;

namespace Mirror {
    /// <summary>BRIMSTONE ADDITION<br/>
    /// Stripped-down, lightweight version of <see cref="NetworkBehaviour"/> that performs no syncing but receives start/stop callbacks.</summary>
    public class NetworkCallbackBehaviour : MonoBehaviour {
        [field: SerializeField] public NetworkIdentity netIdentity { get; internal set; }

        public bool isServer => netIdentity.isServer;
        public bool isClient => netIdentity.isClient;
        public bool isLocalPlayer => netIdentity.isLocalPlayer;
        public bool isServerOnly => netIdentity.isServerOnly;
        public bool isClientOnly => netIdentity.isClientOnly;
        public bool isOwned => netIdentity.isOwned;
        public uint netId => netIdentity.netId;
        public NetworkConnection connectionToServer => netIdentity.connectionToServer;
        public NetworkConnectionToClient connectionToClient => netIdentity.connectionToClient;

        /// <summary>Like Start(), but only called on server and host.</summary>
        public virtual void OnStartServer() { }
        /// <summary>Stop event, only called on server and host.</summary>
        public virtual void OnStopServer() { }
        /// <summary>Like Start(), but only called on client and host.</summary>
        public virtual void OnStartClient() { }
        /// <summary>Stop event, only called on client and host.</summary>
        public virtual void OnStopClient() { }
        /// <summary>Like Start(), but only called on client and host for the local player object.</summary>
        public virtual void OnStartLocalPlayer() { }
        /// <summary>Stop event, but only called on client and host for the local player object.</summary>
        public virtual void OnStopLocalPlayer() { }
        /// <summary>Like Start(), but only called for objects the client has authority over.</summary>
        public virtual void OnStartAuthority() { }
        /// <summary>Stop event, only called for objects the client has authority over.</summary>
        public virtual void OnStopAuthority() { }
    }
}
