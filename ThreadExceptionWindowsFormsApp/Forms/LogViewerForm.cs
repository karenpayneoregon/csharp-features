using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ExceptionHandling;
using ExceptionHandling.Interfaces;
using ThreadExceptionWindowsFormsApp.LanguageExtensions;

namespace ThreadExceptionWindowsFormsApp.Forms
{
    public partial class LogViewerForm : Form
    {
        public LogViewerForm()
        {
            InitializeComponent();
            
            Shown += OnShown;
            LogListView.ItemSelectionChanged += LogListViewOnItemSelectionChanged;
        }

        /// <summary>
        /// On selecting an item display exception stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogListViewOnItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            
            if (e.Item.Tag is List<string>)
            {
                textBox1.Lines = e.Item.LineTag();
            }
        }
        /// <summary>
        /// Load unhandled exception file if exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object sender, EventArgs e)
        {
            static void SetItemFount(ListViewItem current)
            {
                current.SubItems[0].Font = new Font(
                    current.SubItems[0].Font.FontFamily,
                    current.SubItems[0].Font.Size, FontStyle.Bold);
            }

            var itemsContainers = LogReader.Read();

            foreach (var container in itemsContainers)
            {
                var current = new ListViewItem(container.ItemArray) {Tag = container.Lines, UseItemStyleForSubItems = false};

                /*
                 * Set style for log level column
                 */
                switch (container.LoggerEntry.LogLevel)
                {
                    case LogLevel.Critical:
                        current.SubItems[0].ForeColor = Color.Red;
                        SetItemFount(current);
                        break;
                    case LogLevel.Error:
                        current.SubItems[0].ForeColor = Color.Crimson;
                        SetItemFount(current);
                        break;
                    case LogLevel.Warning:
                        current.SubItems[0].ForeColor = Color.DarkOrange;
                        SetItemFount(current);
                        break;
                    case LogLevel.General:
                        current.SubItems[0].ForeColor = Color.Lime;
                        SetItemFount(current);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                LogListView.Items.Add(current);
            }

            LogListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
            ActiveControl = LogListView;
            
        }

    }
}
