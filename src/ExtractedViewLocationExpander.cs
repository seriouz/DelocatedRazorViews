using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DelocatedRazorViews
{
    public class ExtractedViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var tmpLocations = new List<string>();
            foreach (var viewLocation in viewLocations)
            {
                tmpLocations.Add($@"../extracted{viewLocation}");
            }
            viewLocations = viewLocations.Concat(tmpLocations);

            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}