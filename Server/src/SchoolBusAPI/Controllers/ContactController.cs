/*
 * REST API Documentation for the MOTI School Bus Application
 *
 * The School Bus application tracks that inspections are performed in a timely fashion. For each school bus the application tracks information about the bus (including data from ICBC, NSC, etc.), it's past and next inspection dates and results, contacts, and the inspector responsible for next inspecting the bus.
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using SchoolBusAPI.Models;
using SchoolBusAPI.ViewModels;
using SchoolBusAPI.Services;
using SchoolBusAPI.Authorization;

namespace SchoolBusAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ContactController : Controller
    {
        private readonly IContactService _service;

        /// <summary>
        /// Create a controller and set the service
        /// </summary>
        public ContactController(IContactService service)
        {
            _service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <response code="201">Contact created</response>
        [HttpPost]
        [Route("/api/contacts/bulk")]
        [SwaggerOperation("ContactsBulkPost")]
        [RequiresPermission(Permission.ADMIN)]
        public virtual IActionResult ContactsBulkPost([FromBody]Contact[] items)
        {
            return this._service.ContactsBulkPostAsync(items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/contacts")]
        [SwaggerOperation("ContactsGet")]
        [SwaggerResponse(200, type: typeof(List<Contact>))]
        public virtual IActionResult ContactsGet()
        {
            return this._service.ContactsGetAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Contact to delete</param>
        /// <response code="200">OK</response>
        /// <response code="404">Contact not found</response>
        [HttpPost]
        [Route("/api/contacts/{id}/delete")]
        [SwaggerOperation("ContactsIdDeletePost")]
        public virtual IActionResult ContactsIdDeletePost([FromRoute]int id)
        {
            return this._service.ContactsIdDeletePostAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Contact to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">Contact not found</response>
        [HttpGet]
        [Route("/api/contacts/{id}")]
        [SwaggerOperation("ContactsIdGet")]
        [SwaggerResponse(200, type: typeof(Contact))]
        public virtual IActionResult ContactsIdGet([FromRoute]int id)
        {
            return this._service.ContactsIdGetAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Contact to fetch</param>
        /// <param name="item"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Contact not found</response>
        [HttpPut]
        [Route("/api/contacts/{id}")]
        [SwaggerOperation("ContactsIdPut")]
        [SwaggerResponse(200, type: typeof(Contact))]
        public virtual IActionResult ContactsIdPut([FromRoute]int id, [FromBody]Contact item)
        {
            return this._service.ContactsIdPutAsync(id, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <response code="201">Contact created</response>
        [HttpPost]
        [Route("/api/contacts")]
        [SwaggerOperation("ContactsPost")]
        [SwaggerResponse(200, type: typeof(Contact))]
        public virtual IActionResult ContactsPost([FromBody]Contact item)
        {
            return this._service.ContactsPostAsync(item);
        }
    }
}
