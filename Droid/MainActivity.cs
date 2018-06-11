﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using FragmentComponent.Droid.Fragments;

namespace FragmentComponent.Droid
{
    [Activity(Label = "FragmentComponent", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, ICountButtonTapped
    {

        FirstFragment firstFragment;
        SecondFragment secondFragment;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            firstFragment = new FirstFragment();
            firstFragment.SetDelegate(this);
            secondFragment = new SecondFragment();


            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.firstFragment, firstFragment).Commit();
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.secondFragment, secondFragment).Commit();
        }

        public void OnCountButtonTapped()
        {
            secondFragment.CountButtonPressed();
        }



    }
}

