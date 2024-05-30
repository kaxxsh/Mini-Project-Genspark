﻿using RailwayReservation.Model.Domain;
using RailwayReservation.Model.Dtos.Auth.User;

namespace RailwayReservation.Interface.Service
{
    public interface IUserService
    {
        public Task<User> AddMoney(Guid id,double Amount);
        public Task<List<UserResponseDto>> GetAll();
        public Task<UserResponseDto> GetById(Guid id);
    }
}
