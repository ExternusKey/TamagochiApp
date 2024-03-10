using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiApp
{
    public interface IAction
    {
        public void Feed();
        public void Play();
        public void Sleep();
        public void Work();
    }
}
