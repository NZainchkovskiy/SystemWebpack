﻿// ******************************************************************************
//  © 2018 Sebastiaan Dammann | damsteen.nl
// 
//      Some code is Copyright Microsoft and licensed under the  MIT license.
//      See: https://github.com/aspnet/JavaScriptServices
// 
//  File:           : WebAppAbstractions.cs
//  Project         : SystemWebpack
// ******************************************************************************
namespace SystemWebpack.Core.Abstractions {
    using System;

    internal static class WebAppAbstractions {
        private static readonly ServiceProviderImpl ServiceProvider;

        static WebAppAbstractions() {
            ServiceProvider = new ServiceProviderImpl();
            ServiceProvider.RegisterService(typeof(IHostingEnvironment), new HostingEnvironmentWrapper());
            ServiceProvider.RegisterService(typeof(IApplicationLifetime), new ApplicationLifetimeImpl());
            ServiceProvider.RegisterService(typeof(ILoggerFactory), new LoggerFactoryImpl());
        }

        public static IServiceProvider ApplicationServices => ServiceProvider;
    }
}