using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int Id { get; set; }

        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }
    }
}
