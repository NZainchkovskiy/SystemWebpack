﻿// ******************************************************************************
//  © 2018 Sebastiaan Dammann | damsteen.nl
// 
//      Some code is Copyright Microsoft and licensed under the  MIT license.
//      See: https://github.com/aspnet/JavaScriptServices
// 
//  File:           : WebpackOptionsValidationException.cs
//  Project         : SystemWebpack
// ******************************************************************************
namespace SystemWebpack {
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class WebpackOptionsValidationException : Exception {
        public WebpackOptionsValidationException(string message) : base(message) { }
        protected WebpackOptionsValidationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}