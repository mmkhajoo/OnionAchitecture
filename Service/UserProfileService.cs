﻿using Data;
using Repo;

namespace Service
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> _userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return _userProfileRepository.Get(id);
        }
    }
}