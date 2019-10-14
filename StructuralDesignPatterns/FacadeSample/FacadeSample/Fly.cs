using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class Fly
    {
        private Engine engine;
        private Radios radios;
        private Controls controls;

        public Fly()
        {
            engine = new Engine();
            radios = new Radios();
            controls = new Controls();
        }

        public void TakeOff()
        {
            engine.CheckEngine();
            radios.CheckRadios();
            controls.CheckControls();
        }
    }
}
