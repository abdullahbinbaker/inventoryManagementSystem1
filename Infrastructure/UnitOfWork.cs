using Core.Interfaces;
//using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _context;

        //public UnitOfWork(DataContext context)
        //{
        //    _context = context;
        //    Employees = new EmployeeRepository(_context);
        //    Logins = new LoginRepository(_context);
        //    Holidays = new HolidayRepository(_context);
        //    RefreshTokens = new RefreshTokenRepository(_context);
        //}

        //public EmployeeRepository Employees { get; private set; }

        //public LoginRepository Logins { get; private set; }

        //public HolidayRepository Holidays { get; private set; }

        //public RefreshTokenRepository RefreshTokens { get; private set; }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
