﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using DaggerfallConnect;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Chameleon - Normal
    /// </summary>
    public class ChameleonNormal : BaseEntityEffect
    {
        public override void SetProperties()
        {
            properties.Key = "Chameleon-Normal";
            properties.ClassicKey = MakeClassicKey(23, 0);
            properties.GroupName = TextManager.Instance.GetText("ClassicEffects", "chameleon");
            properties.SubGroupName = TextManager.Instance.GetText("ClassicEffects", "normal");
            properties.DisplayName = string.Format("{0} ({1})", properties.GroupName, properties.SubGroupName);
            properties.SpellMakerDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1571);
            properties.SpellBookDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1271);
            properties.SupportDuration = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_All;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = EntityEffectBroker.MagicCraftingFlags_None;
            properties.MagicSkill = DFCareer.MagicSkills.Illusion;
            properties.DurationCosts = MakeEffectCosts(20, 80);
        }

        public override void MagicRound()
        {
            base.MagicRound();

            //// Get peered entity gameobject
            //DaggerfallEntityBehaviour entityBehaviour = GetPeeredEntityBehaviour(manager);
            //if (!entityBehaviour)
            //    return;

            // TODO: Implement effect
        }
    }
}