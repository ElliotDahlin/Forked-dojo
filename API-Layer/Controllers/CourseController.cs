﻿using Application_Layer.Commands.CourseCommands.DeleteCourse;
using Application_Layer.Queries.CourseQueries.GetCourseById;
using Application_Layer.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCourseById/{courseId}")]
        public async Task<IActionResult> GetCourseById(string courseId)
        {
            var user = await _mediator.Send(new GetCourseByIdQuery(courseId));

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound($"Course with ID {courseId} was not found.");
            }
        }
        [HttpDelete("DeleteCourse/{courseId}")]
        public async Task<IActionResult> DeleteCourse(string courseId)
        {
            try
            {
                var result = await _mediator.Send(new DeleteCourseCommand(courseId));

                if (result.Success)
                {
                    return Ok(result.Message);
                }
                else
                {
                    return BadRequest(result.Message);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}