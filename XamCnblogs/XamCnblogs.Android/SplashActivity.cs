﻿
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;

namespace XamCnblogs.Droid
{
    [Activity(Label = "@string/AppName", Icon = "@drawable/ic_launcher", Theme = "@style/SplashTheme", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}