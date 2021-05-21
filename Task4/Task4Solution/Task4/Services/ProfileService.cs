using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task4.Models;

namespace Task4.Services
{
    public class ProfileService : IProfile<Profile>
    {
        private ProfileContext _context;
        private ILogger<ProfileService> _logger;

        public ProfileService(ProfileContext context, ILogger<ProfileService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(Profile t)
        {
            try
            {
                _context.profiles.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                throw;
            }
        }

        public Profile Get(int id)
        {
            try
            {
                Profile profile = _context.profiles.FirstOrDefault(a => a.Id == id);
                return profile;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<Profile> GetAll()
        {
            try
            {
                if (_context.profiles.Count() == 0)
                    return null;
                return _context.profiles.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
    }
}
