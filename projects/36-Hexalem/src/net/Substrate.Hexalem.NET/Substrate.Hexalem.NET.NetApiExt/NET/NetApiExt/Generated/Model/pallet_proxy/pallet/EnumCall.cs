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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Call
    {
        
        proxy = 0,
        
        add_proxy = 1,
        
        remove_proxy = 2,
        
        remove_proxies = 3,
        
        create_pure = 4,
        
        kill_pure = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        reject_announcement = 8,
        
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 227 - Variant[pallet_proxy.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType>, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumProxyType>, Substrate.Hexalem.NET.NetApiExt.Generated.Model.container_chain_template_simple_runtime.EnumRuntimeCall>>
    {
    }
}
