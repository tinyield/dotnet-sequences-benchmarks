﻿using BenchmarkDotNet.Attributes;
using com.tinyield;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Array.ValueType 
{
    public partial class ArrayValueTypeWhereSelectToList: ValueTypeArrayBenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public List<FatValueType> ForLoop()
        {
            var list = new List<FatValueType>();
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                ref readonly var item = ref array[index];
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list;
        }

        [Benchmark]
        public List<FatValueType> ForeachLoop()
        {
            var list = new List<FatValueType>();
            foreach (var item in source)
            {
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list;
        }

        [Benchmark]
        public List<FatValueType> Linq()
            => System.Linq.Enumerable
                .Where(source, item => item.IsEven()).Select(item => item * 2)
                .ToList();

        [Benchmark]
        public List<FatValueType> LinqFaster()
            => new List<FatValueType>(source
                .WhereSelectF(item => item.IsEven(), item => item * 2));

        [Benchmark]
        public List<FatValueType> LinqAF()
            => global::LinqAF.ArrayExtensionMethods.Where(source, item => item.IsEven()).Select(item => item * 2).ToList();

        [Benchmark]
        public List<FatValueType> StructLinq()
            => source
                .ToRefStructEnumerable()
                .Where((in FatValueType item) => item.IsEven())
                .Select((in FatValueType item) => item * 2)
                .ToList();

        [Benchmark]
        public List<FatValueType> StructLinq_IFunction()
        {
            var predicate = new FatValueTypeIsEven();
            var selector = new DoubleOfFatValueType();
            return source.ToRefStructEnumerable()
                .Where(ref predicate, x => x)
                .Select(ref selector, x => x, x => x)
                .ToList(x => x);
        }

        [Benchmark]
        public List<FatValueType> Hyperlinq()
            => source.AsValueEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToList();

        [Benchmark]
        public List<FatValueType> Hyperlinq_IFunction()
            => source.AsValueEnumerable()
                .Where<FatValueTypeIsEven>()
                .Select<FatValueType, DoubleOfFatValueType>()
                .ToList();

        [Benchmark]
        public IList<FatValueType> Tinyield() => Query.Of(source)
                .Filter(i => i.IsEven())
                .Map(i => i * 2)
                .ToList();
    }
}
