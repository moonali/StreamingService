using StreamingService.Models;
using StreamingService.Repositories;
using StreamingService.Repositories.Interface;
using System;
using System.Collections.Generic;

namespace StreamingService.Services
{
    public class UserService
    {
        public bool Subscribe(string emailAddress, Guid subscriptionId)
        {
            var _user = new UserRepository();
            var _subscriptionReposotory = new SubscriptionRepository();

            Console.WriteLine(string.Format("Log: Start add user with email '{0}'", emailAddress));

            if (string.IsNullOrWhiteSpace(emailAddress) && _user.UserExist(emailAddress))
            {
                return false;
            }


            var subscrition = _subscriptionReposotory.getSubscriptionById(subscriptionId);

            if (subscrition.Package == Packages.Freemium)
            {
                _user.RemainingSongsThisMonth  = RemaintingSong(3);
            }

            else if (subscrition.Package == Packages.Premium)
            {
                _user.RemainingSongsThisMonth = RemaintingSong(3 * 5);
            }
            else if (subscrition.Package == Packages.Unlimitted)
            {
                return true;
            }

            Console.WriteLine(string.Format("Log: End add user with email '{0}'", emailAddress));

            return true;
        }

        public int RemaintingSong(int totalSong)
        {
            return totalSong;
        }

    }



}
