using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Spirograph
{
    
    public class Spirograph
    {
        private Ring _fixedRing;
        private Ring _movingRing;
        private int _loops;
        private double _startAngle;
        private double _currentAngle;
        private double _deltaAngle;
        private List<PointF> _previousQuills;
        private List<PointF> _currentQuills;
        private Graphics _canvas;
        private Size _canvasSize;
        private Bitmap _bmp;
        private RectangleF _bounds;
        private Color _backColor;
        private int _delay;

        public Spirograph()
        {
            _previousQuills = new List<PointF>();
            _currentQuills = new List<PointF>();
        }

        public Spirograph(double fixedInnerR,double fixedOuterR,double movingInnerR,double movingOuterR,
            bool inside,int loops,double deltaAngle,Graphics canvas, double initialAngle)
        {
            //_fixedRing = new Ring(fixedInnerR, fixedOuterR);
            //_movingRing = new Ring(movingInnerR, movingOuterR);
            //_previousAngle = _currentAngle = 0;
            //_loops = loops;
            //_deltaAngle = deltaAngle;
            //_canvas = canvas;
            //InitializeQuills();
        }

        #region Properties

        public Ring FixedRing
        {
            get
            {
                return _fixedRing;
            }

            set
            {
                _fixedRing = value;
            }
        }

        public Ring MovingRing
        {
            get
            {
                return _movingRing;
            }

            set
            {
                _movingRing = value;
            }
        }

        public int Loops
        {
            get
            {
                return _loops;
            }

            set
            {
                _loops = value;
            }
        }

        public double DeltaAngle
        {
            get
            {
                return _deltaAngle;
            }

            set
            {
                _deltaAngle = value;
            }
        }

        public Graphics Canvas
        {
            get
            {
                return _canvas;
            }

            set
            {
                _canvas = value;
            }
        }

        public double StartAngle
        {
            get
            {
                return _startAngle;
            }

            set
            {
                _startAngle = value;
            }
        }

        public RectangleF Bounds
        {
            get
            {
                return _bounds;
            }

            set
            {
                _bounds = value;
            }
        }

        public Color BackColor
        {
            get
            {
                return _backColor;
            }

            set
            {
                _backColor = value;
            }
        }

        public int Delay
        {
            get
            {
                return _delay;
            }

            set
            {
                _delay = value;
            }
        }

        public Size CanvasSize
        {
            get
            {
                return _canvasSize;
            }

            set
            {
                _canvasSize = value;
            }
        }

        public Bitmap Bmp
        {
            get
            {
                return _bmp;
            }
        }
        #endregion

        #region Drawing

        public void Draw()
        {
            _canvas.Clear(_backColor);
            _bmp = new Bitmap((int)_bounds.Width, (int)_bounds.Height);
            Graphics buffer = Graphics.FromImage(Bmp);
            _currentAngle = _startAngle;
            InitializeQuills();
            while (_currentAngle <= (_loops * 360 + _startAngle))
            {
                FillQuillsLists();
                for (int i = 0; i < _currentQuills.Count; i++)
                {
                    _canvas.DrawLine(_movingRing.Quills[i].Pen, _previousQuills[i], _currentQuills[i]);
                    buffer.DrawLine(_movingRing.Quills[i].Pen, _previousQuills[i], _currentQuills[i]);
                }
                System.Threading.Thread.Sleep(_delay);
                _currentAngle += _deltaAngle;
            }
        }

        private void FillQuillsLists()
        {
            PointF result;
            for(int i=0;i<_movingRing.Quills.Count;i++)
            {
                _previousQuills[i] = _currentQuills[i];
                result = QuillPosition(_movingRing.Quills[i]);
                _currentQuills[i] = result;
            }
        }

        private void InitializeQuills()
        {
            PointF result;
            _currentAngle = _startAngle;
            _currentQuills.Clear();
            foreach (Quill quill in _movingRing.Quills)
            {
                result = QuillPosition(quill);
                _currentQuills.Add(result);
                _previousQuills.Add(result);
            }
        }

        private PointF QuillPosition(Quill quill)
        {
            PointF result = new PointF();
            double alpha = Utils.Degrees2Radians(_currentAngle);
            PointF B = new PointF();
            int distance;
            double theta;
            if (_fixedRing.Touch == Edges.Outer)
            {
                if (_movingRing.Touch == Edges.Outer)
                {
                    distance = _fixedRing.OuterRadius + _movingRing.OuterRadius;
                    theta = alpha * _fixedRing.OuterRadius / _movingRing.OuterRadius + Utils.Degrees2Radians(quill.AngularPosition);
                }
                else
                {
                    distance = _fixedRing.OuterRadius - _movingRing.InnerRadius;
                    theta = alpha * _fixedRing.OuterRadius/ _movingRing.InnerRadius+ Utils.Degrees2Radians(quill.AngularPosition);
                }
            }
            else
            {
                if (_movingRing.Touch == Edges.Outer)
                {
                    distance = _fixedRing.InnerRadius - _movingRing.OuterRadius;
                    theta = alpha * _fixedRing.InnerRadius / _movingRing.OuterRadius + Utils.Degrees2Radians(quill.AngularPosition);
                }
                else
                {
                    distance = _fixedRing.InnerRadius - _movingRing.InnerRadius;
                    theta = alpha * _fixedRing.InnerRadius / _movingRing.InnerRadius + Utils.Degrees2Radians(quill.AngularPosition);
                }
            }
            B.X = (float)(distance * Math.Cos(alpha));
            B.Y = (float)(distance * Math.Sin(alpha));
            result.X = B.X +
                (float)((_movingRing.InnerRadius + quill.RadialPosition *
                            (_movingRing.OuterRadius - _movingRing.InnerRadius) / 100
                                 + _movingRing.InnerRadius) * Math.Cos(theta) + _bounds.Width / 2);
            result.Y = B.Y +
                (float)((_movingRing.InnerRadius + quill.RadialPosition *
                            (_movingRing.OuterRadius - _movingRing.InnerRadius) / 100
                                 + _movingRing.InnerRadius) * Math.Sin(theta) + _bounds.Height / 2);
            return result;
        }

        #endregion
    }
}
