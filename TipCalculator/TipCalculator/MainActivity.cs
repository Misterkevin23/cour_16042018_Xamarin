using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
	
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

            double bill;
        

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);


			// Get our button from the layout resource,
			// and attach an event to it

			Button button = FindViewById<Button>(Resource.Id.button1);
            EditText input = FindViewById<EditText>(Resource.Id.editTextTips);
            TextView tips = FindViewById<TextView>(Resource.Id.textViewTips);
            TextView total = FindViewById<TextView>(Resource.Id.textViewTotal);
              
            button.Click += delegate
            {
                if (Double.TryParse(input.Text, out bill))
                {
                    Double calcul = (Double.Parse(input.Text) * 0.15) + Double.Parse(input.Text);

                    total.Text = calcul.ToString();
                }
            };
            
		}
	}
}