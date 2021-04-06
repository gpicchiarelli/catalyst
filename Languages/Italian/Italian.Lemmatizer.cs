
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class Italian
    {
        internal sealed class Lemmatizer : ILemmatizer
        {
            public Language Language => Language.Italian;

            public string GetLemma(IToken token)
            {
                return token.Value;
            }

            public ReadOnlySpan<char> GetLemmaAsSpan(IToken token)
            {
                return token.ValueAsSpan;
            }

            public bool IsBaseForm(IToken token)
            {
                return false;
            }
        }
    }
}