using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitApp.Core.Models;
using XUnitApp.Core.Processors;

namespace XUnit.Core.Tests
{
    public class BookingRequestProcessorTest
	{
		private BookingRequestProcessor _processor;

		// REQUIREMENTS
		// when a methjod is being called to process a booking
		// we expect a certain answer with all the booking details included

		public BookingRequestProcessorTest() 
		{
			_processor = new BookingRequestProcessor();
		}

		[Fact]
		public void Should_Return_Booking_Response_With_Details()
		{
			// ARRANGE
			var request = new BookingRequest
			{
				FullName = "Test name",
				Email = "test@gmail.com",
				DateOnly = new DateTime(2023, 12, 10)
			};

			// processor to handle the request
			// var processor = new BookingRequestProcessor();

			// ACT
			// method for processing the request
			BookingResult result = _processor.Book(request);

			// ASSERT
			Assert.NotNull(result);

			Assert.Equal(request.FullName, result.FullName);
			Assert.Equal(request.Email, result.Email);
			Assert.Equal(request.DateOnly, result.DateOnly);
		}
		[Fact]
		public void Should_Throw_Exception_For_Null_Request()
		{
			//var processor = new BookingRequestProcessor();

			var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null!));

			exception.ParamName.Equals("xxxrequest");
		}
	}	
}
