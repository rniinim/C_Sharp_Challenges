using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.IO;

namespace C_Sharp_Challenges
{
    [Activity(Label = "C# Challenges", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var btnChallenges = FindViewById<Button>(Resource.Id.challengesBtn);
            var btnAboutC = FindViewById<Button>(Resource.Id.aboutcBtn);
            var btnHelp = FindViewById<Button>(Resource.Id.helpBtn);
            var btnAboutChallenges = FindViewById<Button>(Resource.Id.aboutChallengesBtn);

            btnChallenges.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(ChallengeValikkoActivity));
                StartActivity(nextActivity);
            };

            btnHelp.Click += (s, e) =>
            {
                ActivityStarter("NeedHelpChannel1.txt","NeedHelpChannel2.txt","NeedHelpChannel3.txt","NeedHelpContact.txt","NeedHelpLinks1.txt", "NeedHelpLinks1_1.txt", "NeedHelpLinks2.txt", "NeedHelpLinks2_1.txt", "NeedHelpLinks2_2.txt", "NeedHelpTitle1.txt","NeedHelpTitle2.txt", "NeedHelpYtTitle.txt","NeedHelpPlaylist1.txt","NeedHelpPlaylist2.txt","NeedHelpPlaylist3.txt");
            };

            btnAboutChallenges.Click += (s, e) =>
            {
                string content;
                Intent nextActivity = new Intent(this, typeof(AboutChallengesActivity));
                content = TxtToString("CSChallenges.txt");
                nextActivity.PutExtra("Otsikko", content);

                content = TxtToString("CSChallengesChangelog.txt");
                nextActivity.PutExtra("Changelog", content);
                StartActivity(nextActivity);
            };

            btnAboutC.Click += (s, e) =>
            {
                string content;
                Intent nextActivity = new Intent(this, typeof(AboutCSActivity));
                content = TxtToString("AboutCSharp.txt");
                nextActivity.PutExtra("Content", content);

                content = TxtToString("AboutCSharpLink.txt");
                nextActivity.PutExtra("Link", content);
                StartActivity(nextActivity);
            };

            void ActivityStarter(string txtPathChannel1, string txtPathChannel2, string txtPathChannel3, string txtPathContact, string txtPathLinks1,string txtPathLinks1_1 ,string txtPathLinks2, string txtPathLinks2_1, string txtPathLinks2_2, string txtPathTitle1, string txtPathTitle2, string txtPathYtTitle, string txtPathPlaylist1, string txtPathPlaylist2, string txtPathPlaylist3)
            {
                string content;
                Intent nextActivity = new Intent(this, typeof(HelpActivity));
                
                content = TxtToString(txtPathChannel1);
                nextActivity.PutExtra("Channel1", content);

                content = TxtToString(txtPathChannel2);
                nextActivity.PutExtra("Channel2", content);

                content = TxtToString(txtPathChannel3);
                nextActivity.PutExtra("Channel3", content);

                content = TxtToString(txtPathContact);
                nextActivity.PutExtra("Contact", content);

                content = TxtToString(txtPathLinks1);
                nextActivity.PutExtra("Links1", content);

                content = TxtToString(txtPathLinks1_1);
                nextActivity.PutExtra("Links1_1", content);

                content = TxtToString(txtPathLinks2);
                nextActivity.PutExtra("Links2", content);

                content = TxtToString(txtPathLinks2_1);
                nextActivity.PutExtra("Links2_1", content);

                content = TxtToString(txtPathLinks2_2);
                nextActivity.PutExtra("Links2_2", content);

                content = TxtToString(txtPathTitle1);
                nextActivity.PutExtra("Title1", content);

                content = TxtToString(txtPathTitle2);
                nextActivity.PutExtra("Title2", content);

                content = TxtToString(txtPathYtTitle);
                nextActivity.PutExtra("YtTitle", content);

                content = TxtToString(txtPathPlaylist1);
                nextActivity.PutExtra("Playlist1", content);

                content = TxtToString(txtPathPlaylist2);
                nextActivity.PutExtra("Playlist2", content);

                content = TxtToString(txtPathPlaylist3);
                nextActivity.PutExtra("Playlist3", content);

                StartActivity(nextActivity);
            }

            string TxtToString(string txtPath)
            {
                string content;
                using (StreamReader sr = new StreamReader(Assets.Open(txtPath)))
                {
                    content = sr.ReadToEnd();
                }

                return content;
            }
        }
    }
}

