﻿/*   
 *   * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.  
 *   * See LICENSE in the project root for license information.  
 */

using System;

namespace ContosoO365DocSync.Entity
{
    public class PublishSourcePointForm
    {
        public Guid SourcePointId { get; set; }

        public string CurrentValue { get; set; }

        public string Position { get; set; }

        public string Name { get; set; }

        public string NamePosition { get; set; }
    }
}