using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.IO;
using System.Threading;

namespace FileHelpers
{
	public class Operations
	{
		public delegate void OnException(Exception exception);
		public static event OnException OnExceptionEvent;
		public delegate void OnUnauthorizedAccessException(string message);
		public static event OnUnauthorizedAccessException UnauthorizedAccessExceptionEvent;
		public delegate void OnTraverseFolder(string status);
		public static event OnTraverseFolder OnTraverseEvent;
		public delegate void OnTraverseExcludeFolder(string sender);
		public static event OnTraverseExcludeFolder OnTraverseExcludeFolderEvent;
		public static bool Cancelled = false;


		public static async Task RecursiveFolders(DirectoryInfo directoryInfo, string[] excludeFileExtensions, CancellationToken ct)
		{

			if (!directoryInfo.Exists)
			{
				if (OnTraverseEvent != null)
                {
                    OnTraverseEvent("Nothing to process");
                }

                return;
			}

			if (!excludeFileExtensions.Any(directoryInfo.FullName.Contains))
			{
				await Task.Delay(1);
				if (OnTraverseEvent != null)
                {
                    OnTraverseEvent(directoryInfo.FullName);
                }
            }
			else
			{
				if (OnTraverseExcludeFolderEvent != null)
                {
                    OnTraverseExcludeFolderEvent(directoryInfo.FullName);
                }
            }

			DirectoryInfo folder = null;

			try
			{
				await Task.Run(async () =>
				{
							   foreach (DirectoryInfo dir in directoryInfo.EnumerateDirectories())
							   {

								   folder = dir;

								   if ((folder.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden || (folder.Attributes & FileAttributes.System) == FileAttributes.System || (folder.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
								   {

									   if (OnTraverseExcludeFolderEvent != null)
										   OnTraverseExcludeFolderEvent($"* {folder.FullName}");

									   continue;

								   }

								   if (!Cancelled)
								   {

									   await Task.Delay(1);
									   await RecursiveFolders(folder, excludeFileExtensions, ct);

								   }
								   else
								   {
									   return;
								   }

								   if (ct.IsCancellationRequested)
								   {
									   ct.ThrowIfCancellationRequested();
								   }

							   }
				});

			}
			catch (Exception ex)
			{
				if (ex is OperationCanceledException)
				{
					Cancelled = true;
				}
				else if (ex is UnauthorizedAccessException)
				{

					if (UnauthorizedAccessExceptionEvent != null)
                    {
                        UnauthorizedAccessExceptionEvent($"Access denied '{ex.Message}'");
                    }
                }
				else
				{

					if (OnExceptionEvent != null)
						OnExceptionEvent(ex);

				}
			}
		}

		public static void RecursiveFolders(string path, int indentLevel)
		{

			try
			{

				if ((File.GetAttributes(path) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
				{

					foreach (string folder in Directory.GetDirectories(path))
					{
						Debug.WriteLine($"{new string(' ', indentLevel)}{System.IO.Path.GetFileName(folder)}");
						RecursiveFolders(folder, indentLevel + 2);
					}

				}

			}
			catch (UnauthorizedAccessException unauthorized)
			{
				Debug.WriteLine($"{unauthorized.Message}");
			}
		}

	}

}