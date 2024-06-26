﻿using RailwayReservation.Model.Dtos.Train.Route;
using RailwayReservation.Model.Dtos.Train.Seat;
using RailwayReservation.Model.Enum.Train;
using System;
using System.Collections.Generic;

namespace RailwayReservation.Model.Dtos.Train
{
    public class TrainResponseDto
    {
        public Guid TrainId { get; set; }
        public string TrainName { get; set; }
        public int TrainNumber { get; set; }
        public TrainType TrainType { get; set; }
        public TrainStatus TrainStatus { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public int Fare { get; set; }
        public RouteResponseDto TrainRoute { get; set; }
        public ICollection<SeatResponseDto> Seats { get; set; }
    }
}
