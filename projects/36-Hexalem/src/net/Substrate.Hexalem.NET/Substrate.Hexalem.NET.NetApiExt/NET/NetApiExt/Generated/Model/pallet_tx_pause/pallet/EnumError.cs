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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_tx_pause.pallet
{
    
    
    public enum Error
    {
        
        IsPaused = 0,
        
        IsUnpaused = 1,
        
        Unpausable = 2,
        
        NotFound = 3,
    }
    
    /// <summary>
    /// >> 307 - Variant[pallet_tx_pause.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}