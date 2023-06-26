﻿using System;
using System.Collections.Generic;

namespace WpfExamination.Models
{
    public partial class AirplaneClassFlight
    {
        public int ClassFlightId { get; set; }
        public int? ClassId { get; set; }
        public int? FlightId { get; set; }
        public long? SeatCost { get; set; }

        public virtual AirplanesClass? Class { get; set; }
        public virtual Flight? Flight { get; set; }
    }
}
