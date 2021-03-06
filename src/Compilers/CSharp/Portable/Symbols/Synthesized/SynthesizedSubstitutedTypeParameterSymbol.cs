﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// A type parameter for a synthesized class or method.
    /// </summary>
    internal sealed class SynthesizedSubstitutedTypeParameterSymbol : SubstitutedTypeParameterSymbol
    {
        public SynthesizedSubstitutedTypeParameterSymbol(Symbol owner, TypeMap map, TypeParameterSymbol substitutedFrom, int ordinal)
            : base(owner, map, substitutedFrom, ordinal)
        {
        }

        public override bool IsImplicitlyDeclared
        {
            get { return true; }
        }
    }
}
