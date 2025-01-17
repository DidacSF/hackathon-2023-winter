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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_xcm.pallet
{
    
    
    /// <summary>
    /// >> 425 - Composite[pallet_xcm.pallet.RemoteLockedFungibleRecord]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RemoteLockedFungibleRecord : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation _owner;
        
        /// <summary>
        /// >> locker
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation _locker;
        
        /// <summary>
        /// >> consumers
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26 _consumers;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation Locker
        {
            get
            {
                return this._locker;
            }
            set
            {
                this._locker = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26 Consumers
        {
            get
            {
                return this._consumers;
            }
            set
            {
                this._consumers = value;
            }
        }
        
        public override string TypeName()
        {
            return "RemoteLockedFungibleRecord";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Owner.Encode());
            result.AddRange(Locker.Encode());
            result.AddRange(Consumers.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Owner = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
            Owner.Decode(byteArray, ref p);
            Locker = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
            Locker.Decode(byteArray, ref p);
            Consumers = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26();
            Consumers.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
