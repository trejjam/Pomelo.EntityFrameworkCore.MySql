// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Pomelo.EntityFrameworkCore.MySql.Json.Microsoft.Scaffolding.Internal;
using Pomelo.EntityFrameworkCore.MySql.Json.Microsoft.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Json.Microsoft.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Json.Microsoft.Infrastructure.Internal;

namespace Pomelo.EntityFrameworkCore.MySql.Json.Microsoft.Design.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public class MySqlJsonMicrosoftDesignTimeServices : IDesignTimeServices
    {
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
            => serviceCollection
                .AddSingleton<IMysqlJsonOptions, DefaultMysqlJsonOptions>()
                .AddSingleton<IRelationalTypeMappingSourcePlugin, MySqlJsonMicrosoftTypeMappingSourcePlugin>()
                .AddSingleton<IProviderCodeGeneratorPlugin, MySqlJsonMicrosoftCodeGeneratorPlugin>();
    }
}
