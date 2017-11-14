﻿using System.Collections.Generic;
using Marvin.Runtime.ModuleManagement;

namespace Marvin.Runtime.Kernel
{
    internal class PluginDependencyTree : IModuleDependencyTree
    {
        public PluginDependencyTree(IEnumerable<IModuleDependency> roots)
        {
            RootModules = roots;
        }

        public IEnumerable<IModuleDependency> RootModules { get; private set; }
    }

    internal class PluginDependencyBranch : IModuleDependency
    {
        /// <summary>
        /// Plugin represented by this entry in the dependency tree
        /// </summary>
        public IServerModule RepresentedModule { get; set; }

        /// <summary>
        /// All modules this module depends on
        /// </summary>
        public IEnumerable<IModuleDependency> Dependencies { get; set; }

        /// <summary>
        /// All modules that depend on this module
        /// </summary>
        public IEnumerable<IModuleDependency> Dependends { get; set; }
    }
}

