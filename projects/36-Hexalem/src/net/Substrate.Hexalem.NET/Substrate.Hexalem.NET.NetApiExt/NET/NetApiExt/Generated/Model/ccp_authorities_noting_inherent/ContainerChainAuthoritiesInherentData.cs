//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.ccp_authorities_noting_inherent
{
    
    
    /// <summary>
    /// >> 268 - Composite[ccp_authorities_noting_inherent.ContainerChainAuthoritiesInherentData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ContainerChainAuthoritiesInherentData : BaseType
    {
        
        /// <summary>
        /// >> relay_chain_state
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof _relayChainState;
        
        /// <summary>
        /// >> orchestrator_chain_state
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof _orchestratorChainState;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof RelayChainState
        {
            get
            {
                return this._relayChainState;
            }
            set
            {
                this._relayChainState = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof OrchestratorChainState
        {
            get
            {
                return this._orchestratorChainState;
            }
            set
            {
                this._orchestratorChainState = value;
            }
        }
        
        public override string TypeName()
        {
            return "ContainerChainAuthoritiesInherentData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RelayChainState.Encode());
            result.AddRange(OrchestratorChainState.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RelayChainState = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof();
            RelayChainState.Decode(byteArray, ref p);
            OrchestratorChainState = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof();
            OrchestratorChainState.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
