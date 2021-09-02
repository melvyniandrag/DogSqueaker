using DogSqueaker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(DogSqueaker.UWP.AudioService_UWP))]
namespace DogSqueaker.UWP
{
    class AudioService_UWP : IAudio
    {
        public bool PlayMp3File(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool PlayWavFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
