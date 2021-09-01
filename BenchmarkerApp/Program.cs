// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkerApp;
using System;

Console.WriteLine("Hello, World!");

var result = BenchmarkRunner.Run<Demo>();