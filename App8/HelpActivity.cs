using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;

namespace C_Sharp_Challenges
{
    [Activity(Label = "Need help?")]
    public class HelpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.NeedHelp);
            string title1,title2,ytTitle,channel1,channel2,channel3,playlist1,playlist2,playlist3,contact,links1,links1_1,links2,links2_1,links2_2, src;
            ClipboardManager clipboard = (ClipboardManager)GetSystemService(Context.ClipboardService);

            #region TextView
            TextView title1txt = FindViewById<TextView>(Resource.Id.HelpTxtTitle1);
            TextView title2txt = FindViewById<TextView>(Resource.Id.HelpTxtTitle2);
            TextView ytTitletxt = FindViewById<TextView>(Resource.Id.HelpTxtYtTitle);
            TextView channel1txt = FindViewById<TextView>(Resource.Id.HelpTxtChannel1);
            TextView channel2txt = FindViewById<TextView>(Resource.Id.HelpTxtChannel2);
            TextView channel3txt = FindViewById<TextView>(Resource.Id.HelpTxtChannel3);
            TextView playlis1txt = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist1);
            TextView playlist2txt = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist2);
            TextView playlist3txt = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist3);
            TextView contacttxt = FindViewById<TextView>(Resource.Id.HelpTxtContact);
            TextView links1txt = FindViewById<TextView>(Resource.Id.HelpTxtLinks1);
            TextView links1_1txt = FindViewById<TextView>(Resource.Id.HelpTxtLinks1_1);
            TextView links2txt = FindViewById<TextView>(Resource.Id.HelpTxtLinks2);
            TextView links2txt_1 = FindViewById<TextView>(Resource.Id.HelpTxtLinks2_1);
            TextView links2txt_2 = FindViewById<TextView>(Resource.Id.HelpTxtLinks2_2);
            #endregion

            #region Vartxt
            var links1C = FindViewById<TextView>(Resource.Id.HelpTxtLinks1);
            var links1_1C = FindViewById<TextView>(Resource.Id.HelpTxtLinks1_1);
            var links2C = FindViewById<TextView>(Resource.Id.HelpTxtLinks2);
            var links2_1C = FindViewById<TextView>(Resource.Id.HelpTxtLinks2_1);
            var links2_2C = FindViewById<TextView>(Resource.Id.HelpTxtLinks2_2);
            var playlist1C = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist1);
            var playlist2C = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist2);
            var playlist3C = FindViewById<TextView>(Resource.Id.HelpTxtPlaylist3);
            #endregion

            links1C.SetTextColor(Color.Rgb(0, 0, 153));
            links1_1C.SetTextColor(Color.Rgb(0,0,153));
            links2C.SetTextColor(Color.Rgb(0, 0, 153));
            links2_1C.SetTextColor(Color.Rgb(0, 0, 153));
            links2_2C.SetTextColor(Color.Rgb(0, 0, 153));
            playlist1C.SetTextColor(Color.Rgb(0, 0, 153));
            playlist2C.SetTextColor(Color.Rgb(0, 0, 153));
            playlist3C.SetTextColor(Color.Rgb(0, 0, 153));

            #region GetStringExtra
            string dataNotAvaible = "Data not avaible";
            title1 = Intent.GetStringExtra("Title1") ?? dataNotAvaible;
            title2 = Intent.GetStringExtra("Title2") ?? dataNotAvaible;
            ytTitle = Intent.GetStringExtra("YtTitle") ?? dataNotAvaible;
            channel1 = Intent.GetStringExtra("Channel1") ?? dataNotAvaible;
            channel2 = Intent.GetStringExtra("Channel2") ?? dataNotAvaible;
            channel3 = Intent.GetStringExtra("Channel3") ?? dataNotAvaible;
            links1 = Intent.GetStringExtra("Links1") ?? dataNotAvaible;
            links1_1 = Intent.GetStringExtra("Links1_1") ?? dataNotAvaible;
            links2 = Intent.GetStringExtra("Links2") ?? dataNotAvaible;
            links2_1 = Intent.GetStringExtra("Links2_1") ?? dataNotAvaible;
            links2_2 = Intent.GetStringExtra("Links2_2") ?? dataNotAvaible;
            playlist1 = Intent.GetStringExtra("Playlist1") ?? dataNotAvaible;
            playlist2 = Intent.GetStringExtra("Playlist2") ?? dataNotAvaible;
            playlist3 = Intent.GetStringExtra("Playlist3") ?? dataNotAvaible;
            contact = Intent.GetStringExtra("Contact") ?? dataNotAvaible;
            #endregion


            #region .Text
            title1txt.Text = title1;
            title2txt.Text = title2;
            ytTitletxt.Text = ytTitle;
            channel1txt.Text = channel1;
            channel2txt.Text = channel2;
            channel3txt.Text = channel3;
            playlis1txt.Text = playlist1;
            playlist2txt.Text = playlist2;
            playlist3txt.Text = playlist3;
            contacttxt.Text = contact;
            links1txt.Text = links1;
            links1_1txt.Text = links1_1;
            links2txt.Text = links2;
            links2txt_1.Text = links2_1;
            links2txt_2.Text = links2_2;
            #endregion


            #region .Click
            links1C.Click += delegate
                {
                    src = "https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio";
                    StartLinkActivity(src);
                };

            links1_1C.Click += delegate
            {
                src = "https://www.youtube.com/watch?v=IwxkVL5DGg8";
                StartLinkActivity(src);
            };
            links2C.Click += delegate
            {
                src = "https://mva.microsoft.com/en-us/training-courses/c-fundamentals-for-absolute-beginners-16169?l=Lvld4EQIC_2706218949";
                StartLinkActivity(src);
            };
            links2_1C.Click += delegate
            {
                src = "http://www.learncs.org/";
                StartLinkActivity(src);
            };
            links2_2C.Click += delegate
            {
                src = "https://www.microsoft.com/net/tutorials/csharp/getting-started";
                StartLinkActivity(src);
            };
            playlist1C.Click += delegate
            {
                src = "https://www.youtube.com/watch?v=pSiIHe2uZ2w&list=PLPV2KyIb3jR6ZkG8gZwJYSjnXxmfPAl51";
                StartLinkActivity(src);
            };
            playlist2C.Click += delegate
            {
                src = "https://www.youtube.com/watch?v=x_9lfHjYtVg&list=PL0EE421AE8BCEBA4A";
                StartLinkActivity(src);
            };
            playlist3C.Click += delegate
            {
                src = "https://www.youtube.com/watch?v=Grss9Zqxdng&list=PLi2hbezQRVS2ZCv2kVjtQ7jWQIt4Pzjuc";
                StartLinkActivity(src);
            };
            #endregion

            links1C.LongClick += delegate
            {
                src = "https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio";
                clipboard.Text = src;
                Toast.MakeText(this, src+ "copied!",ToastLength.Long );
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