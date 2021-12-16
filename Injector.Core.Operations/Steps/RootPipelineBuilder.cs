using System;
using System.Collections.Generic;
using Injector.Core.Operator.Attributes;

namespace Injector.Core.Operator.Steps
{
    public abstract class RootPipelineBuilder<I, O> : IRootStep<I, O>, IBuildStep<I, O>
    {
        private readonly RootAttribute _localAttribute;
        private readonly List<ISubStep<I, O>> _root;
        private object _stepInput;

        public RootPipelineBuilder()
        {
            _localAttribute = (RootAttribute)Attribute.GetCustomAttribute(GetType(), typeof(RootAttribute));
            _root = new List<ISubStep<I, O>>();
        }

        public List<ISubStep<I, O>> Steps => _root;

        public RootAttribute GetRootOfStepsMap => _localAttribute;

        public IBuildStep<I, O> AddStep(ISubStep<I, O> newStep)
        {
            LeafAttribute leaf = (LeafAttribute)Attribute.GetCustomAttribute(newStep.GetType(), typeof(LeafAttribute));
            RootAttribute root = (RootAttribute)Attribute.GetCustomAttribute(newStep.GetType(), typeof(RootAttribute));
            
            if (root != null || (leaf != null && leaf.GetRootFatherName.Equals(GetType().Name)))
            {
                _localAttribute.AddStepNameToThree(newStep.GetType().Name);

                _root.Add(newStep);
                return this;
            }

            throw new Exception(newStep.GetType().Name + " it doesn't belong to the root " + GetType().Name + " or attribute was not found.");
        }

        public List<ISubStep<I, O>> Build()
        {
            return _root;
        }

        protected abstract O ExecuteRootStep(I value);

        public O Execute(I value)
        {
            _stepInput = ExecuteRootStep(value);

            if (_root.Count != 0)
            {
                foreach (var step in _root)
                {
                    _stepInput = step.Execute((I)_stepInput);
                }
            }

            return (O)_stepInput;
        }
    }

    public interface IRootStep<I, O> : ISubStep<I, O>
    {
        IBuildStep<I, O> AddStep(ISubStep<I, O> newStep);
        List<ISubStep<I, O>> Build();
    }

    public interface IBuildStep<I, O> : IRootStep<I, O> { }

    public interface ISubStep<I, O>
    {
        O Execute(I value);
    }
}