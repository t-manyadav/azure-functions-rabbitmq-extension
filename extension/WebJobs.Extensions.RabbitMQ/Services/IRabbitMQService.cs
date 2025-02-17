﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using RabbitMQ.Client;

namespace Microsoft.Azure.WebJobs.Extensions.RabbitMQ
{
    public interface IRabbitMQService
    {
        IRabbitMQModel RabbitMQModel { get; }

        IModel Model { get; }

        IBasicPublishBatch BasicPublishBatch { get; }

        object PublishBatchLock { get; }

        void ResetPublishBatch();
    }
}
