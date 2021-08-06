using System;
using System.Diagnostics;
using System.IO;

using System.Text;
using System.Threading;
using System.Windows.Forms;
using FileHelpers;

namespace FileHelpersFrontEnd
{
    public partial class Form1 : Form
    {


        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private string _folderName = "C:\\OED\\Dotnetland\\VS2019\\csharp-tips";


        public Form1()
        {
            InitializeComponent();
            ResultsLabel.Text = "";
            Shown += OnShown;
            Operations.OnTraverseEvent += OperationsOnOnTraverseEvent;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            if (!Directory.Exists(_folderName))
            {
                RunButton.Enabled = false;
                MessageBox.Show("Folder does not exists");
            }
        }

        private void OperationsOnOnTraverseEvent(string status)
        {
            if (status.Contains("C:\\OED\\Dotnetland\\VS2019\\csharp-tips\\ClearControlsWindowsForms"))
            {
                listBox1.InvokeIfRequired(listbox =>
                {
                    listbox.Items.Add(status);
                    //listbox.Refresh();
                });
            }
            ResultsLabel.InvokeIfRequired(label =>
            {
                label.Text = status;
                label.Refresh();
            });

        }

        private async void RunButton_Click(object sender, EventArgs e)
        {

            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
                Operations.Cancelled = false;
                
                listBox1.Items.Clear();
            }

            var directoryInfo = new DirectoryInfo(_folderName);
            
            try
            {
                await Operations.RecursiveFolders(
                    directoryInfo, 
                    new[] { "*.txt" }, 
                    _cancellationTokenSource.Token);
                
                if (Operations.Cancelled)
                {
                    MessageBox.Show(@"You cancelled the operation");
                }
                else
                {
                    MessageBox.Show(@"Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();

        }
    }
}
