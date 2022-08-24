using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings.Managers.Populations.Villages
{
    public class DefaultVillageBuildings : DefaultTypeInitializer<DefaultVillageBuildings, BuildingType>
    {
        public BuildingType Manor { get; private set; }

        public BuildingType Palisade { get; private set; }

        public BuildingType TrainningGrounds { get; private set; }

        public BuildingType Warehouse { get; private set; }

        public BuildingType Courier { get; private set; }

        public BuildingType Bakery { get; private set; }

        public BuildingType Mining { get; private set; }

        public BuildingType Farming { get; private set; }

        public BuildingType Sawmill { get; private set; }

        public BuildingType AnimalHousing { get; private set; }

        public BuildingType Butter { get; private set; }

        public BuildingType FishFarm { get; private set; }

        public BuildingType Tannery { get; private set; }

        public BuildingType Blacksmith { get; private set; }

        public BuildingType DailyProduction { get; private set; }

        public BuildingType DailyFarm { get; private set; }

        public BuildingType DailyPasture { get; private set; }

        public BuildingType DailyWoods { get; private set; }

        public override IEnumerable<BuildingType> All
        {
            get
            {
                yield return Instance.Manor;
                yield return Instance.Palisade;
                yield return Instance.TrainningGrounds;
                yield return Instance.Warehouse;
                yield return Instance.DailyProduction;
                yield return Instance.DailyFarm;
                yield return Instance.DailyPasture;
                yield return Instance.DailyWoods;
                yield return Instance.Farming;
                yield return Instance.Mining;
                yield return Instance.AnimalHousing;
                yield return Instance.Sawmill;
                yield return Instance.FishFarm;
                yield return Instance.Tannery;
                yield return Instance.Blacksmith;
            }
        }


        public override void Initialize()
        {
            Manor = new BuildingType("bannerkings_manor");
            Game.Current.ObjectManager.RegisterPresumedObject(Manor);
            Manor.Initialize(new TextObject("{=x0vaFY1a0}Manor"),
                new TextObject(
                    "{=x0vaFY1a0}Manor house, the lord's home and center of the village. A manor house allows the housing of a small retinue in the village (15, 30, 45 men). Increases influence from nobles (15%, 30%, 50%)."),
                new[]
                {
                    4000,
                    6000,
                    8000
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Palisade = new BuildingType("bannerkings_palisade");
            Game.Current.ObjectManager.RegisterPresumedObject(Palisade);
            Palisade.Initialize(new TextObject("{=zWYPHE4iD}Palisade"),
                new TextObject(
                    "{=yjcCteGSv}A set of wooden stakes placed around the village like a wall. Reduces raiding speed (12%, 24%, 36%)."),
                new[]
                {
                    3000,
                    5000,
                    7000
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            TrainningGrounds = new BuildingType("bannerkings_trainning");
            Game.Current.ObjectManager.RegisterPresumedObject(TrainningGrounds);
            TrainningGrounds.Initialize(new TextObject("{=8GPq3YN4k}Trainning Grounds"),
                new TextObject(
                    "{=yDd6E5jWB}Stablish a zone dedicated for trainning, as well as it's required equipments, where locals can train basic military arts. Increases militia production (0.2, 0.5, 1.0)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Warehouse = new BuildingType("bannerkings_warehouse");
            Game.Current.ObjectManager.RegisterPresumedObject(Warehouse);
            Warehouse.Initialize(new TextObject("{=PpSekPH5M}Arms Warehouse"),
                new TextObject(
                    "{=mHfHiuLt1}Construct a warehouse dedicated to keep military equipment as well as provide their maintenance. Improves militia quality (4%, 8%, 12%)."),
                new[]
                {
                    2000,
                    3000,
                    4000
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Game.Current.ObjectManager.RegisterPresumedObject(new BuildingType("bannerkings_warehouse"));

            Courier = new BuildingType("bannerkings_courier");
            Courier.Initialize(new TextObject("{=HkLYroYwq}Courier Post"),
                new TextObject(
                    "{=wPBXpcmaj}Set up a dedicate courier post that will inform you of any relevant activity in and around your demesne. Enables information messages regardless of your distance."),
                new[]
                {
                    1000,
                    1800,
                    2500
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Bakery = new BuildingType("bannerkings_bakery");
            Bakery.Initialize(new TextObject("{=NHxd8PxOb}Bakery"),
                new TextObject(
                    "{=pMK7GOmCy}Supply tools and space for a local bakery, allowing serfs to turn wheat into bread. Adds bread as production good."),
                new[]
                {
                    1000,
                    1800,
                    2500
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Mining = new BuildingType("bannerkings_mining");
            Game.Current.ObjectManager.RegisterPresumedObject(Mining);
            Mining.Initialize(new TextObject("{=bW7viQSJa}Mining Infrastructure"),
                new TextObject(
                    "{=7vMrRZnL7}Build mining equipment and infrastructure to improve working conditions in local mines. Increases ore production (5%, 10%, 15%)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            AnimalHousing = new BuildingType("bannerkings_animal_housing");
            Game.Current.ObjectManager.RegisterPresumedObject(AnimalHousing);
            AnimalHousing.Initialize(new TextObject("{=3hgdpE0M7}Animal Housing"),
                new TextObject(
                    "{=oTXWSh3QB}Invest on infrastructure for animal housing and grazing, yielding more from your pasture lands. Increases live animals production (5%, 10%, 15%)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Farming = new BuildingType("bannerkings_farming");
            Game.Current.ObjectManager.RegisterPresumedObject(Farming);
            Farming.Initialize(new TextObject("{=DRNFGtOZ3}Farming Infrastructure"),
                new TextObject(
                    "{=JcH4ADwSS}Provide farming equipment and stablish systems to maximise land productivity. Increases farm goods production (5%, 10%, 15%)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Sawmill = new BuildingType("bannerkings_sawmill");
            Game.Current.ObjectManager.RegisterPresumedObject(Sawmill);
            Sawmill.Initialize(new TextObject("{=oQQ9r1Drx}Sawmill"),
                new TextObject(
                    "{=Pkfq5jpYY}Build a sawmill, improving the speed and quality of log cutting into usable hardwood. Increases hardwood production (5%, 10%, 15%)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Butter = new BuildingType("bannerkings_butter");
            Butter.Initialize(new TextObject("{=qUFgHwQnT}Butter Mill"),
                new TextObject(
                    "{=msFdbSEnq}Construct specialized buildings for churning local cattle milk into butter, a highly sought after food amongst lords."),
                new[]
                {
                    1000,
                    1800,
                    2500
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Tannery = new BuildingType("bannerkings_tannery");
            Tannery.Initialize(new TextObject("{=0QiwqCnDN}Fur Tannery"),
                new TextObject(
                    "{=hP4T6xt8v}Construct specialized buildings for tanning hides, turning these into leather. Adds leather to production."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            FishFarm = new BuildingType("bannerkings_fishing");
            FishFarm.Initialize(new TextObject("{=0qxkebfbL}Fish Farm"),
                new TextObject(
                    "{=qqSgaBBYB}Build controlled fish growing zones, supplying extra fish to the village. Increases fish production (5%, 10%, 15%)."),
                new[]
                {
                    1500,
                    2400,
                    3200
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            Blacksmith = new BuildingType("bannerkings_blacksmith");
            Blacksmith.Initialize(new TextObject("{=Kxpq6xBkD}Smith"),
                new TextObject(
                    "{=jQMTcT47D}Stablish a local blacksmith, supplying the village with metal products. Adds tools to production."),
                new[]
                {
                    1000,
                    1800,
                    2500
                }, BuildingLocation.Settlement, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });


            DailyProduction = new BuildingType("bannerkings_daily_production");
            Game.Current.ObjectManager.RegisterPresumedObject(DailyProduction);
            DailyProduction.Initialize(new TextObject("{=iNCspsdSa}Production"),
                new TextObject(
                    "{=0NCbOeDgb}Focus the population's effort in productivity, not expanding land or changing it's type. While this option is not active, productivity output is reduced."),
                new int[3], BuildingLocation.Daily, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            DailyFarm = new BuildingType("bannerkings_daily_farm");
            Game.Current.ObjectManager.RegisterPresumedObject(DailyFarm);
            DailyFarm.Initialize(new TextObject("{=LfwuMvg89}Farmland"),
                new TextObject(
                    "{=mf24VdsCj}Focus efforts on creating new arable acres, used for farming purposes. More farming acres increase output of farming goods."),
                new int[3], BuildingLocation.Daily, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            DailyPasture = new BuildingType("bannerkings_daily_pasture");
            Game.Current.ObjectManager.RegisterPresumedObject(DailyPasture);
            DailyPasture.Initialize(new TextObject("{=ieMoNvcMQ}Pastureland"),
                new TextObject(
                    "{=py5iCOrHc}Focus efforts on creating new acres of pasture, where cattle and animals graze and thrive. More pasture acres increase output of animals and animal products."),
                new int[3], BuildingLocation.Daily, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });

            DailyWoods = new BuildingType("bannerkings_daily_woods");
            Game.Current.ObjectManager.RegisterPresumedObject(DailyWoods);
            DailyWoods.Initialize(new TextObject("{=2ESkmf9ng}Woodland"),
                new TextObject(
                    "{=sowuAn6a4}Focus efforts on turning acres into woodlands. Acres of woodland allow more higher yields of logs and berries, as well as help the land not becoming overfarmed or grazed."),
                new int[3], BuildingLocation.Daily, new Tuple<BuildingEffectEnum, float, float, float>[]
                {
                });
        }

        public static IEnumerable<BuildingType> VillageBuildings(Village village)
        {
            var type = village.VillageType;
            yield return Instance.Manor;
            yield return Instance.Palisade;
            yield return Instance.TrainningGrounds;
            yield return Instance.Warehouse;
            yield return Instance.DailyProduction;
            yield return Instance.DailyFarm;
            yield return Instance.DailyPasture;
            yield return Instance.DailyWoods;
            if (type == DefaultVillageTypes.WheatFarm || type == DefaultVillageTypes.DateFarm ||
                type == DefaultVillageTypes.FlaxPlant ||
                type == DefaultVillageTypes.SilkPlant || type == DefaultVillageTypes.OliveTrees ||
                type == DefaultVillageTypes.VineYard)
            {
                yield return Instance.Farming;
            }
            else if (type == DefaultVillageTypes.SilverMine || type == DefaultVillageTypes.IronMine ||
                     type == DefaultVillageTypes.SaltMine ||
                     type == DefaultVillageTypes.ClayMine)
            {
                yield return Instance.Mining;
            }
            else if (type == DefaultVillageTypes.CattleRange || type == DefaultVillageTypes.HogFarm ||
                     type == DefaultVillageTypes.SheepFarm ||
                     type == DefaultVillageTypes.BattanianHorseRanch || type == DefaultVillageTypes.DesertHorseRanch ||
                     type == DefaultVillageTypes.EuropeHorseRanch
                     || type == DefaultVillageTypes.SteppeHorseRanch || type == DefaultVillageTypes.SturgianHorseRanch ||
                     type == DefaultVillageTypes.VlandianHorseRanch)
            {
                yield return Instance.AnimalHousing;
            }
            else if (type == DefaultVillageTypes.Lumberjack)
            {
                yield return Instance.Sawmill;
            }
            else if (type == DefaultVillageTypes.Fisherman)
            {
                yield return Instance.FishFarm;
            }
            else
            {
                yield return Instance.Tannery;
            }

            if (type == DefaultVillageTypes.IronMine)
            {
                yield return Instance.Blacksmith;
            }
        }
    }
}