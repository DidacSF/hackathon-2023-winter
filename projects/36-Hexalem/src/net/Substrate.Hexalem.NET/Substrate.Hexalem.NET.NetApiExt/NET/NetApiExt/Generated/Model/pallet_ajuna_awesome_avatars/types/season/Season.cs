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


namespace Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season
{
    
    
    /// <summary>
    /// >> 49 - Composite[pallet_ajuna_awesome_avatars.types.season.Season]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Season : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 _name;
        
        /// <summary>
        /// >> description
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 _description;
        
        /// <summary>
        /// >> early_start
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _earlyStart;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _start;
        
        /// <summary>
        /// >> end
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _end;
        
        /// <summary>
        /// >> max_tier_forges
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxTierForges;
        
        /// <summary>
        /// >> max_variations
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _maxVariations;
        
        /// <summary>
        /// >> max_components
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _maxComponents;
        
        /// <summary>
        /// >> min_sacrifices
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _minSacrifices;
        
        /// <summary>
        /// >> max_sacrifices
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _maxSacrifices;
        
        /// <summary>
        /// >> tiers
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 _tiers;
        
        /// <summary>
        /// >> single_mint_probs
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 _singleMintProbs;
        
        /// <summary>
        /// >> batch_mint_probs
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 _batchMintProbs;
        
        /// <summary>
        /// >> base_prob
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _baseProb;
        
        /// <summary>
        /// >> per_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _perPeriod;
        
        /// <summary>
        /// >> periods
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U16 _periods;
        
        /// <summary>
        /// >> trade_filters
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 _tradeFilters;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.Fee _fee;
        
        /// <summary>
        /// >> mint_logic
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration _mintLogic;
        
        /// <summary>
        /// >> forge_logic
        /// </summary>
        private Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration _forgeLogic;
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 EarlyStart
        {
            get
            {
                return this._earlyStart;
            }
            set
            {
                this._earlyStart = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxTierForges
        {
            get
            {
                return this._maxTierForges;
            }
            set
            {
                this._maxTierForges = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxVariations
        {
            get
            {
                return this._maxVariations;
            }
            set
            {
                this._maxVariations = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxComponents
        {
            get
            {
                return this._maxComponents;
            }
            set
            {
                this._maxComponents = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 MinSacrifices
        {
            get
            {
                return this._minSacrifices;
            }
            set
            {
                this._minSacrifices = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxSacrifices
        {
            get
            {
                return this._maxSacrifices;
            }
            set
            {
                this._maxSacrifices = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 Tiers
        {
            get
            {
                return this._tiers;
            }
            set
            {
                this._tiers = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 SingleMintProbs
        {
            get
            {
                return this._singleMintProbs;
            }
            set
            {
                this._singleMintProbs = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 BatchMintProbs
        {
            get
            {
                return this._batchMintProbs;
            }
            set
            {
                this._batchMintProbs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 BaseProb
        {
            get
            {
                return this._baseProb;
            }
            set
            {
                this._baseProb = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 PerPeriod
        {
            get
            {
                return this._perPeriod;
            }
            set
            {
                this._perPeriod = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U16 Periods
        {
            get
            {
                return this._periods;
            }
            set
            {
                this._periods = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 TradeFilters
        {
            get
            {
                return this._tradeFilters;
            }
            set
            {
                this._tradeFilters = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.Fee Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration MintLogic
        {
            get
            {
                return this._mintLogic;
            }
            set
            {
                this._mintLogic = value;
            }
        }
        
        public Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration ForgeLogic
        {
            get
            {
                return this._forgeLogic;
            }
            set
            {
                this._forgeLogic = value;
            }
        }
        
        public override string TypeName()
        {
            return "Season";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(EarlyStart.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(End.Encode());
            result.AddRange(MaxTierForges.Encode());
            result.AddRange(MaxVariations.Encode());
            result.AddRange(MaxComponents.Encode());
            result.AddRange(MinSacrifices.Encode());
            result.AddRange(MaxSacrifices.Encode());
            result.AddRange(Tiers.Encode());
            result.AddRange(SingleMintProbs.Encode());
            result.AddRange(BatchMintProbs.Encode());
            result.AddRange(BaseProb.Encode());
            result.AddRange(PerPeriod.Encode());
            result.AddRange(Periods.Encode());
            result.AddRange(TradeFilters.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(MintLogic.Encode());
            result.AddRange(ForgeLogic.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
            Name.Decode(byteArray, ref p);
            Description = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3();
            Description.Decode(byteArray, ref p);
            EarlyStart = new Substrate.NetApi.Model.Types.Primitive.U32();
            EarlyStart.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            End = new Substrate.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            MaxTierForges = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxTierForges.Decode(byteArray, ref p);
            MaxVariations = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxVariations.Decode(byteArray, ref p);
            MaxComponents = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxComponents.Decode(byteArray, ref p);
            MinSacrifices = new Substrate.NetApi.Model.Types.Primitive.U8();
            MinSacrifices.Decode(byteArray, ref p);
            MaxSacrifices = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxSacrifices.Decode(byteArray, ref p);
            Tiers = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4();
            Tiers.Decode(byteArray, ref p);
            SingleMintProbs = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
            SingleMintProbs.Decode(byteArray, ref p);
            BatchMintProbs = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
            BatchMintProbs.Decode(byteArray, ref p);
            BaseProb = new Substrate.NetApi.Model.Types.Primitive.U8();
            BaseProb.Decode(byteArray, ref p);
            PerPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            PerPeriod.Decode(byteArray, ref p);
            Periods = new Substrate.NetApi.Model.Types.Primitive.U16();
            Periods.Decode(byteArray, ref p);
            TradeFilters = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
            TradeFilters.Decode(byteArray, ref p);
            Fee = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.Fee();
            Fee.Decode(byteArray, ref p);
            MintLogic = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration();
            MintLogic.Decode(byteArray, ref p);
            ForgeLogic = new Substrate.Hexalem.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration();
            ForgeLogic.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
