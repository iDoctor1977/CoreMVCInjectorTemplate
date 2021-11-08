namespace Injector.Common.IEntities
{
    public interface IEntityB : ISoftDelete
    {
        int Id { get; set; }
        string Username { get; set; }
        string Email { get; set; }
    }
}