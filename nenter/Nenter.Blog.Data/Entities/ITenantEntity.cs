﻿namespace Nenter.Blog.Data.Entities
{
    public interface ITenantEntity<T> : IEntity<T>
    {
        int TenantId { get; set; }
    }
}