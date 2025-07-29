using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    public Color Color1 { get; set; } = Color.LightGreen;
    public Color Color2 { get; set; } = Color.DarkGreen;
    public float Angle { get; set; } = 45f;

    public GradientPanel()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color1, Color2, Angle))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}

