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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue
{
    
    
    /// <summary>
    /// >> 402 - Composite[cumulus_pallet_xcmp_queue.QueueConfigData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class QueueConfigData : BaseType
    {
        
        /// <summary>
        /// >> suspend_threshold
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _suspendThreshold;
        
        /// <summary>
        /// >> drop_threshold
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _dropThreshold;
        
        /// <summary>
        /// >> resume_threshold
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _resumeThreshold;
        
        /// <summary>
        /// >> threshold_weight
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _thresholdWeight;
        
        /// <summary>
        /// >> weight_restrict_decay
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _weightRestrictDecay;
        
        /// <summary>
        /// >> xcmp_max_individual_weight
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _xcmpMaxIndividualWeight;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SuspendThreshold
        {
            get
            {
                return this._suspendThreshold;
            }
            set
            {
                this._suspendThreshold = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 DropThreshold
        {
            get
            {
                return this._dropThreshold;
            }
            set
            {
                this._dropThreshold = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ResumeThreshold
        {
            get
            {
                return this._resumeThreshold;
            }
            set
            {
                this._resumeThreshold = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight ThresholdWeight
        {
            get
            {
                return this._thresholdWeight;
            }
            set
            {
                this._thresholdWeight = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight WeightRestrictDecay
        {
            get
            {
                return this._weightRestrictDecay;
            }
            set
            {
                this._weightRestrictDecay = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight XcmpMaxIndividualWeight
        {
            get
            {
                return this._xcmpMaxIndividualWeight;
            }
            set
            {
                this._xcmpMaxIndividualWeight = value;
            }
        }
        
        public override string TypeName()
        {
            return "QueueConfigData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SuspendThreshold.Encode());
            result.AddRange(DropThreshold.Encode());
            result.AddRange(ResumeThreshold.Encode());
            result.AddRange(ThresholdWeight.Encode());
            result.AddRange(WeightRestrictDecay.Encode());
            result.AddRange(XcmpMaxIndividualWeight.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SuspendThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            SuspendThreshold.Decode(byteArray, ref p);
            DropThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            DropThreshold.Decode(byteArray, ref p);
            ResumeThreshold = new Substrate.NetApi.Model.Types.Primitive.U32();
            ResumeThreshold.Decode(byteArray, ref p);
            ThresholdWeight = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            ThresholdWeight.Decode(byteArray, ref p);
            WeightRestrictDecay = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            WeightRestrictDecay.Decode(byteArray, ref p);
            XcmpMaxIndividualWeight = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            XcmpMaxIndividualWeight.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
