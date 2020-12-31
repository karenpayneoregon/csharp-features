using System.Collections.Generic;
using System.Drawing;

namespace WpfApplicationListViewImage.Classes
{
    public class SampleModel
    {
        public IEnumerable<ViewData> Items
        {
            get
            {
                yield return new ViewData(Properties.Resources.critical, "Critical");
                yield return new ViewData(Properties.Resources.Database, "Database");
                yield return new ViewData(Properties.Resources.Excel, "Excel");
                yield return new ViewData(Properties.Resources.csv, "CSV");
            }
        }
    }

    public class ViewData
    {
        public ViewData(Bitmap icon, string name)
        {
            _icon = icon;
            _name = name;
        }

        private readonly Bitmap _icon;
        public Bitmap Icon => _icon;

        private readonly string _name;
        public string Name => _name;
    }
}
