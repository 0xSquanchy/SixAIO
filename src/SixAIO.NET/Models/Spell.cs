﻿using Oasys.Common.Enums.GameEnums;
using Oasys.SDK;
using Oasys.SDK.SpellCasting;

namespace SixAIO.Models
{
    public class Spell : SDKSpell
    {
        public Spell(CastSlot castSlot, SpellSlot spellSlot) : base(castSlot, spellSlot)
        {
        }
    }
}
