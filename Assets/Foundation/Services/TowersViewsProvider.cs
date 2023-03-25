using System;
using System.Collections.Generic;
using Foundation.Services.Interfaces;

namespace Foundation.Services
{
    public class TowersViewsProvider : ITowersViewsProvider
    {
        private readonly Dictionary<int, string> _towerViewsResources;

        public TowersViewsProvider(Dictionary<int, string> towerViewsResources)
        {
            _towerViewsResources = towerViewsResources;
        }

        public string GetTowerViewResourceNameByIndex(int index)
        {
            if (!_towerViewsResources.TryGetValue(index, out var resourceName))
                throw new InvalidOperationException(
                    $"The tower resource with index: ({index}) is not exists in current context");
            
            return resourceName;
        }
    }
}