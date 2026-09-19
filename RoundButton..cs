//ساخت یک کلید دایره ای
public class RoundButton : Button
{
    public RoundButton()
    {
        // برای جلوگیری از پرش تصویر
        SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer, true);

        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.DodgerBlue;
        ForeColor = Color.White;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateRegion();
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        using (var path = new GraphicsPath())
        {
            // دایره کامل داخل کنترل
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }
    }
}
