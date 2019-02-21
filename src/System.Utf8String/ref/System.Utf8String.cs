// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System
{
    public sealed partial class Utf8String
    {
        public static readonly Utf8String Empty;
        public Utf8String(ReadOnlySpan<byte> value) { }
        public Utf8String(ReadOnlySpan<char> value) { }
        public int Length => throw null;
        [ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)] // for compiler use only
        public ref readonly byte GetPinnableReference() => throw null;
    }
}
