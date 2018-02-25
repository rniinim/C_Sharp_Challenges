using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Text;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android;
using Android.Text.Style;
using Android.Graphics;

namespace C_Sharp_Challenges
{
    [Activity(Label = "Challenge")]
    public class ChallengeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //int red, green, blue, start, end;
            
            // Create your application here
            SetContentView(Resource.Layout.Challenge);
            TextView challengeChallengeText = FindViewById<TextView>(Resource.Id.challengeChallengeText);
            TextView challengeSolutionText = FindViewById<TextView>(Resource.Id.challengeSolutionText);
            var btnShowSolution = FindViewById<Button>(Resource.Id.solutionBtn);
            var btnShowHint = FindViewById<Button>(Resource.Id.hintBtn);
            var challengeSolutionVar = FindViewById<TextView>(Resource.Id.challengeSolutionText);

            string dataNotAvaible = "Data not avaible";
            string otsikko = Intent.GetStringExtra("Otsikko") ?? dataNotAvaible;
            string challenge = Intent.GetStringExtra("Challenge") ?? dataNotAvaible;
            string solution = Intent.GetStringExtra("Solution") ?? dataNotAvaible;
            string hint = Intent.GetStringExtra("Hint") ?? dataNotAvaible;
            

            //challengeOtsikkoText.Text = otsikko;
            challengeChallengeText.Text = challenge;
            //challengeSolutionText.Text = solution;
            
            this.Title = otsikko;

            var span = new SpannableString(solution);
            ColorString(solution, span);
            
        
            
        

            challengeSolutionVar.SetText(span, TextView.BufferType.Spannable);

            btnShowSolution.Click += (e, o) =>
            {
                challengeSolutionText.Visibility = ViewStates.Visible;
            }; //Solution button click event

            btnShowHint.Click += (e, o) =>
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Hint");
                alert.SetMessage(hint);
                alert.SetNegativeButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                Dialog dialog = alert.Create();
                dialog.Show();
            }; //Hint button Click event
        }

        public static void ColorString(string solution, SpannableString span)
        {
            for (int i = 0; i < solution.Length; i++)
            {
                if (i < solution.Length - 10)
                {
                    if (solution.Substring(i, 2) == "/*")
                    {
                        int endValue = 0;
                        int j = i;
                        while (true)
                        {
                            if (solution.Substring(j++, 2) == "*/")
                            {
                                endValue = ++j;
                                break;
                            }
                        }
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(0, 102, 0)), i, endValue, 0); //comment
                        i = endValue;
                    }

                    else if (solution[i] == '"')
                    {
                        int endValue = 0;
                        int j = i + 1;
                        while (true)
                        {
                            if (solution[j++] == '"')
                            {
                                endValue = j;
                                break;
                            }
                        }
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(233, 150, 122)), i, endValue, 0); //string
                        i = endValue;
                    }
                    else if (solution.Substring(i, 2) == "if")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 2, 0); //type

                    }
                    else if (solution.Substring(i, 4) == "else")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 4, 0); //type
                    }
                    else if (solution.Substring(i, 3) == "for")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 3, 0); //type
                    }
                    else if (solution.Substring(i, 5) == "while")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 5, 0); //type
                    }
                    else if (solution.Substring(i, 7) == "Console")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(0, 180, 128)), i, i + 7, 0); //Class
                    }
                    else if (solution.Substring(i, 6) == "Random")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(0, 180, 128)), i, i + 6, 0); //Class
                    }
                    else if (solution.Substring(i, 6) == "string")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 6, 0); //type
                    }
                    else if (solution.Substring(i, 3) == "int")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 3, 0); //type
                    }
                    else if (solution.Substring(i, 6) == "double")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 6, 0); //type
                    }
                    else if (solution.Substring(i, 4) == "bool")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 4, 0); //type
                    }
                    else if (solution.Substring(i, 4) == "Math")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(0, 180, 128)), i, i + 4, 0); //Class
                    }
                    else if (solution.Substring(i, 7) == "Convert")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(0, 180, 128)), i, i + 7, 0); //Class
                    }
                    else if (solution.Substring(i, 3) == "new")
                    {
                        span.SetSpan(new ForegroundColorSpan(Color.Rgb(100, 149, 237)), i, i + 3, 0); //type
                    }
                }
            }
        }
    }
}