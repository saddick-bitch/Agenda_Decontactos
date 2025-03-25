using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    // Clase base para entidades con identificador único
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
    }
