using System;
using System.Collections.Generic;

public enum UserRole
{
    SuperUser,
    User
}

public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}

public class Proxy : ISubject
{
    private RealSubject _realSubject;
    private UserRole _userRole;

    public Proxy(UserRole userRole)
    {
        _userRole = userRole;
    }

    public void Request()
    {
        if (_userRole == UserRole.SuperUser)
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy: Logging the time of request.");
            _realSubject.Request();
        }
        else
        {
            Console.WriteLine("Proxy: Access denied. Insufficient permissions.");
        }
    }
}

class Program
{
    private static Dictionary<string, UserRole> registeredUsers = new Dictionary<string, UserRole>();

    static void Main()
    {
        Console.WriteLine("Register a new user");
        while (true)
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your role (SuperUser/User): ");
            string roleInput = Console.ReadLine();
            if (Enum.TryParse(roleInput, true, out UserRole role))
            {
                registeredUsers.Add(username, role);
                Console.WriteLine($"Successfully registered {username} as {role}.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid role. Please enter 'SuperUser' or 'User'.");
            }
        }

        Console.WriteLine("\nPlease login:");
        while (true)
        {
            Console.Write("Enter your username: ");
            string loginUsername = Console.ReadLine();

            if (registeredUsers.TryGetValue(loginUsername, out UserRole registeredRole))
            {
                Console.WriteLine($"Successfully logged in as {loginUsername} with role {registeredRole}.");
                ISubject user = new Proxy(registeredRole);
                user.Request();
                break;
            }
            else
            {
                Console.WriteLine("Login failed. Username not found.");
            }
        }
    }
}
