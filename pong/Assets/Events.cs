public static class Events
{
    //id_user, puntos
    public static System.Action<int, int> OnAddScore = delegate { };
    public static System.Action<UserData> ChangePlayer = delegate { };
}
