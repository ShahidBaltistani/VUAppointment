using Appointment.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appointment.Repository
{
    public interface IBookAppointment
    {
        Task<BookAppointment> Get(int Id);
        Task<IEnumerable<BookAppointment>> GetAll();
        Task<BookAppointment> Add(BookAppointment customer);
        Task<BookAppointment> Update(BookAppointment customerChanges);
        Task<BookAppointment> Delete(int id);
    }
}
