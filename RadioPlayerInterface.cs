using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    public interface RadioPlayerInterface
    {
        void SwitcH(Boolean on);
        void retune(double frequency);
        void SetVolume(int Loudness);
        void changeChannel();
    }
}

