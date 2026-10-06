using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _201_Assignment2;

// Program.cs
// -------------


{
    # region Domain Objects

    /// <summary>
    /// Represents the abstract base class for all types of users.
    /// </summary>
    abstract class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        /// <summary>Stores the user's password in plain text for demo purposes.</summary>
        internal string Password { get; set; }

        protected User(string name, int age, string email, string mobile, string password)
        {
            Name = name;
            Age = age;
            Email = email;
            MobileNumber = mobile;
            Password = password;
        }
    }

    /// <summary>
    /// Listener can be a regular user or a premium subscriber.
    /// Premium listeners get special perks (not implemented here).
    /// </summary>
    class Listener : User
    {
        public bool IsPremium { get; set; }

        public Listener(string name, int age, string email, string mobile, string password, bool premium = false)
            : base(name, age, email, mobile, password)
        {
            IsPremium = premium;
        }
    }

    /// <summary>
    /// A person who produces podcasts.
    /// </summary>
    class Podcaster : User
    {
        public List<PodcastEpisode> Episodes { get; } = new List<PodcastEpisode>();

        public Podcaster(string name, int age, string email, string mobile, string password)
            : base(name, age, email, mobile, password)
        {
        }
    }

    /// <summary>
    /// Represents a single podcast episode.
    /// </summary>
    class PodcastEpisode
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedOn { get; set; }
        public TimeSpan Length { get; set; }

        public PodcastEpisode(string title, string description, DateTime releasedOn, TimeSpan length)
        {
            Title = title;
            Description = description;
            ReleasedOn = releasedOn;
            Length = length;
        }
    }

    #endregion

    #region Repository / Simple In‑Memory Storage

    /// <summary>
    /// In‑memory data store.  Acts as a very small database.
    /// </summary>
    class Repository
    {
        public List<User> Users { get; } = new List<User>();
        public List<Podcaster> Podcasters => Users.OfType<Podcaster>().ToList();
        public List<Listener> Listeners => Users.OfType<Listener>().ToList();
    }

    #endregion

    #region Application Service Layer

    /// <summary>
    /// Core application logic handling user actions.
    /// </summary>
    class PodcastWorldService
    {
        private readonly Repository _repo;
        private User _currentUser;

        public PodcastWorldService(Repository repo)
        {
            _repo = repo;
        }

        /// <summary>Registers a new listener (optionally premium).</summary>
        public bool RegisterListener(string name, int age, string email, string mobile, string password, bool premium = false)
        {
            if (_repo.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return false; // Email already taken

            Listener ln = new Listener(name, age, email, mobile, password, premium);
            _repo.Users.Add(ln);
            return true;
        }

        /// <summary>
        /// Instantiates a podcaster.  In real systems a separate flow would be used.
        /// </summary>
        public bool RegisterPodcaster(string name, int age, string email, string mobile, string password)
        {
            if (_repo.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return false;
            Podcaster pc = new Podcaster(name, age, email, mobile, password);
            _repo.Users.Add(pc);
            return true;
        }

        /// <summary>
        /// Authenticates a user by email and password.  Returns true on success.
        /// </summary>
        public bool Authenticate(string email, string password)
        {
            var user = _repo.Users
                .FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                                     u.Password == password);
            if (user != null)
            {
                _currentUser = user;
                return true;
            }
            return false;
        }

        /// <summary>Logs the current user out.</summary>
        public void Logout()
        {
            _currentUser = null;
        }

        /// <summary>Gets the currently logged‑in user.</summary>
        public User GetCurrentUser() => _currentUser;
    }

    #endregion

    #region Console UI

    class Program
    {
        private static Repository _repo = new Repository();
        private static PodcastWorldService _service = new PodcastWorldService(_repo);

        static void Main()
        {
            Console.WriteLine("=== Welcome to PodCastWorld ===");
            while (true)
            {
                if (_service.GetCurrentUser() == null)
                    ShowMainMenu();
                else
                    ShowUserMenu();
            }
        }

        #region Menus

        private static void ShowMainMenu()
        {
            Console.WriteLine("\n1. Register as Listener");
            Console.WriteLine("2. Register as Podcaster");
            Console.WriteLine("3. Login");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine() ?? string.Empty;
            switch (input)
            {
                case "1":
                    RegisterListenerFlow();
                    break;
                case "2":
                    RegisterPodcasterFlow();
                    break;
                case "3":
                    LoginFlow();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }

        private static void ShowUserMenu()
        {
            var user = _service.GetCurrentUser();
            Console.WriteLine($"\n--- Logged in as {user.Name} ({user.GetType().Name}) ---");
            Console.WriteLine("1. View Personal Details");
            Console.WriteLine("2. Logout");
            Console.Write("Select an option: ");
            string input = Console.ReadLine() ?? string.Empty;
            switch (input)
            {
                case "1":
                    ShowPersonalDetails();
                    break;
                case "2":
                    _service.Logout();
                    Console.WriteLine("You have been logged out.");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }

        #endregion

        #region Flow Handlers

        private static void RegisterListenerFlow()
        {
            Console.WriteLine("\n--- Register Listener ---");
            var (name, age, email, mobile, password, premium) = GetUserInfo(isListener: true);
            bool success = _service.RegisterListener(name, age, email, mobile, password, premium);
            if (success)
                Console.WriteLine("Registration successful. You can now login.");
            else
                Console.WriteLine("Email already registered. Try a different one.");
        }

        private static void RegisterPodcasterFlow()
        {
            Console.WriteLine("\n--- Register Podcaster ---");
            var (name, age, email, mobile, password, _) = GetUserInfo(isListener: false);
            bool success = _service.RegisterPodcaster(name, age, email, mobile, password);
            if (success)
                Console.WriteLine("Podcaster registration successful. You can now login.");
            else
                Console.WriteLine("Email already registered. Try a different one.");
        }
    }
}