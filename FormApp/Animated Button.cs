using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animated_Button_C_Sharp
{
    public partial class Animated_Button : Button
    {
        #region Frame

        public class Frame
        {
            public Frame(Image ImageStrip, int FrameCount, int CurrentFrame, Size FrameSize)
            {
                this.ImageStrip = ImageStrip;
                this.FrameCount = FrameCount;
                this.CurrentFrame = CurrentFrame;
                this.FrameSize = FrameSize;
            }

            public Image ImageStrip
            {
                get;
                set;
            }

            public int FrameCount
            {
                get;
                set;
            }

            public int CurrentFrame
            {
                get;
                set;
            }

            public Size FrameSize
            {
                get;
                set;
            }
        }

        #endregion

        #region MouseOver

        private bool _IsMouseOver = false;

        public bool IsMouseOver
        {
            get
            {
                return _IsMouseOver;
            }
            set
            {
                _IsMouseOver = value;

                Refresh();
            }
        }

        public Frame MouseOverFrame
        {
            get;
            set;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            IsMouseOver = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            IsMouseOver = false;
        }

        #endregion

        #region MouseDown

        public bool _IsMouseDown = false;

        public bool IsMouseDown
        {
            get
            {
                return _IsMouseDown;
            }
            set
            {
                _IsMouseDown = value;

                Refresh();
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            IsMouseDown = true;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            IsMouseDown = false;
        }

        public Frame MouseDownFrame
        {
            get;
            set;
        }

        #endregion

        public Animated_Button()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            MouseOverFrame = new Frame(FormApp.Properties.Resources.ButtonMouseOver, 25, 0, new Size(100, 30));
            MouseDownFrame = new Frame(FormApp.Properties.Resources.ButtonMouseDown, 25, 0, new Size(100, 30));

            this.Size = MouseOverFrame.FrameSize;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.Clear(BackColor);

            pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pe.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (!IsMouseOver && !IsMouseDown && MouseOverFrame.CurrentFrame == 0)
            {
                pe.Graphics.DrawImage(MouseOverFrame.ImageStrip, 
                    new Rectangle(new Point(0, 0), MouseOverFrame.FrameSize), 
                    new Rectangle(new Point(0, 0), MouseOverFrame.FrameSize), 
                    GraphicsUnit.Pixel);
            }
            else if (IsMouseOver && !IsMouseDown && MouseOverFrame.CurrentFrame != MouseOverFrame.FrameCount)
            {
                pe.Graphics.DrawImage(MouseOverFrame.ImageStrip, 
                    new Rectangle(new Point(0, 0), MouseOverFrame.FrameSize), 
                    new Rectangle(new Point(0, MouseOverFrame.CurrentFrame++ * MouseOverFrame.FrameSize.Height), MouseOverFrame.FrameSize), 
                    GraphicsUnit.Pixel);
            }
            else if(IsMouseOver && !IsMouseDown && MouseOverFrame.CurrentFrame == MouseOverFrame.FrameCount && MouseDownFrame.CurrentFrame == 0)
            {
                pe.Graphics.DrawImage(MouseOverFrame.ImageStrip,
                    new Rectangle(new Point(0, 0), MouseOverFrame.FrameSize),
                    new Rectangle(new Point(0, (MouseOverFrame.CurrentFrame - 1) * MouseOverFrame.FrameSize.Height), MouseOverFrame.FrameSize),
                    GraphicsUnit.Pixel);
            }
            else if (IsMouseOver && IsMouseDown && MouseDownFrame.CurrentFrame != MouseDownFrame.FrameCount)
            {
                pe.Graphics.DrawImage(MouseDownFrame.ImageStrip,
                    new Rectangle(new Point(0, 0), MouseDownFrame.FrameSize),
                    new Rectangle(new Point(0, MouseDownFrame.CurrentFrame++ * MouseDownFrame.FrameSize.Height), MouseDownFrame.FrameSize),
                    GraphicsUnit.Pixel);
            }
            else if (IsMouseOver && IsMouseDown && MouseDownFrame.CurrentFrame == MouseDownFrame.FrameCount)
            {
                pe.Graphics.DrawImage(MouseDownFrame.ImageStrip,
                    new Rectangle(new Point(0, 0), MouseDownFrame.FrameSize),
                    new Rectangle(new Point(0, (MouseDownFrame.CurrentFrame - 1) * MouseDownFrame.FrameSize.Height), MouseDownFrame.FrameSize),
                    GraphicsUnit.Pixel);
            }
            else if (IsMouseOver && !IsMouseDown && MouseDownFrame.CurrentFrame != 0)
            {
                pe.Graphics.DrawImage(MouseDownFrame.ImageStrip,
                    new Rectangle(new Point(0, 0), MouseDownFrame.FrameSize),
                    new Rectangle(new Point(0, --MouseDownFrame.CurrentFrame * MouseDownFrame.FrameSize.Height), MouseDownFrame.FrameSize),
                    GraphicsUnit.Pixel);
            }
            else if (!IsMouseOver && !IsMouseDown && MouseOverFrame.CurrentFrame != 0)
            {
                pe.Graphics.DrawImage(MouseOverFrame.ImageStrip,
                    new Rectangle(new Point(0, 0), MouseOverFrame.FrameSize),
                    new Rectangle(new Point(0, --MouseOverFrame.CurrentFrame * MouseOverFrame.FrameSize.Height), MouseOverFrame.FrameSize),
                    GraphicsUnit.Pixel);
            }

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                pe.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), pe.ClipRectangle, sf);
            }
        }

        #region Timer

        private void _FPS_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        #endregion
    }
}
