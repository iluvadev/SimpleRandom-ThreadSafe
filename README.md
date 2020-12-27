# SimpleThreadSafeRandom
Some simple functions in C# to work with Random numbers in a thread-safe way

Inspired by: https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/

*Not tested yet*

***Get a Random number***
```csharp
n1 = Rnd.Next.Double();  // n1: double 
n2 = Rnd.Next.Decimal(); // n2: decimal

n3 = Rnd.Next.Byte();    // n3: byte
n4 = Rnd.Next.Int16();   // n4: short (Int16)
n5 = Rnd.Next.Int32();   // n5: int (Int32)
n6 = Rnd.Next.Int64();   // n6: long (Int64)

n7 = Rnd.Next.Boolean(); // n7: bool
```

***Get a Random Number between 2 values***
```csharp
n1 = Rnd.Next.Double(n1Min, n1Max);  // n1, n1Min, n1Max: double
n2 = Rnd.Next.Decimal(n2Min, n2Max); // n2, n2Min, n2Max: decimal

n3 = Rnd.Next.Byte(n3Min, n3Max);    // n3, n3Min, n3Max: byte
n4 = Rnd.Next.Int16(n4Min, n4Max);   // n4, n4Min, n4Max: short (Int16)
n5 = Rnd.Next.Int32(n5Min, n5Max);   // n5, n5Min, n5Max: int (Int32)
n6 = Rnd.Next.Int64(n6Min, n6Max);   // n6, n6Min, n6Max: long (Int64)
```
or
```csharp
n1 = Rnd.Between(n1Min, n1Max); // n1, n1Min, n1Max: double
n2 = Rnd.Between(n2Min, n2Max); // n2, n2Min, n2Max: decimal

n3 = Rnd.Between(n3Min, n3Max); // n3, n3Min, n3Max: byte
n4 = Rnd.Between(n4Min, n4Max); // n4, n4Min, n4Max: short (Int16)
n5 = Rnd.Between(n5Min, n5Max); // n5, n5Min, n5Max: int (Int32)
n6 = Rnd.Between(n6Min, n6Max); // n6, n6Min, n6Max: long (Int64)
```

***Get a Random Number Less than other***
```csharp
n1 = Rnd.Next.Double(n1Max);  // n1, n1Max: double
n2 = Rnd.Next.Decimal(n2Max); // n2, n2Max: decimal

n3 = Rnd.Next.Byte(n3Max);    // n3, n3Max: byte
n4 = Rnd.Next.Int16(n4Max);   // n4, n4Max: short (Int16)
n5 = Rnd.Next.Int32(n5Max);   // n5, n5Max: int (Int32)
n6 = Rnd.Next.Int64(n6Max);   // n6, n6Max: long (Int64)
```

***Get a Random Item from IEnumerable, params or Enum***
```csharp
item1 = Rnd.Next.From(myEnumerable);
item2 = Rnd.Next.From(1, 2, 3, 4, 5, 6, 7, 8);
item3 = Rnd.Next.From<MyEnum>();
```
Or
```csharp
item1 = Rnd.From(myEnumerable);
item2 = Rnd.From(1, 2, 3, 4, 5, 6, 7, 8);
item3 = Rnd.From<MyEnum>();
```
