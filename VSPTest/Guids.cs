// Guids.cs
// MUST match guids.h
using System;

namespace EjaadTech.VSPTest
{
    static class GuidList
    {
        public const string guidVSPTestPkgString = "054dc7ee-76bb-4907-8192-1baf41a4802d";
        public const string guidVSPTestCmdSetString = "a26a6b1e-9e6f-4c58-8fef-fa8a7d067727";
        public const string guidToolWindowPersistanceString = "11265f0e-17c1-423c-a87d-7106f5552e7e";

        public static readonly Guid guidVSPTestCmdSet = new Guid(guidVSPTestCmdSetString);
    };
}