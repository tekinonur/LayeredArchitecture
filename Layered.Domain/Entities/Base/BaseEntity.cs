namespace Layered.Domain.Entities.Base;

public abstract class BaseEntity<T>
{
    public virtual T ID { get; set; }
}