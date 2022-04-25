#if NET6_0_OR_GREATER

using System.Diagnostics;

namespace Aerospike.Client
{
    public class Tracing
    {
        public readonly static ActivitySource Source = new ActivitySource("Aerospike");
    }
}

#endif