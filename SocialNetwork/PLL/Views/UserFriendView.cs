using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья");


            if (friends.Count() == 0)
            {
                Console.WriteLine("Список друзей пуст");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine($"Email друга: {friend.Email}. Имя и фамилия друга: {friend.FirstName} {friend.LastName}");
            });

            }

        }
}

