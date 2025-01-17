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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar
{
    
    
    /// <summary>
    /// >> 326 - Composite[pallet_ajuna_awesome_avatars.types.avatar.Avatar]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Avatar : BaseType
    {
        
        /// <summary>
        /// >> season_id
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U16 _seasonId;
        
        /// <summary>
        /// >> encoding
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumDnaEncoding _encoding;
        
        /// <summary>
        /// >> dna
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 _dna;
        
        /// <summary>
        /// >> souls
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _souls;
        
        public Substrate.NetApi.Model.Types.Primitive.U16 SeasonId
        {
            get
            {
                return this._seasonId;
            }
            set
            {
                this._seasonId = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumDnaEncoding Encoding
        {
            get
            {
                return this._encoding;
            }
            set
            {
                this._encoding = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 Dna
        {
            get
            {
                return this._dna;
            }
            set
            {
                this._dna = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Souls
        {
            get
            {
                return this._souls;
            }
            set
            {
                this._souls = value;
            }
        }
        
        public override string TypeName()
        {
            return "Avatar";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SeasonId.Encode());
            result.AddRange(Encoding.Encode());
            result.AddRange(Dna.Encode());
            result.AddRange(Souls.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SeasonId = new Substrate.NetApi.Model.Types.Primitive.U16();
            SeasonId.Decode(byteArray, ref p);
            Encoding = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumDnaEncoding();
            Encoding.Decode(byteArray, ref p);
            Dna = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
            Dna.Decode(byteArray, ref p);
            Souls = new Substrate.NetApi.Model.Types.Primitive.U32();
            Souls.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
