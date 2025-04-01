using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyGH1Plugin
{
    public class MyGH1PluginInfo : GH_AssemblyInfo
    {
        public override string Name => "MyGH1Plugin";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("F47B3F52-52D9-4737-AAF6-11ACFDE5F889");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}