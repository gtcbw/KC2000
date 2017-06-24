﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkContracts
{
    public enum Keys
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,
        ControlLeft, ControlRight, ShiftLeft, ShiftRight,
        Num0, Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Enter, Space, Escape,
        F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
        Delete,
        Up,
        Down,
        Left,
        Right
    }
    public interface IPressedKeyDetector
    {
        bool IsKeyDown(Keys key);
    }
}