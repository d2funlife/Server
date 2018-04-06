/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using DotNetRu.MeetupManagement.WebApi.Contract.Attributes;
using DotNetRu.MeetupManagement.WebApi.Contract.Models;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public abstract class FriendApiController : ControllerBase
    { 
        /// <summary>
        /// Create friend draft
        /// </summary>
        /// <remarks>Create new friend draft.</remarks>
        /// <param name="body"></param>
        /// <response code="201">Draft was sucessfully created</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Draft is already exists</response>
        [HttpPost]
        [Route("/friends/draft")]
        [ValidateModelState]
        [SwaggerOperation("CreateFriendDraft")]
        public abstract void CreateFriendDraft([FromBody]CreateFriendDraftParameters body);

        /// <summary>
        /// Delete friend draft
        /// </summary>
        
        /// <param name="friendId"></param>
        /// <response code="204">Draft was successfuly deleted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Speaker not found</response>
        [HttpDelete]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("DeleteFriendDraft")]
        public abstract void DeleteFriendDraft([FromRoute][Required]string friendId);

        /// <summary>
        /// Get friend draft
        /// </summary>
        /// <remarks>Get friend draft</remarks>
        /// <param name="friendId"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Friend not found</response>
        [HttpGet]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("GetFriendDraft")]
        [SwaggerResponse(statusCode: 200, type: typeof(FriendDraft), description: "OK")]
        public abstract FriendDraft GetFriendDraft([FromRoute][Required]string friendId);

        /// <summary>
        /// Update friend draft
        /// </summary>
        
        /// <param name="friendId"></param>
        /// <param name="body"></param>
        /// <response code="204">Draft was successfuly updated</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Friend not found</response>
        [HttpPut]
        [Route("/friends/{friendId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("UpdateFriendDraft")]
        public abstract void UpdateFriendDraft([FromRoute][Required]string friendId, [FromBody]UpdateFriendDraftParameters body);
    }
}
