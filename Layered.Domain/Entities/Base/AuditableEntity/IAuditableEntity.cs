namespace Layered.Domain.Entities.Base.AuditableEntity;

public interface IAuditableEntity<T>
{
    T CreatedBy { get; set; }

    DateTime CreatedOn { get; set; }

    T UpdatedBy { get; set; }

    DateTime? UpdatedOn { get; set; }
}