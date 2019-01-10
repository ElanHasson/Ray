﻿using System.Threading.Tasks;

namespace Ray.Core.Storage
{
    public interface IStorageConfiguration<C, P>
    {
        Task Configure(IConfigureBuilderContainer container);
    }
}
