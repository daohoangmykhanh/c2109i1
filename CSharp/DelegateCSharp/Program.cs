using DelegateCSharp;

Mathems ma = new();
ma.Add(10,5);

Abc dele = new Mathems().Mul;
dele += new Mathems().Sub;
dele(10, 5);

