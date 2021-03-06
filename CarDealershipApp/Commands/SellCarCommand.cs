﻿using CarDealershipApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealershipApp.Commands
{
    public class SellCarCommand : CarCommand
    {
        public SellCarCommand(CarRepository carRepository) : base(carRepository) { }

        public override string CommandText()
        {
            return "sell car";
        }

        public override CommandResult Execute()
        {
            return new CommandResult(true, "Car sold successfully");
        }
    }
}
