﻿using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Every
{
    public class EveryBench : BenchmarkBase
    {
        public List<Value> lstA;
        public List<Value> lstB;

        [GlobalSetup]
        public void GlobalSetup()
        {
            lstB = new List<Value>(Count);
            lstA = System.Linq.Enumerable
                .Range(1, Count)
                .Select(v => new Value(v))
                .ToList();
            lstA.ForEach(v => lstB.Add(v));
        }

        [Benchmark(Baseline = true)]
        public bool ForeachLoop()
        {
            IEnumerator<Value> iterB = lstB.GetEnumerator();
            foreach (Value a in lstA)
            {
                if (!iterB.MoveNext()) return false;
                if (!a.Equals(iterB.Current)) return false;
            }
            return true;
        }

        bool TRUE = true;

        [Benchmark]
        public bool Linq()
        {
            return lstA
                .Zip(lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool LinqAF()
        {
            return global::LinqAF.IEnumerableExtensionMethods.Zip(lstA, lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool HyperLinq()
        {
            return lstA.AsValueEnumerable()
                .Select<Value, Value>(v => v)
                .Zip(lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool Tinyield()
        {
            Query<Value> b = Query.FromEnumerable(lstB);
            return Query
                .FromEnumerable(lstA)
                .Zip(b, (a, b) => a.Equals(b))
                .AllMatch(TRUE.Equals);
        }
    }
}
