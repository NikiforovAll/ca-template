// Copyright (c) Oleksii Nikiforov, 2021. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

namespace NikiforovAll.CA.Template.Worker.Contracts;

public interface IMarkToDoItemComplete
{
    public Guid ProjectId { get; set; }

    public int ItemId { get; set; }
}
