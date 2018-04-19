﻿using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
	[Activity(Label = "About")]			
	public class AboutActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.About);

			FindViewById<Button>(Resource.Id.learnMoreButton).Click += OnLearnMoreClick;
		}

		void OnLearnMoreClick(object sender, EventArgs e)
		{
            var items = new Intent();
            items.SetAction(Intent.ActionView);
            items.SetData(Android.Net.Uri.Parse("http://www.google.com"));
            StartActivity(items);
        }
	}
}