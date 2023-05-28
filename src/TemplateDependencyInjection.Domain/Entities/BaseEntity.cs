namespace TemplateDependencyInjection.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual DateTime? Updated { get; set; }
        public virtual void CreateDate() { Created = DateTime.UtcNow; }
        public virtual void UpdateDate() { Updated = DateTime.UtcNow; }
    }
}
