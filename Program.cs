namespace LibraryManagment.Services;
class Program
{
    public static void Main(string[] args)
    {
        HomeService homeService = new HomeService();
        homeService.LoadExistingMenus();
    }
}
