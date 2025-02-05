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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> 62 - Composite[pallet_ajuna_awesome_avatars.types.config.MintConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintConfig : BaseType
    {
        
        /// <summary>
        /// >> open
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _open;
        
        /// <summary>
        /// >> cooldown
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _cooldown;
        
        /// <summary>
        /// >> free_mint_fee_multiplier
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U16 _freeMintFeeMultiplier;
        
        public Substrate.NetApi.Model.Types.Primitive.Bool Open
        {
            get
            {
                return this._open;
            }
            set
            {
                this._open = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Cooldown
        {
            get
            {
                return this._cooldown;
            }
            set
            {
                this._cooldown = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U16 FreeMintFeeMultiplier
        {
            get
            {
                return this._freeMintFeeMultiplier;
            }
            set
            {
                this._freeMintFeeMultiplier = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Open.Encode());
            result.AddRange(Cooldown.Encode());
            result.AddRange(FreeMintFeeMultiplier.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Open = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Open.Decode(byteArray, ref p);
            Cooldown = new Substrate.NetApi.Model.Types.Primitive.U32();
            Cooldown.Decode(byteArray, ref p);
            FreeMintFeeMultiplier = new Substrate.NetApi.Model.Types.Primitive.U16();
            FreeMintFeeMultiplier.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
