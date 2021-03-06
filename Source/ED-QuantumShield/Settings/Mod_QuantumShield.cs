﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace ED_QuantumShield.Settings
{
    class Mod_QuantumShield : Verse.Mod
    {

        public static ModSettings_ED_QuantumShield Settings;
        
        public Mod_QuantumShield(ModContentPack content) : base(content)
        {
            Mod_QuantumShield.Settings = GetSettings<ModSettings_ED_QuantumShield>();
        }

        public override string SettingsCategory()
        {
            return "ED-QuantumShield";
            //return base.SettingsCategory();
        }
        
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoSettingsWindowContents(inRect);
            //base.DoSettingsWindowContents(inRect);
        }

    }
}
