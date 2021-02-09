using System;

namespace Captura.Models
{
    public class DatetimeOverlay : TextOverlay
    {
        readonly Func<DateTime> _datetime;

        public DatetimeOverlay(TextOverlaySettings OverlaySettings, Func<DateTime> Datetime) : base(OverlaySettings)
        {
            _datetime = Datetime;
        }

        protected override string GetText() => _datetime().ToString("yyyy/MM/dd HH:mm:ss");
    }
}
