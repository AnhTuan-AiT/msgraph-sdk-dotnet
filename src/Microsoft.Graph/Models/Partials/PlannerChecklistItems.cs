﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PlannerChecklistItems : IEnumerable<KeyValuePair<string, PlannerChecklistItem>>
    {
        public PlannerChecklistItem this[string checklistItemId]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(checklistItemId))
                {
                    throw new ArgumentNullException(nameof(checklistItemId));
                }

                if (!this.AdditionalData.TryGetValue(checklistItemId, out object checklistItemObject))
                {
                    return null;
                }

                return checklistItemObject as PlannerChecklistItem;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(checklistItemId))
                {
                    throw new ArgumentNullException(nameof(checklistItemId));
                }

                this.AdditionalData[checklistItemId] = value;
            }
        }

        public void AddReference(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            var plannerChecklistItem = new PlannerChecklistItem();

            plannerChecklistItem.Title = title;
            var newChecklistItemId = Guid.NewGuid().ToString();

            this.AdditionalData.Add(newChecklistItemId, plannerChecklistItem);
        }

        public IEnumerator<KeyValuePair<string, PlannerChecklistItem>> GetEnumerator()
        {
            return this.AdditionalData
                .Where(kvp => kvp.Value is PlannerChecklistItem)
                .Select(kvp => new KeyValuePair<string, PlannerChecklistItem>(kvp.Key, (PlannerChecklistItem)kvp.Value))
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
