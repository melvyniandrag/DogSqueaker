using DogSqueaker.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DogSqueaker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			this.Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Button {
						Text = "Play *.wav file!",
						Command = new Command(() =>
							{
								DependencyService.Get<IAudio>().PlayWavFile(
									"ding_persevy.wav"
								);
							})
					},
					new Button {
						Text = "Play *.mp3 file!",
						Command = new Command(() =>
							{
								DependencyService.Get<IAudio>().PlayMp3File(
									"test.mp3"
								);
							})
						}
				}
			};
		}
    }
}
