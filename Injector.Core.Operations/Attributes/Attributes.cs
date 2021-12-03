using System;
using System.Collections.Generic;

namespace Injector.Core.Operator
{
    public class RootAttribute : Attribute
    {
        private string rootName;
        private List<string> threeStepNames = new List<string>();

        public RootAttribute() { }

        public RootAttribute(string rootName)
        {
            this.rootName = rootName;
        }

        public string GetRootName => rootName;

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
