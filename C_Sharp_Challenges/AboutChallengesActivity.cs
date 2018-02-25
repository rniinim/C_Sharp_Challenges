using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace C_Sharp_Challenges
{
    [Activity(Label = "About C# Challenges")]
    public class AboutChallengesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AboutCSChallenges);

            TextView otsikko = FindViewById<TextView>(Resource.Id.CSCotsikko);
            TextView changelog = FindViewById<TextView>(Resource.Id.CSCchangelog);

            otsikko.Text = Intent.GetStringExtra("Otsikko") ?? "Data not avaible";
            changelog.Text = Intent.GetStringExtra("Changelog") ?? "Data not avaible";

        }
    }
}