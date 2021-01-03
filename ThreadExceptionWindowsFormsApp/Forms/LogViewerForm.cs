using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExceptionHandling;
using ExceptionHandling.Interfaces;
using Microsoft.VisualBasic.Logging;
using ThreadExceptionWindowsFormsApp.LanguageExtensions;
using static ThreadExceptionWindowsFormsApp.Helpers.Dialogs;

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

            LogListView.BeginUpdate();
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
                        current.SubItems[0].ForeColor = Color.Yellow;
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
            LogListView.EndUpdate();
            
            ActiveControl = LogListView;
            
        }
        /// <summary>
        /// Copy current selected row to windows clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (LogListView.SelectedItems.Count != 1) return;

            if (!Question("Copy to clipboard?")) return;
            
            var current = string.Concat(
                LogListView.SelectedItems[0].ExceptionDetails(), 
                "\n", 
                LogListView.SelectedItems[0].LineTag().AsString());
            
            Clipboard.SetText(current);

        }
    }
}
