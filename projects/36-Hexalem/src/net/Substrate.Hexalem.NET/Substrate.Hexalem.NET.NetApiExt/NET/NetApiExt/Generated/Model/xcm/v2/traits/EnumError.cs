//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.xcm.v2.traits
{
    
    
    public enum Error
    {
        
        Overflow = 0,
        
        Unimplemented = 1,
        
        UntrustedReserveLocation = 2,
        
        UntrustedTeleportLocation = 3,
        
        MultiLocationFull = 4,
        
        MultiLocationNotInvertible = 5,
        
        BadOrigin = 6,
        
        InvalidLocation = 7,
        
        AssetNotFound = 8,
        
        FailedToTransactAsset = 9,
        
        NotWithdrawable = 10,
        
        LocationCannotHold = 11,
        
        ExceedsMaxMessageSize = 12,
        
        DestinationUnsupported = 13,
        
        Transport = 14,
        
        Unroutable = 15,
        
        UnknownClaim = 16,
        
        FailedToDecode = 17,
        
        MaxWeightInvalid = 18,
        
        NotHoldingFees = 19,
        
        TooExpensive = 20,
        
        Trap = 21,
        
        UnhandledXcmVersion = 22,
        
        WeightLimitReached = 23,
        
        Barrier = 24,
        
        WeightNotComputable = 25,
    }
    
    /// <summary>
    /// >> 279 - Variant[xcm.v2.traits.Error]
    /// </summary>
    public sealed class EnumError : BaseEnumExt<Error, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U64, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U64, BaseVoid, BaseVoid>
    {
    }
}
