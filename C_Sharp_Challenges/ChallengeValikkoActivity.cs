
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.IO;

namespace C_Sharp_Challenges
{
    [Activity(Label = "Challenge Menu")]
    public class ChallengeValikkoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            string txtPathSolution, txtPathChallenge, otsikko, hint;
            //string txtPath;
            SetContentView(Resource.Layout.ChallengeValikko);


            #region VarButtons
            var btn01 = FindViewById<Button>(Resource.Id.btn01); //ask name
            var btn11 = FindViewById<Button>(Resource.Id.btn11); //Print numbers
            var btn21 = FindViewById<Button>(Resource.Id.btn21); //Addition
            var btn02 = FindViewById<Button>(Resource.Id.btn02); // Even Or Odd
            var btn12 = FindViewById<Button>(Resource.Id.btn12); // Letters Of Word
            var btn22 = FindViewById<Button>(Resource.Id.btn22); // print numbers PLACEHOLDER
            var btn03 = FindViewById<Button>(Resource.Id.btn03); //Head Or Tails
            var btn13 = FindViewById<Button>(Resource.Id.btn13);
            var btn23 = FindViewById<Button>(Resource.Id.btn23);
            var btn04 = FindViewById<Button>(Resource.Id.btn04);
            var btn14 = FindViewById<Button>(Resource.Id.btn14);
            var btn24 = FindViewById<Button>(Resource.Id.btn24);
            var btn05 = FindViewById<Button>(Resource.Id.btn05);
            var btn15 = FindViewById<Button>(Resource.Id.btn15);
            var btn25 = FindViewById<Button>(Resource.Id.btn25);
            var btn06 = FindViewById<Button>(Resource.Id.btn06);
            var btn16 = FindViewById<Button>(Resource.Id.btn16);
            var btn26 = FindViewById<Button>(Resource.Id.btn26);
            #endregion

        
            #region Button.Click
            //btn_Column_Row
            btn01.Click += (s, e) =>
            {
                ActivityStarter("AskName.txt", "AskNameInfo.txt", "Ask Name - Greet Name", "Use methods Console.WriteLine() and Console.ReadLine() for printing and getting value");
            };

            btn11.Click += (s, e) =>
            {
                ActivityStarter("PrintNumbers.txt", "PrintNumbersInfo.txt", "Print Numbers", "Use for loop to loop 100 times");
            };

            btn21.Click += (s, e) =>
            {
                ActivityStarter("Addition.txt", "AdditionInfo.txt", "Addition", "Use int.Parse() or Convert.toInt32() method to get value from user");
            };

            btn02.Click += (s, e) =>
            {
                ActivityStarter("EvenOrOdd.txt", "EvenOrOddInfo.txt", "Even Or Odd", "Use % operator to sort out whether number is even or odd");
            };
            btn12.Click += (s, e) =>
            {
                ActivityStarter("LettersOfWord.txt", "LettersOfWordInfo.txt", "Letters Of Word", "Use String.Substring() method");
            };
            btn22.Click += (s, e) => //btn_Column_Row
            {
                ActivityStarter("PrintOddNumbers.txt", "PrintOddNumbersInfo.txt", "Print Odd Numbers", "Use operators % and !=");
            };
            btn03.Click += (s, e) =>
            {
                hint = "Use for loop and method Next() from Random Class";
                txtPathChallenge = "HeadOrTailsInfo.txt";
                txtPathSolution = "HeadOrTails.txt";
                otsikko = "Head Or Tails";


                ActivityStarter(txtPathSolution, txtPathChallenge, otsikko, hint);
            };
            btn13.Click += (s, e) =>
            {
                ActivityStarter("NumberPasswordGenerator.txt", "NumberPasswordGeneratorInfo.txt", "Number Password Generator", "Use method Next() from Random class and for loop");
            };
            btn23.Click += (s, e) =>
            {
                ActivityStarter("YearsInSeconds.txt", "YearsInSecondsInfo.txt", "Years In Seconds", "There is 365.25 days in year, 24 hours in day, 3600 seconds in hour");
            };
            btn04.Click += (s, e) =>
            {
                ActivityStarter("TemperatureConverter.txt", "TemperatureConverterInfo.txt", "Converter From Celsius To Farenheit", "Use while loop and TryParse() method. Use formula: °C * 9/5 + 32 = °F");
            };
            btn14.Click += (s, e) => //btn_Column_Row
            {
                ActivityStarter("RussianRoulette.txt", "RussianRouletteInfo.txt", "Russian Roulette Game", "Use while loop with if else and Next() method from Random Class");
            };
            btn24.Click += (s, e) =>
            {
                ActivityStarter("SimpleCalculator.txt", "SimpleCalculatorInfo.txt", "Simple Calculator", "Use if else or switch structure. Use store operation in char or in string");
            };
            btn05.Click += (s, e) =>
            {
                ActivityStarter("MultiplicationTable.txt", "MultiplicationTableInfo.txt", "Multiplication Table From 1 to 10", "Use for loop in for loop");
            };
            btn15.Click += (s, e) =>
            {
                ActivityStarter("PasswordGenerator.txt", "PasswordGeneratorInfo.txt", "Password Generator", "Store all letters and numbers in string");
            };
            btn25.Click += (s, e) =>
            {
                ActivityStarter("RockPaperScissors.txt", "RockPaperScissorsInfo.txt", "Rock - Paper - Scissors", "Use if else or switch or ?: structures");
            };
            btn06.Click += (s, e) => //btn_Column_Row
            {
                ActivityStarter("ReverseWord.txt", "ReverseWordInfo.txt", "Reverse Word", "Make new string and store reversed word in it, aslo use word[i] in loop");
            };
            btn16.Click += (s, e) =>
            {
                ActivityStarter("DecimalToBinary.txt", "DecimalToBinaryInfo.txt", "Decimal To Binary", "Use % operator with 2 in loop to get remainder");
            };
            btn26.Click += (s, e) =>
            {
                ActivityStarter("VolumeOfSphere.txt", "VolumeOfSphereInfo.txt", "Volume Of Sphere", "V = (4/3)* π * r^3");
            }; 
            #endregion


        }

        private void ActivityStarter(string txtPathSolution, string txtPathChallenge, string otsikko, string hint)
        {
            string content;
            Intent nextActivity = new Intent(this, typeof(ChallengeActivity));

            nextActivity.PutExtra("Otsikko", otsikko);

            content = TxtToString(txtPathChallenge);
            nextActivity.PutExtra("Challenge", content);


            content = TxtToString(txtPathSolution);
            nextActivity.PutExtra("Solution", content);

            nextActivity.PutExtra("Hint", hint);
            StartActivity(nextActivity);
        }

        private string TxtToString(string txtPath)
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