﻿using SPTarkov.Common.Models.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.Models.Spt.Tables;
using WTTServerCommonLib.Helpers;


namespace RussianSFPack.Helpers
{
    [Injectable]
    public class EcoQuestHelper(TemplateTable templateTable, ISptLogger<EcoQuestHelper> logger, QuestHelper questHelper)
    {

        // Define weapon IDs
        // ReSharper disable InconsistentNaming
        // ReSharper disable IdentifierTypo
        //snipers
        private const string VSSK = "6aac31fac35219b1cf4d2a84";
        
        //shotguns
        private const string VEPR12 = "6aa59cd69d536417f3e88939";
        
        //smg
        private const string PP2000 = "6a9ab5e9753eac745a4ce5ca";

        //pistols
        private const string PLK = "6a9e7c7ba77d4b62cecda25a";
        
        //rifles 
        private const string AM17 = "6a9417f9e097b0c6ce414793";
        private const string AMB17 = "6a8ada430d43213c92dbe371";
        private const string ADS = "6a968b0a910dd21fbe9e374b";
        private const string AK200 = "6a9888aa03930f8d769fde27";
        private const string AK205 = "6a9954b397425139faf657d3";
        private const string A762 = "6a9d77d61b88e55ada72f237";
        
        //dmr
        private const string SVCH = "6aa07d6955c3a243f195ed5f";
        private const string SVDM = "6aa9bd88a1ebc11ab0a6b50c";
        
        // Weapon Mods
        
        public void ModifyQuests()
        {
            var quests = templateTable.Quests;

            // ReSharper disable CommentTypo
            // ====================== PRAPOR QUESTS ======================
            //
            // // Punisher Part 4 (59ca264786f77445a80ed044)
            questHelper.AddWeaponsToKillCondition(quests, "59ca264786f77445a80ed044", [
                VEPR12
            ]);

            // // Mall Cop (64e7b99017ab941a6f7bf9d7)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b99017ab941a6f7bf9d7", [
                PLK
            ]);

            // Tickets, Please (64e7b9a4aac4cd0a726562cb)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9a4aac4cd0a726562cb", [
                PP2000
            ]);

            // District Patrol (64e7b9bffd30422ed03dad38)
            questHelper.AddWeaponsToKillCondition(quests, "64e7b9bffd30422ed03dad38", [
                AM17, AMB17, AK200, AK205, ADS, A762
            ]);

            // ====================== SKIER QUESTS ======================

            // Stirrup (596b455186f77457cb50eccb)
            questHelper.AddWeaponsToKillCondition(quests, "596b455186f77457cb50eccb", [
                PLK
            ]);

            // // Silent Caliber (5c0bc91486f7746ab41857a2)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bc91486f7746ab41857a2", [
                VEPR12
            ]);
            //
            // // Setup (5c1234c286f77406fa13baeb)
            questHelper.AddWeaponsToKillCondition(quests, "5c1234c286f77406fa13baeb", [
                VEPR12
            ]);

            // Connections Up North (6764174c86addd02bc033d68)
            questHelper.AddWeaponsToKillCondition(quests, "6764174c86addd02bc033d68", [
              VSSK
            ]);

            // ====================== PEACEKEEPER QUESTS ======================

            // // Spa Tour Part 1 (5a03153686f77442d90e2171)
            questHelper.AddWeaponsToKillCondition(quests, "5a03153686f77442d90e2171", [
                VEPR12
            ]);
            //
            // // Worst Job (63a9b229813bba58a50c9ee5)
            // questHelper.AddWeaponsToKillCondition(quests, "63a9b229813bba58a50c9ee5", [
            //     LR300, LR300_FDE, TT_TR1, BRN180, BRN180_FDE
            // ]);

            // ====================== JAEGER QUESTS ======================

            var tarkovShooterWeapons = new[]
            {
                VSSK
            };

            // Tarkov Shooter Part 1-8 (WEAPONS)
            questHelper.AddWeaponsToKillCondition(quests, "5bc4776586f774512d07cf05", tarkovShooterWeapons); // Part 1
            questHelper.AddWeaponsToKillCondition(quests, "5bc479e586f7747f376c7da3", tarkovShooterWeapons); // Part 2
            questHelper.AddWeaponsToKillCondition(quests, "5bc47dbf86f7741ee74e93b9", tarkovShooterWeapons); // Part 3
            questHelper.AddWeaponsToKillCondition(quests, "5bc480a686f7741af0342e29", tarkovShooterWeapons); // Part 4
            questHelper.AddWeaponsToKillCondition(quests, "5bc4826c86f774106d22d88b", tarkovShooterWeapons); // Part 5
            questHelper.AddWeaponsToKillCondition(quests, "5bc4836986f7740c0152911c", tarkovShooterWeapons); // Part 6
            questHelper.AddWeaponsToKillCondition(quests, "5bc4856986f77454c317bea7", tarkovShooterWeapons); // Part 7
            questHelper.AddWeaponsToKillCondition(quests, "5bc4893c86f774626f5ebf3e", tarkovShooterWeapons); // Part 8

            // Tarkov Shooter Part 1-8 (MODS)
            
            // Part 1
            
            // Part 7
//
//
//             
//             // // Claustrophobia (669fa3979b0ce3feae01a130)
              questHelper.AddWeaponsToKillCondition(quests, "669fa3979b0ce3feae01a130", [
                VEPR12
             ]);
//
//             // ====================== MECHANIC QUESTS ======================
//
            // Psycho Sniper (5c0be13186f7746f016734aa)
            questHelper.AddWeaponsToKillCondition(quests, "5c0be13186f7746f016734aa", [
                VSSK
            ]);

            // Shooter Born in Heaven (5c0bde0986f77479cf22c2f8)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bde0986f77479cf22c2f8", [
                VSSK
            ]);

            // Make Amends Equipment (6261482fa4eb80027c4f2e11)
            questHelper.AddWeaponsToFindOrHandoverCondition(quests, "6261482fa4eb80027c4f2e11", [
                SVDM, SVCH
            ]);
        }
    }
}
