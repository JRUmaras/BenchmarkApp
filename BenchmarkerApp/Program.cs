// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkerApp;

Console.WriteLine("Hello, World!");

var result = BenchmarkRunner.Run<Demo>();