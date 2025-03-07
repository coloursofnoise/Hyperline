﻿using System;
using System.Globalization;
using System.Reflection;
using Microsoft.Xna.Framework;
using FMOD.Studio;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Celeste.Mod.UI;
using Monocle;
using On.Celeste;
using IL.MonoMod;
using FMOD;
using System.IO;

namespace Celeste.Mod.Hyperline
{
    public interface IHairType
    {
        string GetHairName();
        Color GetColor(float phase);
        void Read(BinaryReader reader, byte[] version);
        void Write(BinaryWriter writer);
        IHairType CreateNew();
        IHairType CreateNew(int i);
        List<TextMenu.Item> CreateMenu(TextMenu menu, bool inGame);
    }
}
