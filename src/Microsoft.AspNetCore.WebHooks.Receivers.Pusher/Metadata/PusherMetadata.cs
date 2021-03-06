// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.WebHooks.Metadata
{
    /// <summary>
    /// An <see cref="IWebHookMetadata"/> service containing metadata about the Pusher receiver.
    /// </summary>
    public class PusherMetadata : WebHookMetadata, IWebHookEventFromBodyMetadata
    {
        /// <summary>
        /// Instantiates a new <see cref="PusherMetadata"/> instance.
        /// </summary>
        public PusherMetadata()
            : base(PusherConstants.ReceiverName)
        {
        }

        // IWebHookBodyTypeMetadataService...

        /// <inheritdoc />
        public override WebHookBodyType BodyType => WebHookBodyType.Json;

        // IWebHookEvenFromBodytMetadata...

        /// <inheritdoc />
        public bool AllowMissing => true;

        /// <inheritdoc />
        public string BodyPropertyPath => PusherConstants.EventBodyPropertyPath;
    }
}
