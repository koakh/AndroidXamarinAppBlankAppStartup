using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace App
{
    [Activity(Label = "XamarinAppBlankAppStartup", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int _count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            try
            {
                //BootStrap
                InitApp();
                InitUI();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitApp()
        {
            App.Tag = ApplicationContext.Resources.GetString(Resource.String.ApplicationTag);
            Log.Info(App.Tag, "this is an info message");
        }

        private void InitUI()
        {
            //LinearLayout
            LinearLayout linearLayout = new LinearLayout(this)
            {
                Orientation = Orientation.Vertical
            };

            //TextView
            TextView textViewLabel;
            textViewLabel = new TextView(this);
            textViewLabel.Text = ApplicationContext.Resources.GetString(Resource.String.ApplicationName);

            //Button1
            Button button1 = new Button(this)
            {
                Text = ApplicationContext.Resources.GetString(Resource.String.button_label_1)
            };
            button1.Click += (sender, e) =>
            {
                textViewLabel.Text = string.Format("Counter: {0}", _count++);
                Log.Debug(App.Tag, "button1.Click");
            };

            //Button2
            Button button2 = new Button(this)
            {
                Text = ApplicationContext.Resources.GetString(Resource.String.button_label_2)
            };
            button2.Click += (sender, e) =>
            {
                textViewLabel.Text = string.Format("Counter: {0}", _count--);
                Log.Debug(App.Tag, "button2.Click");
            };

            //Add View to linearLayout
            linearLayout.AddView(textViewLabel);
            linearLayout.AddView(button1);
            linearLayout.AddView(button2);
            //Add Content View
            SetContentView(linearLayout);
        }
    }
}
