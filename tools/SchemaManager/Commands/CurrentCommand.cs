﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Rendering;
using System.CommandLine.Rendering.Views;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Microsoft.Health.SqlServer.Features.Schema.Manager.Model;
using SchemaManager.Core;

namespace SchemaManager.Commands
{
    public class CurrentCommand : Command
    {
        private readonly ISchemaManager _schemaManager;

        public CurrentCommand(ISchemaManager schemaManager)
            : base(CommandNames.Current, Resources.CurrentCommandDescription)
        {
            AddOption(CommandOptions.ServerOption());
            AddOption(CommandOptions.ConnectionStringOption());

            Handler = CommandHandler.Create(
                (InvocationContext context, Uri server, string connectionString, CancellationToken token)
                => HandlerAsync(context, connectionString, server, token));

            Argument.AddValidator(symbol => Validators.RequiredOptionValidator.Validate(symbol, CommandOptions.ConnectionStringOption(), Resources.ConnectionStringRequiredValidation));
            Argument.AddValidator(symbol => Validators.RequiredOptionValidator.Validate(symbol, CommandOptions.ServerOption(), Resources.ServerRequiredValidation));

            EnsureArg.IsNotNull(schemaManager, nameof(schemaManager));

            _schemaManager = schemaManager;
        }

        private async Task HandlerAsync(InvocationContext invocationContext, string connectionString, Uri server, CancellationToken cancellationToken = default)
        {
            var region = new Region(
                          0,
                          0,
                          Console.WindowWidth,
                          Console.WindowHeight,
                          true);

            var currentVersions = await _schemaManager.GetCurrentSchema(connectionString, server, cancellationToken);

            var tableView = new TableView<CurrentVersion>
            {
                Items = new ReadOnlyCollection<CurrentVersion>(currentVersions),
            };

            tableView.AddColumn(
               cellValue: currentVersion => currentVersion.Id,
               header: new ContentView("Version"));

            tableView.AddColumn(
                cellValue: currentVersion => currentVersion.Status,
                header: new ContentView("Status"));

            tableView.AddColumn(
                cellValue: currentVersion => string.Join(", ", currentVersion.Servers),
                header: new ContentView("Servers"));

            var consoleRenderer = new ConsoleRenderer(
                invocationContext.Console,
                mode: invocationContext.BindingContext.OutputMode(),
                resetAfterRender: true);

            using (var screen = new ScreenView(renderer: consoleRenderer))
            {
                screen.Child = tableView;
                screen.Render(region);
            }
        }
    }
}
