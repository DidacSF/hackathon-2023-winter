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
    /// >> 338 - Composite[pallet_ajuna_awesome_avatars.types.account.TradeStats]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TradeStats : BaseType
    {
        
        /// <summary>
        /// >> bought
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _bought;
        
        /// <summary>
        /// >> sold
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _sold;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Bought
        {
            get
            {
                return this._bought;
            }
            set
            {
                this._bought = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Sold
        {
            get
            {
                return this._sold;
            }
            set
            {
                this._sold = value;
            }
        }
        
        public override string TypeName()
        {
            return "TradeStats";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Bought.Encode());
            result.AddRange(Sold.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Bought = new Substrate.NetApi.Model.Types.Primitive.U32();
            Bought.Decode(byteArray, ref p);
            Sold = new Substrate.NetApi.Model.Types.Primitive.U32();
            Sold.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
