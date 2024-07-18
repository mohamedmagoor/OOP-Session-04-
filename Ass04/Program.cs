using Ass04.Interfaces;
using System;
using System.Data;
using System.Net;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part01

            #region What is the primary purpose of an interface in C#?

            // c) To declare abstract methods and properties

            #endregion
            #region Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private

            #endregion
            #region Can an interface contain fields in C#?

            // b) No

            #endregion
            #region In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion
            #region Which keyword is used to implement an interface in a class in C#?
            //c) extends


            #endregion
            #region Can an interface contain static methods in C#?
            // a) Yes


            #endregion
            #region In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public


            #endregion
            #region What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members


            #endregion
            #region In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors



            #endregion
            #region How can a C# class implement multiple interfaces?

            //c) By separating interface names with commas

            #endregion



            //Part..02


            #region Question 01:Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            /* Circle circle = new Circle();
             circle.Area = 10;
             circle.DisplayShapeInfo();
             Console.WriteLine("######################3");
             Rectangle rectangle = new Rectangle();
             rectangle.Area = 500;
             rectangle.DisplayShapeInfo();*/


            #endregion


            #region Question 02:In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

           /* BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();
            basicAuthenticationService.AuthenticateUser("mohamed", "012457");*/


            #endregion

            #region we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters. We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.In each implementation, we provide the logic to send notifications through the respective communication channel:The EmailNotificationService class simulates sending an email by outputting a message to the console.The SmsNotificationService class simulates sending an SMS by outputting a message to the console.The PushNotificationService class simulates sending a push notification by outputting a message to the console.In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.
            /*INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("email@example.com", "This is an email notification.");
            smsService.SendNotification("1234567890", "This is an SMS notification.");
            pushService.SendNotification("user123", "This is a push notification.");




            */
            #endregion

        }
}
}
