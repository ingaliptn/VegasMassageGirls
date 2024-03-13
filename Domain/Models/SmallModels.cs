using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class BoolString
    {
        public bool Flag { get; set; }
        public string Value { get; set; }
    }
    public class NumberString
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
    public class BoolInt
    {
        public bool Flag { get; set; }
        public int Value { get; set; }
    }
    public class String2
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
    public class String3
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
    }
    public class BoolListString
    {
        public bool Flag { get; set; }
        public string Json { get; set; }
        public List<string> List { get; set; } = new List<string>();
    }

    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Number2
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
    }
}
