using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    public class App : Application
    {
        private static string _appTag;
        public static string Tag
        {
            get
            {
                return _appTag;
            }

            set
            {
                _appTag = value;
            }
        }
    }
}