﻿using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly ApplicationContext _context;

        public ProductRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public Task<Products> CreateProduct(Products product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationSet<Products>> GetListProduct(string? keyword, int page_number, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetProductbyId(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Products> ProductModify(Products product)
        {
            throw new NotImplementedException();
        }
    }
}