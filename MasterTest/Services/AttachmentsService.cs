using MasterTest.Data;
using MasterTest.Interfaces;
using MasterTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterTest.Services
{
    public class AttachmentsService : RepositoryService<Attachments, KodruContext>, IAttachments
    {
        public AttachmentsService(KodruContext db) : base(db)
        {
        }
    }
}
