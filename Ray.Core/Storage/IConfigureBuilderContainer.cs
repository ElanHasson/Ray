﻿using System;
using System.Collections.Concurrent;

namespace Ray.Core.Storage
{
    public interface IConfigureBuilderContainer
    {
        bool TryGetValue(Type type, out BaseConfigureBuilderWrapper builderWrapper);
        void Register(Type type, BaseConfigureBuilderWrapper builder);
    }
}
