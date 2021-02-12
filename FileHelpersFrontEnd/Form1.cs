using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FileHelpers;

namespace FileHelpersFrontEnd
{
    public partial class Form1 : Form
    {
        
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        
        public Form1()
        {
            InitializeComponent();
            
            Operations.OnTraverseEvent += OperationsOnOnTraverseEvent;
        }

        private void OperationsOnOnTraverseEvent(string status)
        {
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
            }

            var directoryInfo = new DirectoryInfo("C:\\OED\\Dotnetland\\VS2019\\csharp-tips");
            
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
