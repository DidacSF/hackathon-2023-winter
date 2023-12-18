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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.unincluded_segment
{
    
    
    /// <summary>
    /// >> 177 - Composite[cumulus_pallet_parachain_system.unincluded_segment.UsedBandwidth]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UsedBandwidth : BaseType
    {
        
        /// <summary>
        /// >> ump_msg_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _umpMsgCount;
        
        /// <summary>
        /// >> ump_total_bytes
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _umpTotalBytes;
        
        /// <summary>
        /// >> hrmp_outgoing
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.BTreeMapT1 _hrmpOutgoing;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 UmpMsgCount
        {
            get
            {
                return this._umpMsgCount;
            }
            set
            {
                this._umpMsgCount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 UmpTotalBytes
        {
            get
            {
                return this._umpTotalBytes;
            }
            set
            {
                this._umpTotalBytes = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.BTreeMapT1 HrmpOutgoing
        {
            get
            {
                return this._hrmpOutgoing;
            }
            set
            {
                this._hrmpOutgoing = value;
            }
        }
        
        public override string TypeName()
        {
            return "UsedBandwidth";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UmpMsgCount.Encode());
            result.AddRange(UmpTotalBytes.Encode());
            result.AddRange(HrmpOutgoing.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UmpMsgCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            UmpMsgCount.Decode(byteArray, ref p);
            UmpTotalBytes = new Substrate.NetApi.Model.Types.Primitive.U32();
            UmpTotalBytes.Decode(byteArray, ref p);
            HrmpOutgoing = new Substrate.Hexalem.NET.NetApiExt.Generated.Types.Base.BTreeMapT1();
            HrmpOutgoing.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}