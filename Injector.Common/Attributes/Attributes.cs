using System;
using System.Collections.Generic;

namespace Injector.Common.Attributes
{
    public class RootAttribute : Attribute
    {
        private List<string> threeStepNames = new List<string>();

        public RootAttribute() { }

        public RootAttribute(string rootName)
        {
            GetRootName = rootName;
        }

        public string GetRootName { get; }

        public List<string> GetThreeStructure => threeStepNames;

        public void AddStepNameToThree(string stepName)
        {
            threeStepNames.Add(stepName);
        }
    }

    public class LeafAttribute : Attribute
    {
        private string rootFatherName;

        public LeafAttribute(string rootFatherName)
        {
            this.rootFatherName = rootFatherName;
        }

        public string GetRootFatherName => rootFatherName;
    }
}
