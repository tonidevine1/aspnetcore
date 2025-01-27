// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Razor.Language
{
    internal class DirectiveTokenDescriptorComparer : IEqualityComparer<DirectiveTokenDescriptor>
    {
        public static readonly DirectiveTokenDescriptorComparer Default = new DirectiveTokenDescriptorComparer();

        protected DirectiveTokenDescriptorComparer()
        {
        }

        public bool Equals(DirectiveTokenDescriptor descriptorX, DirectiveTokenDescriptor descriptorY)
        {
            if (descriptorX == descriptorY)
            {
                return true;
            }

            return descriptorX != null &&
                descriptorX.Kind == descriptorY.Kind &&
                descriptorX.Optional == descriptorY.Optional;
        }

        public int GetHashCode(DirectiveTokenDescriptor descriptor)
        {
            if (descriptor == null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }

            return HashCode.Combine(descriptor.Kind, descriptor.Optional ? 1 : 0);
        }
    }
}
