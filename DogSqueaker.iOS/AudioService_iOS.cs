using AVFoundation;
using DogSqueaker.Interfaces;
using Foundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(DogSqueaker.iOS.AudioService_iOS))]
namespace DogSqueaker.iOS
{
    public class AudioService_iOS : IAudio
    {
        private AVAudioPlayer audioPlayer;

        public AudioService_iOS() { }

        private bool Play(string fileName, string fileTypeHint)
        {
            var filePath = NSBundle.MainBundle.PathForResource(Path.GetFileNameWithoutExtension(fileName),
                                                               Path.GetExtension(fileName));
            Debug.Assert(!string.IsNullOrEmpty(filePath));
            var url = NSUrl.FromString(filePath);

            NSError outError;
            NSUrl fileURL = new NSUrl(fileName);
            audioPlayer = new AVAudioPlayer(url: fileURL, fileTypeHint: fileTypeHint, outError: out outError);
            audioPlayer.FinishedPlaying += (object sender, AVStatusEventArgs e) => audioPlayer = null;
            audioPlayer.Play();

            return null == outError;
        }

        #region IAudio
        public bool PlayMp3File(string fileName)
        {
            Debug.WriteLine($"PlayMp3File(string {fileName})");
            return Play(fileName, AVFileType.MpegLayer3);
        }

        public bool PlayWavFile(string fileName)
        {
            Debug.WriteLine($"PlayWavFile(string {fileName})");
            return Play(fileName, AVFileType.Wave);
        }
        #endregion IAudio
    }
}
