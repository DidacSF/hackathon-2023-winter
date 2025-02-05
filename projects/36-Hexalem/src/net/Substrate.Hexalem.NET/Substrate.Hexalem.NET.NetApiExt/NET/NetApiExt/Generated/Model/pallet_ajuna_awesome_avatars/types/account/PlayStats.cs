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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account
{
    
    
    /// <summary>
    /// >> 334 - Composite[pallet_ajuna_awesome_avatars.types.account.PlayStats]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PlayStats : BaseType
    {
        
        /// <summary>
        /// >> first
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _first;
        
        /// <summary>
        /// >> last
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _last;
        
        /// <summary>
        /// >> seasons_participated
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 _seasonsParticipated;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 First
        {
            get
            {
                return this._first;
            }
            set
            {
                this._first = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Last
        {
            get
            {
                return this._last;
            }
            set
            {
                this._last = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1 SeasonsParticipated
        {
            get
            {
                return this._seasonsParticipated;
            }
            set
            {
                this._seasonsParticipated = value;
            }
        }
        
        public override string TypeName()
        {
            return "PlayStats";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(First.Encode());
            result.AddRange(Last.Encode());
            result.AddRange(SeasonsParticipated.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            First = new Substrate.NetApi.Model.Types.Primitive.U32();
            First.Decode(byteArray, ref p);
            Last = new Substrate.NetApi.Model.Types.Primitive.U32();
            Last.Decode(byteArray, ref p);
            SeasonsParticipated = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT1();
            SeasonsParticipated.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
