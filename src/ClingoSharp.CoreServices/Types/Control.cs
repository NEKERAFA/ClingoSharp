﻿using ClingoSharp.CoreServices.Interfaces;
using System;

namespace ClingoSharp.CoreServices.Types
{
    /// <summary>
    /// Control object holding grounding and solving state
    /// </summary>
    public sealed class Control : IClingoObject
    {
        public IntPtr Object { get; set; }
    }
}
