using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace calculatore2
{
    [Activity(Label = "calculatore2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button total_btn;
        private Button defferenc_btn;
        private Button multiplacation_btn;
        private Button separation_btn;
        private Button equal_btn;
        private Button refresh_btn;
        private TextView textView;
        private EditText editText;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
       
            SetContentView(Resource.Layout.Main);
            total_btn = FindViewById<Button>(Resource.Id.total_btn);
            defferenc_btn = FindViewById<Button>(Resource.Id.defferenc_btn);
            multiplacation_btn = FindViewById<Button>(Resource.Id.multiplacation_btn);
            separation_btn = FindViewById<Button>(Resource.Id.separation_btn);
            equal_btn = FindViewById<Button>(Resource.Id.equal_btn);
            refresh_btn = FindViewById<Button>(Resource.Id.refresh_btn);
            textView = FindViewById<TextView>(Resource.Id.textView);
            editText = FindViewById<EditText>(Resource.Id.editText);


  
        }
    }
}

