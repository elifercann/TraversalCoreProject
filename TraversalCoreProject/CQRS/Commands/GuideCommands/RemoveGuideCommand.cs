using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Commands.GuideCommands
{
    public class RemoveGuideCommand : IRequest
    {
        public int id { get; set; }

        public RemoveGuideCommand(int id)
        {
            this.id = id;
        }
    }
}
