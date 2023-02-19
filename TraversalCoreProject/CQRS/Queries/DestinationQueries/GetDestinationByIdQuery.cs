using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public int id { get; set; }

        public GetDestinationByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
