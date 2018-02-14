using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Android;

namespace C_Sharp_Challenges
{
    [Activity(Label = "About C#")]
    public class AboutCSActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AboutCSharp);

            TextView AboutTxt = FindViewById<TextView>(Resource.Id.aboutCStxt);
            TextView LinkTxt = FindViewById<TextView>(Resource.Id.aboutCSLinktxt);
            var linkvar = FindViewById<TextView>(Resource.Id.aboutCSLinktxt);
            string src;

            AboutTxt.Text = Intent.GetStringExtra("Content") ?? "Data not avaible";
            LinkTxt.Text = Intent.GetStringExtra("Link") ?? "Data not avaible";
            linkvar.SetTextColor(Color.Rgb(0, 0, 153));

            linkvar.Click += delegate
            {
                src = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework";
                StartLinkActivity(src);
            };
        }

        private void StartLinkActivity(string src)
        {
            var uri = Android.Net.Uri.Parse(src);
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

    }
}