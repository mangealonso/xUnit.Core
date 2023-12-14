using XUnitApp.Core.Models;

namespace XUnitApp.Core.Processors
{
    public class BookingRequestProcessor
    {
        public BookingRequestProcessor()
        {
        }

        public BookingResult Book(BookingRequest request)
        {

            if (request == null) throw new ArgumentNullException(nameof(request));

            return new BookingResult
            {
                FullName = request.FullName,
                Email = request.Email,
                DateOnly = request.DateOnly
            };
        }
    }
}