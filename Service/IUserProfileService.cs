using Data;

namespace Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);  
    }
}