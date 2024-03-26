namespace App.Domain.Common {
    public abstract class Entity {
        public Guid Id { get; init; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }


        public Entity(Guid? Id = null) {
            if (Id != null) {
                this.Id = Id.Value;
            } else {
                this.Id = Guid.NewGuid();
            }
            CreatedAt = DateTimeOffset.UtcNow;
            UpdatedAt = DateTimeOffset.UtcNow;
        }
    }
}