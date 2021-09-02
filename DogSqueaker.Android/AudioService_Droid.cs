using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DogSqueaker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(DogSqueaker.Droid.AudioService_Droid))]
namespace DogSqueaker.Droid
{
    public class AudioService_Droid: IAudio
    {
		public AudioService_Droid() { }

		private MediaPlayer _mediaPlayer;

		public bool PlayMp3File(string fileName)
		{
			_mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.test);
			_mediaPlayer.Start();

			return true;
		}

		public bool PlayWavFile(string fileName)
		{
			_mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.ding_persevy);
			_mediaPlayer.Start();

			return true;
		}
	}
}