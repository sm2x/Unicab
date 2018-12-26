﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Unicab.Api.Models
{
    public class CabRequest
    {
        public int CabRequestId { get; set; }

        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public int PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }

        public int DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }

        public DateTime PickUpDateTime { get; set; }

        public int NoOfPassengers { get; set; }

        public bool IsLadiesOnly { get; set; }

        public string AdditionalNotes { get; set; }

        public int RequestPeriod { get; set; }

        public DateTime AddedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public bool IsAccepted { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public bool DriverHasCompleted { get; set; }
        public DateTime DriverCompletedDateTime { get; set; }

        public bool PassengerHasCompleted { get; set; }
        public DateTime PassengerCompletedDateTime { get; set; }

        public double DistanceTravelled { get; set; }
        public double FareCharge { get; set; }
        public bool IsFarePaid { get; set; }

        public bool DriverHasCancelled { get; set; }
        public DateTime DriverCancelledDateTime { get; set; }

        public bool PassengerHasCancelled { get; set; }
        public DateTime PassengerCancelledDateTime { get; set; }
    }
}
