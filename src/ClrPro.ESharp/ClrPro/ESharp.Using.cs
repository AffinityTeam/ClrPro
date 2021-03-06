// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System.Runtime.CompilerServices;
    using ClrPro.ESharpLang;
    using JetBrains.Annotations;

    /// <summary>
    ///     Emulation# (E#) - Upcoming C# language features polyfills and useful language extensions.
    /// </summary>
    /// <remarks>
    ///     Use this line to enable extensions in your code.
    ///     <code>using static ClrPro.ESharp;</code>
    /// </remarks>
    [PublicAPI]
    public static partial class ESharp
    {
        /// <summary>
        ///     Advanced using operator with supports <see cref="ICodeScopeExtension" />.
        /// </summary>
        /// <typeparam name="T">The type of the scope extension object.</typeparam>
        /// <param name="scopeExtension">The scope extension (handler of the code scope events).</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UsingExpression<T> Using<T>(T scopeExtension)
            where T : ICodeScopeExtension?
        {
            return new UsingExpression<T> { ScopeExtension = scopeExtension };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T">The type of the scope extension object.</typeparam>
        /// <param name="scopeExtension">The scope extension (handler of the code scope events).</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AsyncUsingExpression<T> UsingAsync<T>(T scopeExtension)
            where T : IAsyncCodeScopeExtension?
        {
            return new AsyncUsingExpression<T> { ScopeExtension = scopeExtension };
        }
    }
}
