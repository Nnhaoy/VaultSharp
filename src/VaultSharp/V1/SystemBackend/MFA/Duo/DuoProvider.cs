﻿using VaultSharp.Core;
using VaultSharp.V1.Commons;

namespace VaultSharp.V1.SystemBackend.MFA.Duo
{
    internal class DuoProvider : MFAProviderBase<DuoConfig>, IDuo
    {
        public DuoProvider(Polymath polymath) : base(polymath)
        {
        }

        public override string Type => "duo";
    }
}