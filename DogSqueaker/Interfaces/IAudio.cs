using System;
using System.Collections.Generic;
using System.Text;

namespace DogSqueaker.Interfaces
{
	public interface IAudio
	{
		bool PlayMp3File(string fileName);
		bool PlayWavFile(string fileName);
	}
}
