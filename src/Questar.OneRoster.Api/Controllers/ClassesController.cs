namespace Questar.OneRoster.Api.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("ims/oneroster/v1p1/classes")]
    public class ClassesController : Controller
    {
        /// <summary>
        /// Returns the collection of classes.
        /// </summary>
        [HttpGet]
        public object GetAllClasses() => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of line items (columns) in the gradebook for this class.
        /// </summary>
        [HttpGet("{classId}/lineItems")]
        public object GetLineItemsForClass(Guid classId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of results (assessed grades) for this specific line item (column) for this class.
        /// </summary>
        [HttpGet("{classId}/lineItems/{lineItemId}/results")]
        public object GetResultsForLineItemForClass(Guid classId, Guid lineItemId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of resources associated to this class.
        /// </summary>
        [HttpGet("{classId}/resources")]
        public object GetResourcesForClass(Guid classId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of results (assessed grades) for this class.
        /// </summary>
        [HttpGet("{classId}/results")]
        public object GetResultsForClass(Guid classId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of students who are taking this class.
        /// </summary>
        [HttpGet("{classId}/students")]
        public object GetStudentsForClass(Guid classId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of results (assessed grades) for this specific student attending this class.
        /// </summary>
        [HttpGet("{classId}/students/{studentId}/results")]
        public object GetResultsForStudentForClass(Guid classId, Guid studentId) => throw new NotImplementedException();

        /// <summary>
        /// Returns the collection of teachers who are teaching this class.
        /// </summary>
        [HttpGet("{classId}/teachers")]
        public object GetTeachersForClass(Guid classId) => throw new NotImplementedException();

        /// <summary>
        /// Returns a specific class by identifier.
        /// </summary>
        [HttpGet("{classId}")]
        public object GetClass(Guid classId) => throw new NotImplementedException();
    }
}