namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo>_users = new();

        static Repository() {
            _users.Add(new UserInfo()
            {
                Id = 1,
                Name = "Alice",
                Phone = "123-456-7890",
                Email = "alice@example.com",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Bob",
                Phone = "987-654-3210",
                Email = "bob@example.com",
                WillAttend = false
            });

            _users.Add(new UserInfo()
            {
                Id = 3,
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
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(u => u.Id == id);
        }
    }
}