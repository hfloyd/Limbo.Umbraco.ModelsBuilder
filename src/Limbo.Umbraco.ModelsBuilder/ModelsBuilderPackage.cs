﻿using Skybrud.Essentials.Reflection;
using System;
using Umbraco.Cms.Core.Semver;

namespace Limbo.Umbraco.ModelsBuilder {
    
    /// <summary>
    /// Static class with various information and constants about the package.
    /// </summary>
    public class ModelsBuilderPackage {

        /// <summary>
        /// Gets the alias of the package.
        /// </summary>
        public const string Alias = "Limbo.Umbraco.ModelsBuilder";

        /// <summary>
        /// Gets the friendly name of the package.
        /// </summary>
        public const string Name = "Limbo Models Builder";

        /// <summary>
        /// Gets the version of the package.
        /// </summary>
        public static readonly Version Version = typeof(ModelsBuilderPackage).Assembly.GetName().Version;

        /// <summary>
        /// Gets the semantic version of the package.
        /// </summary>
        public static readonly SemVersion SemVersion = SemVersion.Parse(ReflectionUtils.GetInformationalVersion<ModelsBuilderPackage>());

    }

}