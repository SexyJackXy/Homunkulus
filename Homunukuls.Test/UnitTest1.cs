using System;
using System.Threading;
using System.Windows.Automation;
using Microsoft.Test.Input;
using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace Homunukuls.Test
{
    public class Tests
    {
        Process appProcess;
        string path = @"C:\Users\Tim\Documents\GitHub\Homunkulus\Homunkulus\bin\Debug\net6.0-windows\Homunkulus.exe";
        [SetUp]
        public void Setup()
        {
            appProcess = Process.Start(path);
        }

        [TearDown]
        public void TearDown()
        {
            appProcess.Kill();
        }

        [Test]
        public void Test1()
        {
            AutomationElement


            Assert.Pass();
        }
    }
}