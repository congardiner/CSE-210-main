using System;
using System.Runtime.CompilerServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        // added a list 

        List<Video> videos = new List<Video>();

        // test cases for each video
        Video video1 = new Video 
        {
        _title = "New Youtube Channel", 
        _author = "Avid Martian Hunter",
        _length = 90 
        };

        Video video2 = new Video 
        {
        _title = "Crosslinking Explained",
        _author = "Science Everyday",
        _length = 156 
        };

        Video video3 = new Video
        {
        _title = "Jedi Acolyte: Feast or Famine?",
        _author = "Grey Jedi Confirmed",
        _length = 527,
        };

        // Now I can incorporate my comments into the video list that I created!

        video1.AddComments (new Comment { _personName = "SolderCatBoy11", _personComment = "Nice video, great explanation!" } );
        video1.AddComments (new Comment { _personName = "BuiltIt", _personComment = "I build those pyramids! Not those aliens!"} );
        video1.AddComments (new Comment { _personName = "Martian Explorer", _personComment = "Yeah living the dream bro!"} );
        video1.AddComments (new Comment { _personName = "RadicalBro", _personComment = "See you in Area51 at the the Great Run!"} );

        video2.AddComments (new Comment { _personName = "GeneSplicer117", _personComment = "Have you tried the new method created using Gemini?"} );
        video2.AddComments (new Comment { _personName = "ScienceEveryday1234", _personComment = "Easy on the explanation, will subscribe!"} );
        video2.AddComments (new Comment { _personName = "RandomSub", _personComment = "subscribe to my new channel, I am not a bot"} );
        video2.AddComments (new Comment { _personName = "MaterialYou", _personComment = "What does this mean for cloning moving forward? Any implications?"} );


        video3.AddComments (new Comment { _personName = "JediBannerUnited", _personComment = "That is no jedi! @worstshowever"} );
        video3.AddComments (new Comment { _personName = "CanonForever", _personComment = "Not my Canon Disney!"} );
        video3.AddComments (new Comment { _personName = "WhyThoughMeme", _personComment = "Why did they do this show like this? Please why?????"} );

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // edit note: will now iterate and use my display method to showcase the three Youtube videos with names, comments, and the amount //
        foreach (var video in videos)
        {
            video.DisplayVideoDescription();
        }
    }
}