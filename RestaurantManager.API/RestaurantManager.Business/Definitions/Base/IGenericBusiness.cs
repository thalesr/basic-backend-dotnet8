﻿using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Business.Definitions.Base
{
    public interface IGenericBusiness<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Save(T obj);
        Task Delete(int id);
    }
}
