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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.v3
{
    
    
    /// <summary>
    /// >> 134 - Composite[xcm.v3.QueryResponseInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class QueryResponseInfo : BaseType
    {
        
        /// <summary>
        /// >> destination
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation _destination;
        
        /// <summary>
        /// >> query_id
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> _queryId;
        
        /// <summary>
        /// >> max_weight
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _maxWeight;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation Destination
        {
            get
            {
                return this._destination;
            }
            set
            {
                this._destination = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64> QueryId
        {
            get
            {
                return this._queryId;
            }
            set
            {
                this._queryId = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight MaxWeight
        {
            get
            {
                return this._maxWeight;
            }
            set
            {
                this._maxWeight = value;
            }
        }
        
        public override string TypeName()
        {
            return "QueryResponseInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Destination.Encode());
            result.AddRange(QueryId.Encode());
            result.AddRange(MaxWeight.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Destination = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation();
            Destination.Decode(byteArray, ref p);
            QueryId = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
            QueryId.Decode(byteArray, ref p);
            MaxWeight = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            MaxWeight.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
