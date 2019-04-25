﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Marvin.Tests.Serialization;

namespace Marvin.Tests
{
    public class DummyClass
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public int ReadOnly => 10;

        public SubClass SingleClass { get; set; }

        public SubClass[] SubArray { get; set; }

        public List<SubClass> SubList { get; set; }

        public IEnumerable<SubClass> SubEnumerable { get; set; }

        public IDictionary<int, SubClass> SubDictionary { get; set; }

        public DummyEnum[] EnumArray { get; set; }

        public List<DummyEnum> EnumList { get; set; }

        public IEnumerable<DummyEnum> EnumEnumerable { get; set; }

        public bool[] BoolArray { get; set; }

        public List<bool> BoolList { get; set; }

        public IEnumerable<DummyEnum> BoolEnumerable { get; set; }

        public SubClass SingleClassNonLocalized { get; set; }
    }

    public class SubClass
    {
        public float Foo { get; set; }

        public DummyEnum Enum { get; set; }

        public DummyEnum[] EnumArray { get; set; }
    }

    public enum DummyEnum
    {
        Unset,
        ValueA,
        ValueB
    }
}