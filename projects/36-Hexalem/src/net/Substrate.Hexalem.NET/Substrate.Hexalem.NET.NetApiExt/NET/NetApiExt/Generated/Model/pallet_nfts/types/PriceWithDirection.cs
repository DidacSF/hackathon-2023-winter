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
    /// >> 86 - Composite[pallet_nfts.types.PriceWithDirection]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PriceWithDirection : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> direction
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumPriceDirection _direction;
        
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
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumPriceDirection Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }
        
        public override string TypeName()
        {
            return "PriceWithDirection";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Direction.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Direction = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumPriceDirection();
            Direction.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
