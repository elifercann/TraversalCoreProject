using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProject.CQRS.Commands.GuideCommands;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler : IRequestHandler<RemoveGuideCommand>
    {
        private readonly Context _context;

        public RemoveGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveGuideCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Guides.FindAsync(request.id);
            _context.Guides.Remove(value);
            _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
