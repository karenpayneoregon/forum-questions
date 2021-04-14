using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootstrap
{

    namespace Control
    {
        public class Control : System.Windows.Forms.Control
        {
            private Color _borderColor;
            public Color BorderColor
            {
                get => _borderColor;
                set
                {
                    if (_borderColor != value)
                    {
                        _borderColor = value;
                        OnBorderColorChanged();
                    }
                }
            }

            private bool _drawBorder;
            public bool DrawBorder
            {
                get => _drawBorder;
                set
                {
                    if (_drawBorder != value)
                    {
                        _drawBorder = value;
                        OnDrawBorderChanged();
                    }
                }
            }

            protected virtual void OnBorderColorChanged()
            {
                BorderColorChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnDrawBorderChanged()
            {
                DrawBorderChanged?.Invoke(this, EventArgs.Empty);
            }

            public delegate void BorderColorChangedEventHandler(object sender, EventArgs e);
            public event BorderColorChangedEventHandler BorderColorChanged;
            public delegate void DrawBorderChangedEventHandler(object sender, EventArgs e);
            public event DrawBorderChangedEventHandler DrawBorderChanged;

            private void Control_BorderPropertiesChanged(object sender, EventArgs e)
            {
                Invalidate(true);
            }

            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int width, int height, int cx, int cy);

            public Control()
            {
                Font = Bootstrap.Utilities.Typography.Font();
                Region = Region.FromHrgn(Bootstrap.Control.Control.CreateRoundRectRgn(0, 0, Width, Height, Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(this.Font) * 0.25), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 0.25)));
                BackColor = Bootstrap.Utilities.Color.BackgroundLight();
                ForeColor = Bootstrap.Utilities.Color.TextBody();

                Padding = new Padding(Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 0.75 * 72 / 96), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(this.Font) * 1.25 * 72 / 96), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(this.Font) * 0.75 * 72 / 96), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 1.25 * 72 / 96));

                BorderColor = BackColor;
                DrawBorder = false;
                SubscribeToEvents();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                int radius = Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 0.25);
                Rectangle area = DisplayRectangle;
                var path = new System.Drawing.Drawing2D.GraphicsPath();

                area.Width -= 2;
                area.Height -= 2;

                path.AddArc(area.Left, area.Top, radius * 2, radius * 2, 180, 90); //Upper-Left
                path.AddArc(area.Right - (radius * 2), area.Top, radius * 2, radius * 2, 270, 90); //Upper-Right
                path.AddArc(area.Right - (radius * 2), area.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90); //Lower-Right
                path.AddArc(area.Left, area.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90); //Lower-Left
                path.CloseAllFigures();

                using Pen pen = new Pen(_borderColor, 1);
                e.Graphics.DrawPath(pen, path);
            }

            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);

                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 0.25), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(Font) * 0.25)));
            }


            private bool EventsSubscribed = false;
            private void SubscribeToEvents()
            {
                if (EventsSubscribed) { return; } else { EventsSubscribed = true; }

                BorderColorChanged += Control_BorderPropertiesChanged;
                DrawBorderChanged += Control_BorderPropertiesChanged;
            }

        }

        [DefaultEvent("IsDismissedChanged")]
        public class Alert : Bootstrap.Control.Control
        {
            public enum StyleType
            {
                Danger,
                Dark,
                Info,
                Light,
                Primary,
                Secondary,
                Success,
                Warning
            }

            private bool _dismissable;
            public bool Dismissable
            {
                get => _dismissable;
                set
                {
                    if (_dismissable == value) return;
                    _dismissable = value;
                    OnDismissableChanged();
                }
            }

            private bool _fadable;
            public bool Fadable
            {
                get => _fadable;
                set
                {
                    _fadable = value;
                }
            }

            private bool _isDismissed;
            public bool IsDismissed
            {
                get => _isDismissed;
                set
                {
                    if (_isDismissed.Equals(value)) return;
                    _isDismissed = value;
                    OnIsDismissedChanged();
                }
            }

            private StyleType _style;
            public StyleType Style
            {
                get => _style;
                set
                {
                    if (_style == value) return;
                    _style = value;
                    OnStyleChanged();
                }
            }

            protected virtual void OnDismissableChanged()
            {
                DismissableChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnIsDismissedChanged()
            {
                IsDismissedChanged?.Invoke(this, EventArgs.Empty);
            }

            protected new virtual void OnStyleChanged()
            {
                StyleChanged?.Invoke(this, EventArgs.Empty);
            }

            public delegate void IsDismissedChangedEventHandler(object sender, EventArgs e);
            public event IsDismissedChangedEventHandler IsDismissedChanged;

            public delegate void DismissableChangedEventHandler(object sender, EventArgs e);
            public event DismissableChangedEventHandler DismissableChanged;

            public new delegate void StyleChangedEventHandler(object sender, EventArgs e);
            public new event StyleChangedEventHandler StyleChanged;

            //Key: Style, Value: -> Key: BackgroundColor Value: Forecolor
            private Dictionary<Alert.StyleType, KeyValuePair<System.Drawing.Color, System.Drawing.Color>> styleConfiguration;

            public Alert() : base()
            {
                styleConfiguration = new Dictionary<StyleType, KeyValuePair<Color, Color>>
                {
                    {Alert.StyleType.Danger, new KeyValuePair<Color, Color>(Color.FromArgb(248, 215, 218), Color.FromArgb(114, 28, 36))},
                    {Alert.StyleType.Dark, new KeyValuePair<Color, Color>(Color.FromArgb(198, 200, 202), Color.FromArgb(27, 30, 33))},
                    {Alert.StyleType.Info, new KeyValuePair<System.Drawing.Color, Color>(Color.FromArgb(209, 236, 241), Color.FromArgb(12, 84, 96))},
                    {Alert.StyleType.Light, new KeyValuePair<Color, Color>(Color.FromArgb(254, 254, 254), Color.FromArgb(129, 129, 130))},
                    {Alert.StyleType.Primary, new KeyValuePair<Color, Color>(Color.FromArgb(204, 229, 255), Color.FromArgb(0, 64, 133))},
                    {Alert.StyleType.Secondary, new KeyValuePair<Color, Color>(Color.FromArgb(226, 227, 229), Color.FromArgb(56, 61, 65))},
                    {Alert.StyleType.Success, new KeyValuePair<Color, Color>(Color.FromArgb(212, 237, 218), Color.FromArgb(21, 87, 36))},
                    {Alert.StyleType.Warning, new KeyValuePair<Color, Color>(Color.FromArgb(255, 243, 205), Color.FromArgb(133, 100, 4))}
                };

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                Dismissable = false;
                DoubleBuffered = true;
                Fadable = false;
                Style = StyleType.Primary;
                KickOff();
            }

            private void Alert_DismissableChanged(object sender, EventArgs e)
            {
                Invalidate(true);
            }
            private void Alert_IsDismissedChanged(object sender, EventArgs e)
            {
                Dispose(true);
            }
            protected override void OnMouseClick(MouseEventArgs e)
            {
                base.OnMouseClick(e);

                if (Dismissable && e.Button == MouseButtons.Left && MouseOverDismiss(e.X, e.Y))
                {
                    Dismiss();
                }
            }
            protected override void OnMouseMove(MouseEventArgs e)
            {
                base.OnMouseMove(e);

                if (Dismissable && MouseOverDismiss(e.X, e.Y))
                {
                    Cursor = Cursors.Hand;
                }
                else
                {
                    Cursor = Cursors.Default;
                }
            }
            protected override void OnPaddingChanged(EventArgs e)
            {
                base.OnPaddingChanged(e);

                Invalidate(true);
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                int paddingTop = this.Padding.Top;
                int paddingRight = this.Padding.Right;
                if (Dismissable)
                {
                    using Brush dismissBrush = new SolidBrush(styleConfiguration[this.Style].Value);
                    e.Graphics.DrawString(Bootstrap.Utilities.Typography.Close(), Bootstrap.Utilities.Typography.Font(), dismissBrush, new Point(this.Width - Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(this.Font)) - 5, 5));
                    SizeF dismissSize = e.Graphics.MeasureString(Bootstrap.Utilities.Typography.Close(), Bootstrap.Utilities.Typography.Font());
                    if (dismissSize.Height + 5 > paddingTop)
                    {
                        paddingTop = Convert.ToInt32(dismissSize.Height) + 5;
                    }
                    if (dismissSize.Width + 5 > paddingRight)
                    {
                        paddingRight = Convert.ToInt32(dismissSize.Width) + 5;
                    }
                }

                Rectangle textBounds = DisplayRectangle;
                textBounds.Y += Padding.Top;
                textBounds.X += Padding.Left;
                textBounds.Width -= (paddingRight + Padding.Right + Padding.Left);
                textBounds.Height -= (Padding.Bottom + Padding.Top);

                TextRenderer.DrawText(e.Graphics, Text, Font, textBounds, ForeColor, TextFormatFlags.NoPadding | TextFormatFlags.Top | TextFormatFlags.WordBreak);

                base.OnPaint(e);
            }
            private void Alert_StyleChanged(object sender, EventArgs e)
            {
                BackColor = styleConfiguration[Style].Key;
                BorderColor = styleConfiguration[Style].Key;
                ForeColor = styleConfiguration[Style].Value;
                Invalidate(true);
            }
            protected override void OnTextChanged(EventArgs e)
            {
                base.OnTextChanged(e);
                Invalidate(true);
            }

            public async void Dismiss()
            {
                if (Fadable)
                {
                    await Task.Run(() =>
                    {
                        SuspendLayout();
                        do
                        {
                            BackColor = Color.FromArgb(BackColor.A - 1, BackColor.R, BackColor.G, BackColor.B);
                            System.Threading.Thread.Sleep(byte.MaxValue / 150);
                        } while (!(BackColor.A == 0));
                        ResumeLayout();
                    });
                }
                
                IsDismissed = Dismissable && !IsDismissed;
            }
            private bool MouseOverDismiss(int mouseX, int mouseY)
            {
                var closeDimensions = new SizeF(0, 0);

                using Graphics closeGraphics = Graphics.FromHwnd(Handle);
                closeDimensions = closeGraphics.MeasureString(Bootstrap.Utilities.Typography.Close(), Font);

                return mouseX > Width - closeDimensions.Width && mouseY < closeDimensions.Height + 5;
            }

            public static DialogResult ShowDialog(string text) => Bootstrap.Control.Alert.ShowDialog(text, Bootstrap.Control.Alert.StyleType.Primary, false);
            public static DialogResult ShowDialog(string text, Bootstrap.Control.Alert.StyleType style)
            {
                return Bootstrap.Control.Alert.ShowDialog(text, style, false);
            }

            public static DialogResult ShowDialog(string text, Bootstrap.Control.Alert.StyleType style, bool fade)
            {
                DialogResult modalResult = DialogResult.Ignore;

                using Form modal = new Form();

                var _alert = new Bootstrap.Control.Alert {Dismissable = true, Dock = DockStyle.Fill, Fadable = fade, Style = style, Text = text};

                _alert.IsDismissedChanged += (sender, e) =>
                {
                    modal.DialogResult = DialogResult.OK;
                    modal.Close();
                };

                modal.Controls.Add(_alert);
                modal.FormBorderStyle = FormBorderStyle.None;
                modal.Size = new Size(300, 100);
                modal.StartPosition = FormStartPosition.CenterParent;

                modal.Load += (sender, e) =>
                {
                    modal.Region = Region.FromHrgn(Bootstrap.Control.Control.CreateRoundRectRgn(0, 0, modal.Width, modal.Height, Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(_alert) * 0.25), Convert.ToInt32(Bootstrap.Utilities.Typography.CalculateEM(_alert) * 0.25)));
                };

                modalResult = modal.ShowDialog();

                return modalResult;
            }
            
            private bool EventsSubscribed = false;
            private void KickOff()
            {
                if (EventsSubscribed)
                {
                    return;
                }
                else
                {
                    EventsSubscribed = true;
                }

                DismissableChanged += Alert_DismissableChanged;
                IsDismissedChanged += Alert_IsDismissedChanged;
                StyleChanged += Alert_StyleChanged;
            }

        }

        [DefaultEvent("Click")]
        public class Button : Bootstrap.Control.Control
        {
            public enum StyleType
            {
                Danger,
                Dark,
                Info,
                Light,
                Primary,
                Secondary,
                Success,
                Warning
            }

            private bool _isOutline;
            public bool IsOutline
            {
                get => _isOutline;
                set
                {
                    if (_isOutline.Equals(value)) return;
                    _isOutline = value;
                    OnIsOutlineChanged();
                }
            }

            private StyleType _style;
            public StyleType Style
            {
                get => _style;
                set
                {
                    if (_style == value) return;
                    _style = value;
                    OnStyleChanged();
                }
            }

            protected virtual void OnIsOutlineChanged()
            {
                IsOutlineChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual new void OnStyleChanged()
            {
                StyleChanged?.Invoke(this, EventArgs.Empty);
            }

            public delegate void IsOutlineChangedEventHandler(object sender, EventArgs e);
            public event IsOutlineChangedEventHandler IsOutlineChanged;

            public new delegate void StyleChangedEventHandler(object sender, EventArgs e);
            public new event StyleChangedEventHandler StyleChanged;

            //Key: Style, Value: -> Key: BackgroundColor Value: Forecolor
            private Dictionary<StyleType, KeyValuePair<Color, Color>> styleConfiguration;

            //Key: Style, Value: -> Key: MouseEnter (hover) Value: MouseDown (active)
            private Dictionary<StyleType, KeyValuePair<Color, Color>> styleConfigurationMouseEvents;
            public Button()
            {
                styleConfiguration = new Dictionary<StyleType, KeyValuePair<Color, Color>>
                {
                    {Button.StyleType.Danger, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundDanger(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Dark, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundDark(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Info, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundInfo(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Light, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundLight(), Bootstrap.Utilities.Color.TextBody())},
                    {Button.StyleType.Primary, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundPrimary(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Secondary, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundSecondary(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Success, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundSuccess(), Bootstrap.Utilities.Color.TextWhite())},
                    {Button.StyleType.Warning, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.BackgroundWarning(), Bootstrap.Utilities.Color.TextBody())}
                };

                styleConfigurationMouseEvents = new Dictionary<StyleType, KeyValuePair<Color, Color>>
                {
                    {Button.StyleType.Danger, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundDanger(), Bootstrap.Utilities.Color.ActiveBackgroundDanger())},
                    {Button.StyleType.Dark, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundDark(), Bootstrap.Utilities.Color.ActiveBackgroundDark())},
                    {Button.StyleType.Info, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundInfo(), Bootstrap.Utilities.Color.ActiveBackgroundInfo())},
                    {Button.StyleType.Light, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundLight(), Bootstrap.Utilities.Color.ActiveBackgroundLight())},
                    {Button.StyleType.Primary, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundPrimary(), Bootstrap.Utilities.Color.ActiveBackgroundPrimary())},
                    {Button.StyleType.Secondary, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundSecondary(), Bootstrap.Utilities.Color.ActiveBackgroundSecondary())},
                    {Button.StyleType.Success, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundSuccess(), Bootstrap.Utilities.Color.ActiveBackgroundSuccess())},
                    {Button.StyleType.Warning, new KeyValuePair<Color, Color>(Bootstrap.Utilities.Color.HoverBackgroundWarning(), Bootstrap.Utilities.Color.ActiveBackgroundWarning())}
                };

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                Style = StyleType.Primary;
                SubscribeToEvents();
            }

            protected override void OnEnabledChanged(EventArgs e)
            {
                base.OnEnabledChanged(e);

                Invalidate(true);
            }

            private bool mouseDowned = false;
            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                mouseDowned = true;
                Invalidate(true);
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                mouseDowned = false;
                Invalidate(true);
            }

            private bool mouseEntered = false;
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                mouseEntered = true;
                Invalidate(true);
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                mouseEntered = false;
                Invalidate(true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Color textColor = ForeColor;
                Color backColor = BackColor;

                if (_isOutline)
                {
                    backColor = Color.FromArgb(Bootstrap.Utilities.Color.BackgroundWhite().R, Bootstrap.Utilities.Color.BackgroundWhite().G, Bootstrap.Utilities.Color.BackgroundWhite().B);
                }
                else if (_isOutline && !mouseDowned && !mouseEntered)
                {
                    backColor = Bootstrap.Utilities.Color.BackgroundWhite();
                }
                else if (!Enabled)
                {
                    backColor = Color.FromArgb(Convert.ToInt32(byte.MaxValue * 0.65), backColor.R, backColor.G, backColor.B);
                }
                else if (mouseDowned)
                {
                    backColor = styleConfigurationMouseEvents[_style].Value;
                }
                else if (mouseEntered)
                {
                    backColor = styleConfigurationMouseEvents[_style].Key;
                }

                if (_isOutline)
                {
                    textColor = styleConfiguration[_style].Key;
                }

                if (_isOutline && (mouseDowned || mouseEntered))
                {
                    backColor = styleConfiguration[_style].Key;
                    textColor = Bootstrap.Utilities.Color.TextWhite();
                    
                    if (_style == StyleType.Warning || _style == StyleType.Light)
                    {
                        textColor = Bootstrap.Utilities.Color.TextBody();
                    }
                }

                e.Graphics.Clear(backColor);

                TextRenderer.DrawText(
                    e.Graphics, 
                    Text, 
                    Font, 
                    DisplayRectangle, 
                    textColor, 
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                base.OnPaint(e);
            }

            private void Button_StyleChanged(object sender, EventArgs e)
            {
                BackColor = styleConfiguration[this.Style].Key;
                BorderColor = styleConfiguration[this.Style].Key;
                ForeColor = styleConfiguration[this.Style].Value;
                Invalidate(true);
            }


            private bool EventsSubscribed = false;
            private void SubscribeToEvents()
            {
                if (EventsSubscribed)
                {
                    return;
                }
                else
                {
                    EventsSubscribed = true;
                }

                StyleChanged += Button_StyleChanged;
            }

        }

        [DefaultEvent("CheckedChanged")]
        public class ToggleSwitch : Bootstrap.Control.Control
        {
            private bool _checked;
            public bool Checked
            {
                get => _checked;
                set
                {
                    if (_checked == value) return;
                    _checked = value;
                    OnCheckedChanged();
                }
            }

            private Color _falseColor;
            public Color FalseColor
            {
                get => _falseColor;
                set
                {
                    if (_falseColor == value) return;
                    _falseColor = value;
                    OnFalseColorChanged();
                }
            }

            private string _falseText;
            public string FalseText
            {
                get => _falseText;
                set
                {
                    if (_falseText == value) return;
                    _falseText = value;
                    OnFalseTextChanged();
                }
            }

            private Color _trueColor;
            public Color TrueColor
            {
                get => _trueColor;
                set
                {
                    if (_trueColor == value) return;
                    _trueColor = value;
                    OnTrueColorChanged();
                }
            }

            private string _trueText;
            public string TrueText
            {
                get => _trueText;
                set
                {
                    if (_trueText == value) return;
                    _trueText = value;
                    OnTrueTextChanged();
                }
            }

            protected virtual void OnCheckedChanged()
            {
                Invalidate(true);
                if (CheckedChanged == null) return;
                CheckedChanged(this, EventArgs.Empty);
            }

            protected virtual void OnFalseColorChanged()
            {
                Invalidate(true);
                FalseColorChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnFalseTextChanged()
            {
                Invalidate(true);
                FalseTextChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnTrueColorChanged()
            {
                Invalidate(true);
                TrueColorChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnTrueTextChanged()
            {
                Invalidate(true);
                TrueTextChanged?.Invoke(this, EventArgs.Empty);
            }

            public delegate void CheckedChangedEventHandler(object sender, EventArgs e);
            public event CheckedChangedEventHandler CheckedChanged;
            public delegate void FalseColorChangedEventHandler(object sender, EventArgs e);
            public event FalseColorChangedEventHandler FalseColorChanged;
            public delegate void FalseTextChangedEventHandler(object sender, EventArgs e);
            public event FalseTextChangedEventHandler FalseTextChanged;
            public delegate void TrueColorChangedEventHandler(object sender, EventArgs e);
            public event TrueColorChangedEventHandler TrueColorChanged;
            public delegate void TrueTextChangedEventHandler(object sender, EventArgs e);
            public event TrueTextChangedEventHandler TrueTextChanged;

            public ToggleSwitch()
            {
                BorderColor = Bootstrap.Utilities.Color.TextBody();
                ForeColor = Bootstrap.Utilities.Color.TextWhite();
                
                _checked = true;
                _falseColor = Bootstrap.Utilities.Color.BackgroundDanger();
                _falseText = "Off";
                _trueColor = Bootstrap.Utilities.Color.BackgroundSuccess();
                _trueText = "On";
            }

            protected override void OnMouseClick(MouseEventArgs e)
            {
                base.OnMouseClick(e);

                _checked = !_checked;
                OnCheckedChanged();
            }

            protected override void OnMouseMove(MouseEventArgs e)
            {
                base.OnMouseMove(e);

                int halfControlWidth = Convert.ToInt32(this.Width / 2.0);
                Cursor = (_checked && e.X > halfControlWidth) || (!_checked && e.X < halfControlWidth) ? Cursors.Hand : Cursors.Default;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                int halfControlWidth = Convert.ToInt32(this.Width / 2.0);
                Rectangle sliderRectangle = new Rectangle(((!_checked) ? halfControlWidth : 0), 0, halfControlWidth, this.Height);
                using Brush sliderBorderBrush = new SolidBrush(Bootstrap.Utilities.Color.BackgroundLight());
                e.Graphics.FillRectangle(sliderBorderBrush, sliderRectangle);

                sliderRectangle.Y += 1;
                sliderRectangle.Height -= 4;
                using Brush sliderBackgroundBrush = new SolidBrush(_checked ? _trueColor : _falseColor);
                e.Graphics.FillRectangle(sliderBackgroundBrush, sliderRectangle);

                using Pen toggleBorderPen = new Pen(BorderColor, 1);
                e.Graphics.DrawLine(toggleBorderPen, new Point(halfControlWidth, 0), new Point(halfControlWidth, this.Height));

                TextRenderer.DrawText(e.Graphics, (_checked ? _trueText : _falseText), this.Font, this.DisplayRectangle, this.ForeColor, TextFormatFlags.LeftAndRightPadding | TextFormatFlags.VerticalCenter | (_checked ? TextFormatFlags.Left : TextFormatFlags.Right));

            }

            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                Invalidate(true);
            }

        }

    }

    namespace Utilities
    {

        public static class Color
        {
            public static System.Drawing.Color ActiveBackgroundDanger() => System.Drawing.Color.FromArgb(189, 33, 48);
            public static System.Drawing.Color ActiveBackgroundDark() => System.Drawing.Color.FromArgb(29, 33, 36);
            public static System.Drawing.Color ActiveBackgroundInfo() => System.Drawing.Color.FromArgb(17, 122, 139);
            public static System.Drawing.Color ActiveBackgroundLight() => System.Drawing.Color.FromArgb(218, 224, 229);
            public static System.Drawing.Color ActiveBackgroundPrimary() => System.Drawing.Color.FromArgb(0, 98, 204);
            public static System.Drawing.Color ActiveBackgroundSecondary() => System.Drawing.Color.FromArgb(84, 91, 98);
            public static System.Drawing.Color ActiveBackgroundSuccess() => System.Drawing.Color.FromArgb(30, 126, 52);
            public static System.Drawing.Color ActiveBackgroundWarning() => System.Drawing.Color.FromArgb(211, 158, 0);
            public static System.Drawing.Color BackgroundDanger() => System.Drawing.Color.FromArgb(220, 53, 69);
            public static System.Drawing.Color BackgroundDark() => System.Drawing.Color.FromArgb(52, 58, 64);
            public static System.Drawing.Color BackgroundInfo() => System.Drawing.Color.FromArgb(23, 162, 184);
            public static System.Drawing.Color BackgroundLight() => System.Drawing.Color.FromArgb(248, 249, 250);
            public static System.Drawing.Color BackgroundPrimary() => System.Drawing.Color.FromArgb(0, 123, 255);
            public static System.Drawing.Color BackgroundSecondary() => System.Drawing.Color.FromArgb(108, 117, 125);
            public static System.Drawing.Color BackgroundSuccess() => System.Drawing.Color.FromArgb(40, 167, 69);
            public static System.Drawing.Color BackgroundWarning() => System.Drawing.Color.FromArgb(255, 193, 7);
            public static System.Drawing.Color BackgroundWhite() => System.Drawing.Color.FromArgb(255, 255, 255);
            public static System.Drawing.Color HoverBackgroundDanger() => System.Drawing.Color.FromArgb(200, 35, 51);
            public static System.Drawing.Color HoverBackgroundDark() => System.Drawing.Color.FromArgb(35, 39, 43);
            public static System.Drawing.Color HoverBackgroundInfo() => System.Drawing.Color.FromArgb(19, 132, 150);
            public static System.Drawing.Color HoverBackgroundLight() => System.Drawing.Color.FromArgb(226, 230, 234);
            public static System.Drawing.Color HoverBackgroundPrimary() => System.Drawing.Color.FromArgb(0, 105, 217);
            public static System.Drawing.Color HoverBackgroundSecondary() => System.Drawing.Color.FromArgb(90, 98, 104);
            public static System.Drawing.Color HoverBackgroundSuccess() => System.Drawing.Color.FromArgb(33, 136, 56);
            public static System.Drawing.Color HoverBackgroundWarning() => System.Drawing.Color.FromArgb(224, 168, 0);
            public static System.Drawing.Color[] EnumerateBackgroundColors()
            {
                return new[] { Color.BackgroundDanger(), Color.BackgroundDark(), Color.BackgroundInfo(), Color.BackgroundLight(), Color.BackgroundPrimary(), Color.BackgroundSecondary(), Color.BackgroundSuccess(), Color.BackgroundWarning(), Color.BackgroundWhite() };
            }
            public static System.Drawing.Color[] EnumerateHoverBackgroundColors()
            {
                return new[] { Color.HoverBackgroundDanger(), Color.HoverBackgroundDark(), Color.HoverBackgroundInfo(), Color.HoverBackgroundLight(), Color.HoverBackgroundPrimary(), Color.HoverBackgroundSecondary(), Color.HoverBackgroundSuccess(), Color.HoverBackgroundWarning() };
            }
            public static System.Drawing.Color[] EnumerateTextColors()
            {
                return new[] { Color.TextBlack50(), Color.TextBody(), Color.TextDanger(), Color.TextDark(), Color.TextInfo(), Color.TextLight(), Color.TextMuted(), Color.TextPrimary(), Color.TextSecondary(), Color.TextSuccess(), Color.TextWarning(), Color.TextWhite(), Color.TextWhite50() };
            }
            public static System.Drawing.Color TextBlack50() => System.Drawing.Color.FromArgb(byte.MaxValue / 2, 0, 0, 0);
            public static System.Drawing.Color TextBody() => System.Drawing.Color.FromArgb(33, 37, 41);
            public static System.Drawing.Color TextDanger() => System.Drawing.Color.FromArgb(220, 53, 69);
            public static System.Drawing.Color TextDark() => System.Drawing.Color.FromArgb(52, 58, 64);
            public static System.Drawing.Color TextInfo() => System.Drawing.Color.FromArgb(23, 162, 184);
            public static System.Drawing.Color TextLight() => System.Drawing.Color.FromArgb(248, 249, 250);
            public static System.Drawing.Color TextMuted() => System.Drawing.Color.FromArgb(108, 117, 125);
            public static System.Drawing.Color TextPrimary() => System.Drawing.Color.FromArgb(0, 123, 255);
            public static System.Drawing.Color TextSecondary() => System.Drawing.Color.FromArgb(108, 117, 125);
            public static System.Drawing.Color TextSuccess() => System.Drawing.Color.FromArgb(40, 167, 69);
            public static System.Drawing.Color TextWarning() => System.Drawing.Color.FromArgb(255, 193, 7);
            public static System.Drawing.Color TextWhite() => System.Drawing.Color.FromArgb(255, 255, 255);
            public static System.Drawing.Color TextWhite50() => System.Drawing.Color.FromArgb(byte.MaxValue / 2, 0, 0, 0);
        }

        public static class Typography
        {

            /// <summary>
            /// Calculates the "EM" of a given font.
            /// </summary>
            /// <param name="font">The font to measure.</param>
            /// <returns>The width of the letter 'M' of a given font, in pixels.</returns>
            public static double CalculateEM(Font font)
            {
                if (font == null)
                {
                    throw new ArgumentNullException("Font cannot be null.");
                }

                return TextRenderer.MeasureText("M", font).Width;
            }

            /// <summary>
            /// Calculates the "EM" of a given control's font.
            /// </summary>
            /// <param name="control">The control who' font to measure.</param>
            /// <returns>The width of the letter 'M' of a given control's font, in pixels.</returns>
            public static double CalculateEM(System.Windows.Forms.Control control)
            {
                if (control == null)
                {
                    throw new ArgumentNullException("Control cannot be null.");
                }

                return TextRenderer.MeasureText("M", control.Font).Width;
            }

            /// <summary>
            /// Calculates the root "EM" of a given control's font.
            /// </summary>
            /// <param name="control">The control who' font to measure.</param>
            /// <returns>The width of the letter 'M' of a given control's form's font, in pixels.</returns>
            public static double CalculateREM(System.Windows.Forms.Control control)
            {
                if (control == null)
                {
                    throw new ArgumentNullException("Control cannot be null.");
                }
                Form rootElement = control.FindForm();
                if (rootElement == null)
                {
                    throw new ArgumentNullException("The form on which the control resides on cannot be null.");
                }

                return TextRenderer.MeasureText("M", rootElement.Font).Width;
            }

            /// <summary>
            /// Gets the unicode character for the dismiss/close icon
            /// </summary>
            /// <returns>String</returns>
            public static string Close() => Convert.ToChar(10005).ToString();

            /// <summary>
            /// Gets the default font that bootstrap uses based on the fonts that the current machine has
            /// </summary>
            /// <returns>Sans-Serif font at 16px</returns>
            public static Font Font() => new Font(Bootstrap.Utilities.Typography.FontStack().First(), 16, GraphicsUnit.Pixel);

            /// <summary>
            /// Gets the installed fonts on the current machine that bootstrap uses.
            /// </summary>
            /// <returns>Font array</returns>
            /// <remarks>For more information on font stacks, visit: https://www.smashingmagazine.com/2009/09/complete-guide-to-css-font-stacks/</remarks>
            public static FontFamily[] FontStack()
            {
                List<FontFamily> installedFamilies = new List<FontFamily>();
                InstalledFontCollection fontCollection = new InstalledFontCollection();

                if (fontCollection.Families.Any((family) => family.Name == "Segoe UI"))
                {
                    installedFamilies.Add(new FontFamily("Segoe UI"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Roboto"))
                {
                    installedFamilies.Add(new FontFamily("Roboto"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Helvetica Neue"))
                {
                    installedFamilies.Add(new FontFamily("Helvetica Neue"));
                }

                installedFamilies.Add(FontFamily.GenericSansSerif);

                return installedFamilies.ToArray();
            }

            /// <summary>
            /// Gets the default monospace font that bootstrap uses based on the fonts that the current machine has
            /// </summary>
            /// <returns>Monospace font at 16px</returns>
            public static Font Monospace() => new Font(Bootstrap.Utilities.Typography.MonospaceStack().First(), 16, GraphicsUnit.Pixel);

            /// <summary>
            /// Gets the installed fonts on the current machine that bootstrap uses for monospace fonts.
            /// </summary>
            /// <returns>Font array</returns>
            /// <remarks>For more information on font stacks, visit: https://www.smashingmagazine.com/2009/09/complete-guide-to-css-font-stacks/</remarks>
            public static FontFamily[] MonospaceStack()
            {
                List<FontFamily> installedFamilies = new List<FontFamily>();
                InstalledFontCollection fontCollection = new InstalledFontCollection();

                if (fontCollection.Families.Any((family) => family.Name == "SFMono-Regular"))
                {
                    installedFamilies.Add(new FontFamily("SFMono-Regular"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Menlo"))
                {
                    installedFamilies.Add(new FontFamily("Menlo"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Monaco"))
                {
                    installedFamilies.Add(new FontFamily("Monaco"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Consolas"))
                {
                    installedFamilies.Add(new FontFamily("Consolas"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Liberation Mono"))
                {
                    installedFamilies.Add(new FontFamily("Liberation Mono"));
                }
                if (fontCollection.Families.Any((family) => family.Name == "Courier New"))
                {
                    installedFamilies.Add(new FontFamily("Courier New"));
                }
                
                installedFamilies.Add(FontFamily.GenericMonospace);
                return installedFamilies.ToArray();
            }
        }
    }
}
