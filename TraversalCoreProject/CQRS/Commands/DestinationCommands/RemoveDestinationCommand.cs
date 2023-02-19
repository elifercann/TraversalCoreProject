using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int id { get; set; }

        public RemoveDestinationCommand(int id)
        {
            this.id = id;
        }
    }
}
