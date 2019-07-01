﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    interface IWeapons
    {
        /// <summary>
        /// Set AttackPower on each single weapon
        /// </summary>
        void AttackPower();

        /// <summary>
        /// Check Durability of weapons
        /// </summary>
        void Durability();
    }
}
