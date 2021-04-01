using System;
using System.Drawing;
using System.Windows.Forms;

public class ProPictureBox : PictureBox
{
    private Point? _clickedPoint;
    private ProTransformation _transformation;
    public ProTransformation Transformation
    {
        set
        {
            _transformation = FixTranslation(value);
            Invalidate();
        }
        get => _transformation;
    }

    public ProPictureBox()
    {
        _transformation = new ProTransformation(new Point(100, 0), .5f);
        MouseDown += OnMouseDown;
        MouseMove += OnMouseMove;
        MouseUp += OnMouseUp;
        MouseWheel += OnMouseWheel;
        Resize += OnResize;
    }

    private ProTransformation FixTranslation(ProTransformation value)
    {
            
        var maxScale = Math.Max((double)Image.Width / ClientRectangle.Width, (double)Image.Height / ClientRectangle.Height);
        if (value.Scale > maxScale)
        {
            value = value.SetScale(maxScale);
        }

        if (value.Scale < 0.3)
        {
            value = value.SetScale(0.3);
        }

        var rectSize = value.ConvertToIm(ClientRectangle.Size);
        var max = new Size(Image.Width - rectSize.Width, Image.Height - rectSize.Height);

        value = value.SetTranslate((new Point(Math.Min(value.Translation.X, max.Width), Math.Min(value.Translation.Y, max.Height))));
        if (value.Translation.X < 0 || value.Translation.Y < 0)
        {
            value = value.SetTranslate(new Point(Math.Max(value.Translation.X, 0), Math.Max(value.Translation.Y, 0)));
        }
        
        return value;
    }

    private void OnResize(object sender, EventArgs eventArgs)
    {
        if (Image == null)
        {
            return;
        }

        Transformation = Transformation;
    }

    private void OnMouseWheel(object sender, MouseEventArgs e)
    {
        if (Image == null)
        {
            return;
        }
        
        var transformation = _transformation;
        var pos1 = transformation.ConvertToIm(e.Location);
		
        transformation = e.Delta > 0 ? 
            transformation.SetScale(Transformation.Scale / 1.25) : 
            transformation.SetScale(Transformation.Scale * 1.25);
        
        var pos2 = transformation.ConvertToIm(e.Location);
        transformation = transformation.AddTranslate(pos1 - (Size)pos2);
        Transformation = transformation;
    }

    private void OnMouseUp(object sender, MouseEventArgs mouseEventArgs)
    {
        _clickedPoint = null;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (_clickedPoint == null)
        {
            return;
        }

        var p = _transformation.ConvertToIm((Size)e.Location);
        Transformation = _transformation.SetTranslate(_clickedPoint.Value - p);
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        if (Image == null)
        {
            return;
        }
        
        Focus();
        
        _clickedPoint = _transformation.ConvertToIm(e.Location);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (Image == null)
        {
            return;
        }
        
        var imRect = Transformation.ConvertToIm(ClientRectangle);
        e.Graphics.DrawImage(Image, ClientRectangle, imRect, GraphicsUnit.Pixel);
    }

    public void DecideInitialTransformation()
    {
        Transformation = new ProTransformation(Point.Empty, int.MaxValue);
    }
}