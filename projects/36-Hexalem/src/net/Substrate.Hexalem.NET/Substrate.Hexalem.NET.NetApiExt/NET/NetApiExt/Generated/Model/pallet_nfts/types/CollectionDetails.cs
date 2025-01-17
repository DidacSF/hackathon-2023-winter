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
    /// >> 361 - Composite[pallet_nfts.types.CollectionDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CollectionDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> owner_deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _ownerDeposit;
        
        /// <summary>
        /// >> items
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _items;
        
        /// <summary>
        /// >> item_metadatas
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _itemMetadatas;
        
        /// <summary>
        /// >> item_configs
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _itemConfigs;
        
        /// <summary>
        /// >> attributes
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _attributes;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 OwnerDeposit
        {
            get
            {
                return this._ownerDeposit;
            }
            set
            {
                this._ownerDeposit = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ItemMetadatas
        {
            get
            {
                return this._itemMetadatas;
            }
            set
            {
                this._itemMetadatas = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ItemConfigs
        {
            get
            {
                return this._itemConfigs;
            }
            set
            {
                this._itemConfigs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Attributes
        {
            get
            {
                return this._attributes;
            }
            set
            {
                this._attributes = value;
            }
        }
        
        public override string TypeName()
        {
            return "CollectionDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(OwnerDeposit.Encode());
            result.AddRange(Items.Encode());
            result.AddRange(ItemMetadatas.Encode());
            result.AddRange(ItemConfigs.Encode());
            result.AddRange(Attributes.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            OwnerDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            OwnerDeposit.Decode(byteArray, ref p);
            Items = new Substrate.NetApi.Model.Types.Primitive.U32();
            Items.Decode(byteArray, ref p);
            ItemMetadatas = new Substrate.NetApi.Model.Types.Primitive.U32();
            ItemMetadatas.Decode(byteArray, ref p);
            ItemConfigs = new Substrate.NetApi.Model.Types.Primitive.U32();
            ItemConfigs.Decode(byteArray, ref p);
            Attributes = new Substrate.NetApi.Model.Types.Primitive.U32();
            Attributes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
