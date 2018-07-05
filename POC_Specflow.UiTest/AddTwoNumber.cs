using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace POC_Specflow.UiTest
{

    public static class Global
    {
        public static Platform Platform { get; set; }
        public static IApp App { get; set; }
    }
    //[TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    partial class AddTwoNumber 
    {
        public AddTwoNumber(Platform platform)
        {
            Global.App = AppInitializer.StartApp(platform);
        }
    }
}
