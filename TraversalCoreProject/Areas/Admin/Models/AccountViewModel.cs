using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderId { get; set; }
        public int ReceiveId { get; set; }
        public decimal Amount { get; set; }
    }
}
