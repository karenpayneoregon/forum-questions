using System.Drawing;

public struct ProTransformation
{
	public Point Translation { get { return _translation; } }
	public double Scale => _scale;
    private readonly Point _translation;
	private readonly double _scale;

	public ProTransformation(Point translation, double scale)
	{
		_translation = translation;
		_scale = scale;
	}

	public Point ConvertToIm(Point p) => new Point((int)(p.X * _scale + _translation.X), (int)(p.Y * _scale + _translation.Y));
    public Size ConvertToIm(Size p) => new Size((int)(p.Width * _scale), (int)(p.Height * _scale));
    public Rectangle ConvertToIm(Rectangle r) => new Rectangle(ConvertToIm(r.Location), ConvertToIm(r.Size));
    public Point ConvertToPb(Point p) => new Point((int)((p.X - _translation.X) / _scale), (int)((p.Y - _translation.Y) / _scale));
    public Size ConvertToPb(Size p) => new Size((int)(p.Width / _scale), (int)(p.Height / _scale));
    public Rectangle ConvertToPb(Rectangle r) => new Rectangle(ConvertToPb(r.Location), ConvertToPb(r.Size));
    public ProTransformation SetTranslate(Point p) => new ProTransformation(p, _scale);
    public ProTransformation AddTranslate(Point p) => SetTranslate(new Point(p.X + _translation.X, p.Y + _translation.Y));
    public ProTransformation SetScale(double scale) => new ProTransformation(_translation, scale);
}