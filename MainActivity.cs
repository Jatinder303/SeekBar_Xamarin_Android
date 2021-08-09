using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Views;
using Android.Widget;
using System;
namespace SeekBar_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar skSeekBar;
        TextView txtValue;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Initialize controls 
            skSeekBar = FindViewById<SeekBar>(Resource.Id.skSeekBar);
            txtValue = FindViewById<TextView>(Resource.Id.txtValue);

            skSeekBar.ProgressChanged += OnSeekBarChange;
        }
        private void OnSeekBarChange(object sender, EventArgs e)
        {
            txtValue.Text = Convert.ToString(skSeekBar.Progress);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}