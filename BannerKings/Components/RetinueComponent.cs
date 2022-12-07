using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.SaveSystem;

namespace BannerKings.Components
{
    internal class RetinueComponent : BannerKingsComponent
    {
        public RetinueComponent(Settlement origin) : base(origin, "{=!}Retinue from {ORIGIN}")
        {
            behavior = AiBehavior.Hold;
        }

        [SaveableProperty(1001)] public AiBehavior behavior { get; set; }

        private static MobileParty CreateParty(string id, Settlement origin)
        {
            return MobileParty.CreateParty(id, new RetinueComponent(origin),
                delegate(MobileParty mobileParty)
                {
                    mobileParty.SetPartyUsedByQuest(true);
                    mobileParty.Party.Visuals.SetMapIconAsDirty();
                    mobileParty.Ai.DisableAi();
                    mobileParty.Aggressiveness = 0f;
                });
        }

        public static MobileParty CreateRetinue(Settlement origin)
        {
            var retinue = CreateParty($"bk_retinue_{origin.Name}", origin);
            retinue.InitializeMobilePartyAtPosition(origin.Culture.DefaultPartyTemplate, origin.GatePosition, 4);
            EnterSettlementAction.ApplyForParty(retinue, origin);
            return retinue;
        }

        public void DailyTick(float level)
        {
            var party = MobileParty;
            var cap = (int) (level * 15f);
            if (party.MemberRoster.TotalManCount < cap)
            {
                var stacks = HomeSettlement.Culture.DefaultPartyTemplate.Stacks;
                var character = stacks[MBRandom.RandomInt(0, stacks.Count - 1)].Character;
                Party.AddMember(character, 1);
            }
            else if (party.MemberRoster.TotalManCount > cap)
            {
                var character = Party.MemberRoster.GetTroopRoster().GetRandomElement().Character;
                Party.MemberRoster.RemoveTroop(character);
            }
        }

        public override void TickHourly()
        {
            if (MobileParty.CurrentSettlement == null)
            {
                EnterSettlementAction.ApplyForParty(MobileParty, HomeSettlement);
            }

            MobileParty.SetMoveModeHold();
        }
    }
}