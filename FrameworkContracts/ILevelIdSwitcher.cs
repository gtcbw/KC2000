﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkContracts
{
    public interface ILevelIdSwitcher
    {
        void SwitchToNextLevel();

        void SetSpecificLevel(int id);
    }
}