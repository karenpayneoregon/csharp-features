using Async_Enumerables.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Enumerables
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            Helpers.OnIterateEvent += Helpers_OnIterateEvent;
        }

        /// <summary>
        /// Show current progress
        /// </summary>
        /// <param name="sender"></param>
        private void Helpers_OnIterateEvent(int sender)
        {
            BasicExampleLabel.Text = $@"current: {sender:D4}";
        }

        /// <summary>
        /// Start basic example
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasicExampleStartButton_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            try
            {
                await Helpers.RunBasicExample(_cancellationTokenSource.Token);
            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show(@"Operation cancelled");
            }
            
        }
        /// <summary>
        /// Cancel basic example
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasicExampleCancelButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
