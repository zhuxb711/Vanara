﻿using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Vanara.Extensions;
using static Vanara.PInvoke.DbgHelp;
using static Vanara.PInvoke.ImageHlp;

namespace Vanara.PInvoke.Tests
{
	[TestFixture]
	public class DbgHelpTests
	{
		const string imgName = "imagehlp.dll";

		[OneTimeSetUp]
		public void _Setup()
		{
		}

		[OneTimeTearDown]
		public void _TearDown()
		{
		}

		[Test]
		public void EnumDirTreeTest()
		{
			var output = EnumDirTree(HPROCESS.NULL, Environment.GetFolderPath(Environment.SpecialFolder.Windows), imgName);
			Assert.That(output, Is.Not.Empty);
			TestContext.WriteLine($"Count: {output.Count}");
			output.WriteValues();
		}

		[Test]
		public void EnumerateLoadedModulesTest()
		{
			var output = EnumerateLoadedModules(Process.GetCurrentProcess().Handle);
			Assert.That(output, Is.Not.Empty);
			TestContext.WriteLine($"Count: {output.Count}");
			output.WriteValues();
		}

		[Test]
		public void EnumerateLoadedModulesExTest()
		{
			var output = EnumerateLoadedModulesEx(Process.GetCurrentProcess().Handle);
			Assert.That(output, Is.Not.Empty);
			TestContext.WriteLine($"Count: {output.Count}");
			output.WriteValues();
		}

		[Test]
		public void FindExecutableImageExTest()
		{
			Assert.That(FindExecutableImageEx(imgName, new[] { Environment.GetFolderPath(Environment.SpecialFolder.System), TestCaseSources.TempDir }), ResultIs.Not.Value(null));
		}

		[Test]
		public void GetImageConfigInformationTest()
		{
			Assert.That(MapAndLoad(imgName, null, out var LoadedImage, true, true), ResultIs.Successful);
			try
			{
				var data = ImageDirectoryEntryToData(LoadedImage.MappedAddress, false, IMAGE_DIRECTORY_ENTRY.IMAGE_DIRECTORY_ENTRY_EXPORT, out var cDirSize); // (_IMAGE_EXPORT_DIRECTORY*)
				Assert.That(data, ResultIs.ValidHandle);
				var ImageExportDirectory = data.ToStructure<IMAGE_EXPORT_DIRECTORY>(cDirSize);
				ImageExportDirectory.WriteValues();
				var addr = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, ImageExportDirectory.AddressOfNames, out _); // (uint*)
				Assert.That(addr, ResultIs.ValidHandle);
				foreach (var rva in addr.ToArray<uint>((int)ImageExportDirectory.NumberOfNames))
				{
					var sName = ImageRvaToVa(LoadedImage.FileHeader, LoadedImage.MappedAddress, rva, out _);
					TestContext.WriteLine(Marshal.PtrToStringAnsi(sName) ?? "(null)");
				}
			}
			finally
			{
				UnMapAndLoad(ref LoadedImage);
			}
		}
	}
}