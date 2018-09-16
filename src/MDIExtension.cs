﻿using Unity.Extension;
using Unity.Microsoft.DependencyInjection.Policy;
using Unity.Policy;
using Unity.Policy.Lifetime;
using Unity.Storage;

namespace Unity.Microsoft.DependencyInjection
{
    internal class MdiExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Context.Policies.SetDefault<IConstructorSelectorPolicy>(new ConstructorSelectorPolicy());
        }

        public ILifetimeContainer Lifetime => Context.Lifetime;
    }
}
