using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App
{
    [Activity(Label = "App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //UI
        private LinearLayout _linearLayout;
        private TextView _textViewLabel;

        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        private void InitUI()
        {
            _linearLayout = new LinearLayout(this);
            _linearLayout.Orientation = Orientation.Vertical;

            _textViewLabel = new TextView(this);
            _textViewLabel.Text = Resource.Id.;

            var aButton = new Button(this);
            aButton.Text = "Say Hello!";

            aButton.Click += (sender, e) =>
            { aLabel.Text = "Hello Android!"; };

            layout.AddView(aLabel);
            layout.AddView(aButton);
            SetContentView(layout);
        }
    }
}
