﻿// <Snippet1>

using System;
using System.Reflection;

class Program4
{
    // Methods to get:

    public void MethodA(int i, int j) { }

    public void MethodA(int[] i) { }

    public unsafe void MethodA(int* i) { }

    public void MethodA(ref int r) {}

    // Method that takes an out parameter:
    public void MethodA(int i, out int o) { o = 100;}

  static void Main(string[] args)
  {
    MethodInfo mInfo;

    // Get MethodA(int i, int i)
    mInfo = typeof(Program).GetMethod("MethodA",
        new Type[] { typeof(int), typeof(int) });
    Console.WriteLine("Found method: {0}", mInfo);

    // Get MethodA(int[] i)
    mInfo = typeof(Program).GetMethod("MethodA",
        new Type[] { typeof(int[]) });
    Console.WriteLine("Found method: {0}", mInfo);

    // Get MethodA(int* i)
    mInfo = typeof(Program).GetMethod("MethodA",
        new Type[] { typeof(int).MakePointerType() });
    Console.WriteLine("Found method: {0}", mInfo);

    // Get MethodA(ref int r)
    mInfo = typeof(Program).GetMethod("MethodA",
        new Type[] { typeof(int).MakeByRefType() });
    Console.WriteLine("Found method: {0}", mInfo);

    // Get MethodA(int i, out int o)
    mInfo = typeof(Program).GetMethod("MethodA",
        new Type[] { typeof(int), typeof(int).MakeByRefType() });
    Console.WriteLine("Found method: {0}", mInfo);
  }
}
// </Snippet1>
