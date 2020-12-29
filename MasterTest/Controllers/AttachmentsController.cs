using MasterTest.Interfaces;
using MasterTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentsController : KodruController<Attachments, IAttachments>
    {
        public AttachmentsController(IAttachments repository) : base(repository)
        {
        }
    }
}
