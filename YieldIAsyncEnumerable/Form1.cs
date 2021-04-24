﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YieldIAsyncEnumerable.Classes;

/*
 * IAsyncEnumerable<T> Interface
 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1?view=net-5.0
 * Exposes an enumerator that provides asynchronous iteration over values of a specified type.
 *
 * - Roughly done yet all works.
 * - Requires script in the script folder to run for SQL-Server
 */

namespace YieldIAsyncEnumerable
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationSource = new();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Start1Button_Click(object sender, EventArgs e)
        {
            if (_cancellationSource.IsCancellationRequested)
            {
                _cancellationSource.Dispose();
                _cancellationSource = new CancellationTokenSource();
            }

            listBox1.Items.Clear();

            try
            {
                await foreach (var item in 10.RangeAsync(GlobalStuff.MaxNumber, _cancellationSource.Token).WithCancellation(_cancellationSource.Token))
                {
                    listBox1.Items.Add(item);
                };
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operation cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        /// <summary>
        /// Cancel above operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel1Button_Click(object sender, EventArgs e)
        {
            _cancellationSource.Cancel();
        }
        
        private async void RangeAsyncButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            await foreach (var item in Helper.RangeAsync(3, GlobalStuff.MaxNumber))
            {
                listBox1.Items.Add(item); 
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private async void IterateContactNamesButton_Click(object sender, EventArgs e)
        {
            await IterateContactNames();
        }
        public async Task IterateContactNames()
        {
            await foreach (var name in DataOperations.GetAllNames(true))
            {
                listBox2.InvokeIfRequired(lb => { listBox2.Items.Add(name);});
            }
        }
    }
}
