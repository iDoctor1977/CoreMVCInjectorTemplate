using System.Collections.Generic;
using Injector.Data.Entities;

namespace Injector.Data.Builders
{
    public class EntityBuilder : IEntityBuilder, IEntityAdded
    {
        private ICollection<Entity> _entitiesA;
        private int _id;

        public EntityBuilder() {
            _entitiesA = new List<Entity>();
        }

        private Entity CreateIndicis(string name)
        {
            var entityA = new Entity
            {
                Id = _id,
                Name = name,
            };

            _id++;

            return entityA;
        }

        private Entity CreateIndicis(string name, string surname)
        {
            var entityA = CreateIndicis(name);
            entityA.Surname = name;

            return entityA;
        }

        public IEntityAdded AddEntity(string name)
        {
            var indicis = CreateIndicis(name);
            _entitiesA.Add(indicis);

            return this;
        }

        public IEntityAdded AddEntity(string name, string surname)
        {
            var indicis = CreateIndicis(name, surname);
            _entitiesA.Add(indicis);

            return this;
        }

        public IEnumerable<Entity> Build()
        {
            var result = _entitiesA;
            _entitiesA = null;
            _id = 0;

            return result;
        }
    }

    public interface IEntityBuilder
    {
        IEntityAdded AddEntity(string name);
        IEntityAdded AddEntity(string name, string surname);
    }

    public interface IEntityAdded : IEntityBuilder
    {
        IEnumerable<Entity> Build();
    }
}
