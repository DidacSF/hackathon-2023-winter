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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 252 - Composite[pallet_nfts.types.MintWitness]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintWitness : BaseType
    {
        
        /// <summary>
        /// >> owned_item
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256> _ownedItem;
        
        /// <summary>
        /// >> mint_price
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> _mintPrice;
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256> OwnedItem
        {
            get
            {
                return this._ownedItem;
            }
            set
            {
                this._ownedItem = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> MintPrice
        {
            get
            {
                return this._mintPrice;
            }
            set
            {
                this._mintPrice = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintWitness";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(OwnedItem.Encode());
            result.AddRange(MintPrice.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            OwnedItem = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256>();
            OwnedItem.Decode(byteArray, ref p);
            MintPrice = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            MintPrice.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
