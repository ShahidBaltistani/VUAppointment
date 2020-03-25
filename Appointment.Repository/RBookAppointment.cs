using Appointment.Database;
using Appointment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Repository
{
    public class RBookAppointment : IBookAppointment
    {
        private readonly AppointmentDBContext context;
        public RBookAppointment(AppointmentDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<BookAppointment>> GetAll()
        {
            return await context.Appointments.ToListAsync();
        }

        public async Task<BookAppointment> Get(int Id)
        {
            return await context.Appointments.FindAsync(Id);
        }

        public async Task<BookAppointment> Add(BookAppointment appointment)
        {
            await context.Appointments.AddAsync(appointment);
            await context.SaveChangesAsync();
            return appointment;
        }

        public async Task<BookAppointment> Delete(int id)
        {
            BookAppointment customer = await context.Appointments.FindAsync(id);
            if (customer != null)
            {
                context.Appointments.Remove(customer);
                await context.SaveChangesAsync();
            }
            return customer;
        }

        public async Task<BookAppointment> Update(BookAppointment appointmentChanges)
        {
            var customer = context.Appointments.Attach(appointmentChanges);
            customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
            return appointmentChanges;
        }
    }
}
