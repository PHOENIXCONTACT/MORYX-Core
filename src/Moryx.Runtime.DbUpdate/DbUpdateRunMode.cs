// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using Moryx.Model;
using Moryx.Runtime.Kernel;

namespace Moryx.Runtime.DbUpdate
{
    /// <summary>
    /// RunMode used to update all models
    /// </summary>
    [RunMode(typeof(DbUpdateOptions))]
    public class DbUpdateRunMode : RunModeBase<DbUpdateOptions>
    {
        public IDbContextFactory DbContextFactory { get; set; }

        /// <summary>
        /// Run environment
        /// </summary>
        /// <returns>0: All fine - 1: Warning - 2: Error</returns>
        public override RuntimeErrorCode Run()
        {
            Console.WriteLine("Updating databases...");
            foreach (var configurator in DbContextFactory.Configurators)
            {
                try
                {
                    var summary = configurator.MigrateDatabase(configurator.Config);
                    if (!summary.WasUpdated)
                    {
                        Console.WriteLine("No updates for {0}", configurator.TargetModel);
                        continue;
                    }

                    // Display update summary
                    Console.WriteLine("Update summary for {0}:", configurator.TargetModel);
                    foreach (var update in summary.ExecutedUpdates)
                    {
                        Console.WriteLine("{0}->{1}: {2}", update.From, update.To, update.Description);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Update for {0} failed with exception:\n  {1}", configurator.TargetModel, ex.Message);
                }
            }
            Console.WriteLine("Update complete");
            return RuntimeErrorCode.NoError;
        }
    }
}
