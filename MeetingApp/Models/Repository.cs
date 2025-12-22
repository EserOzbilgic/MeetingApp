namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo>_users = new();

        static Repository() {
            _users.Add(new UserInfo()
            {
                Name = "Alice",
                Phone = "123-456-7890",
                Email = "alice@example.com",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Name = "Bob",
                Phone = "987-654-3210",
                Email = "bob@example.com",
                WillAttend = false
            });

            _users.Add(new UserInfo()
            {
                Name = "Charlie",
                Phone = "555-555-5555",
                Email = "charlie@example.com",
                WillAttend = true
            });
        }
        
        public static List<UserInfo> Users{
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}