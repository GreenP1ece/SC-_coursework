namespace ManagerBuildApp.BLL
{
    public static class SessionManager
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUserRole { get; set; }

        public static string CurrentUserName { get; set; }
    }
}
