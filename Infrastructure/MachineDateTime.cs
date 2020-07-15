using FoodLog.Domain.Interfaces;
using System;

namespace FoodLog.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}
