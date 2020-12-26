﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WpfApplication1
{
    public class SampleModel
    {
        public IEnumerable<ViewData> Items
        {
            get
            {
                yield return new ViewData(Properties.Resources.critical, "item 1");
                yield return new ViewData(Properties.Resources.Database, "item 2");
                yield return new ViewData(Properties.Resources.Excel, "item 3");
                yield return new ViewData(Properties.Resources.csv, "item 4");
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
