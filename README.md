# Side-Projects
This repository holds all of the projects that I have taken up as a Software Developer since graduation in 2018.
I wanted to upload these to GitHub so that it can become a sort of portfolio for employers to look at. Most of
this is ongoing projects that have been deployed to the people that requested them, however I know they still
need work to fine tune them. I know that most if not all of these are not very efficient and that is one of the
next steps for me to take while I work on these.

# MEDIA MINITRY MANAGER
This project is the Desktop Application that I created for someone that way they could manage their side business
of selling their media ministry products. They sell things like sermon CDs, study guides, and other things like that.
The next step for this project is to fine tune the performance of the application. There are moments when using this
application when it will stutter. I know that it is because of the way that I am handling the database calls. One
solution to this could be to learn how async functions work in VB.NET and seeing if that can help with the performance.
Currently the application just makes the calls on the same thread as the application itself, slowing down the application
at times. Another thing I could try is maybe looking at using a different language entirely. Some of the performance issues
could be stemming from the language choice. Of course I'm sure it's the former more than the latter, since VB.NET is a common
business language when it comes to making applications.

# MEDIA MINISTRY MANAGER MOBILE
This project holds the mobile version of the Media Ministry Manager App. For this project I had to make an API of my own, because
to interact with my SQL Database that I have setup on Azure, I had to have a RESTful API and there weren't any that I could have used
from online. So I made my own custom API that interacts with my tables and retrieves, updates. and deletes from tables as I needed the
mobile application to do. The next steps for the mobile app is to make the application itself look more presentable. Since this was my
first attempt at making a mobile application, the looks of the app aren't very appealing. The only reason why I didn't make it look better
than it does now is because it was for the same person as the Desktop Application and since they were the only person that was going to be
using it, I felt that the looks were secondary to functionality. With that, I focused on making the application work the way it needed to,
then I was going to go back and make it look more appealing. As stated, this was my first mobile app that I built, especially with Xamarin.Forms
and Visual Studio. Another next step would again be to fine tune the application. There are many times in using the app where nothing will be
loaded yet. I'm thinking that this is because of the way that I have the database interactions set up. This app uses async functions, however even
with that the app will still be a little slow to do things. I will have to look into ways to fine tune and speed up these interactions.

# MEDIA MINISTRY MANAGEMENT
This is my custom API that I made for my mobile app to interact with my Azure SQL Database. This was made with the help of the Microsoft API
tutorial however all of the functions are for the purpose of my application. The next steps for this project would be to make the API a little more
streamlined. I feel like there is something that can be done that make it a little more responsive, however since this was my first attempt at APIs
I will have to research on what goes into an API that will affect the performance of it.



# MEDIA MINISTRY MANAGER SETUP
This is just the project that was created to have an easier time installing the desktop application of the user's computer. Not much is in here
that I feel needs any next steps since it was just a simple installation project.

# Sender
This is the email sending program, built in Java. This handles the email ministry functionality of the software.
