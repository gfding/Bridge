﻿using System;
namespace Bridge.CLR.Html
{
    /// <summary>
    /// Relationship of nodes
    /// </summary>
    [Bridge.CLR.Ignore]
    [Bridge.CLR.EnumEmit(EnumEmit.Value)]
    [Bridge.CLR.Name("Number")]
    [Flags]
    public enum DocumentPosition
    {
        Disconnected = 1,
        Preceding = 2,
        Following = 4,
        Contains = 8,
        ContainedBy = 16,
        ImplementationSpecific = 32
    }
}