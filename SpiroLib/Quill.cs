using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Spirograph
{
    public struct Quill
    {
        private double _radialPosition;
        private double _angularPosition;
        private Pen _pen;

        public double RadialPosition
        {
            get
            {
                return _radialPosition;
            }

            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Radial position must be between 0 and 100");
                _radialPosition = value;
            }
        }

        public double AngularPosition
        {
            get
            {
                return _angularPosition;
            }

            set
            {
                if (value < 0 || value > 360)
                    throw new ArgumentException("Angular position must be between 0 and 360");
                _angularPosition = value;
            }
        }

        public Pen Pen
        {
            get
            {
                return _pen;
            }

            set
            {
                _pen = value;
            }
        }

        public override string ToString()
        {
            return _angularPosition + " deg by " + _radialPosition + "% - " + _pen.Color.Name;
        }
    }
}
