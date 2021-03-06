﻿using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Linq;

namespace LinqBenchmarks.Enumerable.Int32
{
    [BenchmarkCategory("Enumerable", "Int32")]
    public class EnumerableInt32SkipTakeWhere: EnumerableInt32SkipTakeBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public int ForeachLoop()
        {
            using var enumerator = source.GetEnumerator();
            for (var index = 0; index < Skip; index++)
                _ = enumerator.MoveNext();
            var sum = 0;
            for (var index = 0; index < Count; index++)
            {
                var item = enumerator.Current;
                if (item.IsEven())
                    sum += item;
            }
            return sum;
        }

        [Benchmark]
        public int Linq()
        {
            var sum = 0;
            foreach (var item in source.Skip(Skip).Take(Count).Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int LinqAF()
        {
            var sum = 0;
            foreach (var item in global::LinqAF.IEnumerableExtensionMethods.Skip(source, Skip).Take(Count).Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var item in source
                .ToStructEnumerable()
                .Skip(Skip)
                .Take(Count)
                .Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int StructLinq_IFunction()
        {
            var sum = 0;
            var predicate = new Int32IsEven();
            foreach (var item in source
                .ToStructEnumerable()
                .Skip(Skip, x=> x)
                .Take(Count, x => x)
                .Where(ref predicate, x => x))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable()
                .Skip(Skip)
                .Take(Count)
                .Where(item => item.IsEven()))
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Hyperlinq_IFunction()
        {
            var sum = 0;
            foreach (var item in source.AsValueEnumerable()
                .Skip(Skip)
                .Take(Count)
                .Where<Int32IsEven>())
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Tinyield()
        {
            var sum = 0;
            Query.FromEnumerable(source)
                .Skip(Skip)
                .Limit(Count)
                .Filter(i => i.IsEven())
                .Traverse(item => sum += item);
            return sum;
        }
    }
}
