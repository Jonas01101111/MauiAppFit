using MauiAppFit.Helpers;

namespace MauiAppFit
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper database;

        public static SQLiteDataBaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteDataBaseHelper(
                        Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                            "AppFit.db3"));
                    
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}