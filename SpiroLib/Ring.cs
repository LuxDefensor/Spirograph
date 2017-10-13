using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Spirograph
{
    public enum Edges
    {
        Inner,
        Outer
    }

    public class Ring
    {
        private int _innerRadius;
        private int _outerRadius;
        private List<Quill> _quills;
        private Edges _touch = Edges.Outer;

        public Ring(int innerRadius, int outerRadius)
        {
            if (innerRadius > outerRadius || innerRadius < 0)
                throw new ArgumentException("Inner radius must be less than outer radius");
            _innerRadius = innerRadius;
            _outerRadius = outerRadius;
            _quills = new List<Quill>();
        }

        #region Properties

        public int InnerRadius
        {
            get
            {
                return _innerRadius;
            }
        }

        public int OuterRadius
        {
            get
            {
                return _outerRadius;
            }
        }

        public List<Quill> Quills
        {
            get
            {
                return _quills;
            }
        }

        public Edges Touch
        {
            get
            {
                return _touch;
            }

            set
            {
                _touch = value;
            }
        }
        #endregion

        public void EditRing(int newInnerRadius, int newOuterRadius)
        {
            if (newInnerRadius > newOuterRadius || newInnerRadius < 0)
                throw new ArgumentException("Inner radius must be less than outer radius");
            _innerRadius = newInnerRadius;
            _outerRadius = newOuterRadius;
        }

        public void AddQuill(double angle, double shift,Pen pen)
        {
            Quill quill = new Quill();
            quill.AngularPosition = angle;
            quill.RadialPosition = shift;
            quill.Pen = pen;
            _quills.Add(quill);
        }

        public void RemoveQuill(int index)
        {
            _quills.RemoveAt(index);
        }
    }
}
