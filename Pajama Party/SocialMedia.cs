using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajama_Party
{
    //Social Media Profile Class
    //Design a SocialMediaProfile class representing a user's profile on a social media platform. 
    //Include properties like Username, Posts, and Followers. Implement methods for adding posts, following users, and displaying the profile information.
    internal class SocialMedia
    {
        public string userName { get; set; }
        public List<string> post { get; set; }//because each user can have a list of posts
        public List<string> followers { get; set; }

        //constructor
        public SocialMedia(string _userName, List<string> _post, List<string> _followers)
        {
            userName = _userName;
            post = _post;
            followers = _followers;
        }
        //defaults

        public SocialMedia()
        {
            userName = "new user";
            post = new List<string>();
            followers = new List<string>();
        }

        //methods

        //display profile information
        public override string ToString()
        {
            return String.Format("{0,20} {1,20} {2,20}", userName, string.Join(", ", post), followers);
        }

        //add a new post
        public void AddPost(string newPost)
        {
            post.Add(newPost);
        }

        public void FollowUser(string userToFollow)
        {
            followers.Add(userToFollow);
        }


    }
}
