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
    public partial class CCWJurisdictionController : Controller
    {
        private readonly ICCWJurisdictionService _service;

        /// <summary>
        /// Create a controller and set the service
        /// </summary>
        public CCWJurisdictionController(ICCWJurisdictionService service)
        {
            _service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <response code="201">CCWJurisdiction created</response>
        [HttpPost]
        [Route("/api/ccwjurisdictions/bulk")]
        [SwaggerOperation("CcwjurisdictionsBulkPost")]
        [RequiresPermission(Permission.ADMIN)]
        public virtual IActionResult CcwjurisdictionsBulkPost([FromBody]CCWJurisdiction[] items)
        {
            return this._service.CcwjurisdictionsBulkPostAsync(items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/ccwjurisdictions")]
        [SwaggerOperation("CcwjurisdictionsGet")]
        [SwaggerResponse(200, type: typeof(List<CCWJurisdiction>))]
        public virtual IActionResult CcwjurisdictionsGet()
        {
            return this._service.CcwjurisdictionsGetAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of CCWJurisdiction to delete</param>
        /// <response code="200">OK</response>
        /// <response code="404">CCWJurisdiction not found</response>
        [HttpPost]
        [Route("/api/ccwjurisdictions/{id}/delete")]
        [SwaggerOperation("CcwjurisdictionsIdDeletePost")]
        public virtual IActionResult CcwjurisdictionsIdDeletePost([FromRoute]int id)
        {
            return this._service.CcwjurisdictionsIdDeletePostAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of CCWJurisdiction to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">CCWJurisdiction not found</response>
        [HttpGet]
        [Route("/api/ccwjurisdictions/{id}")]
        [SwaggerOperation("CcwjurisdictionsIdGet")]
        [SwaggerResponse(200, type: typeof(CCWJurisdiction))]
        public virtual IActionResult CcwjurisdictionsIdGet([FromRoute]int id)
        {
            return this._service.CcwjurisdictionsIdGetAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of CCWJurisdiction to fetch</param>
        /// <param name="item"></param>
        /// <response code="200">OK</response>
        /// <response code="404">CCWJurisdiction not found</response>
        [HttpPut]
        [Route("/api/ccwjurisdictions/{id}")]
        [SwaggerOperation("CcwjurisdictionsIdPut")]
        [SwaggerResponse(200, type: typeof(CCWJurisdiction))]
        public virtual IActionResult CcwjurisdictionsIdPut([FromRoute]int id, [FromBody]CCWJurisdiction item)
        {
            return this._service.CcwjurisdictionsIdPutAsync(id, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <response code="201">CCWJurisdiction created</response>
        [HttpPost]
        [Route("/api/ccwjurisdictions")]
        [SwaggerOperation("CcwjurisdictionsPost")]
        [SwaggerResponse(200, type: typeof(CCWJurisdiction))]
        public virtual IActionResult CcwjurisdictionsPost([FromBody]CCWJurisdiction item)
        {
            return this._service.CcwjurisdictionsPostAsync(item);
        }
    }
}
