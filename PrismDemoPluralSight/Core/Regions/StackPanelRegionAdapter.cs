﻿using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PrismDemoPluralSight.Core.Regions
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(RegionBehaviorFactory behavioFactory) : base(behavioFactory)
        {

        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach(FrameworkElement item in e.NewItems)
                    {
                        regionTarget.Children.Add(item);
                    }
                }
                else if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    foreach(FrameworkElement item in e.OldItems)
                    {
                        regionTarget.Children.Remove(item);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new Region();
        }
    }
}
