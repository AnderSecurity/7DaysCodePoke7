using Pokemon7DaysCode.Poke7.Models;

namespace Pokemon7DaysCode.Poke7.Menus
{
    internal abstract class Menu:IMenu
    {
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public User? UserLogged { get; set; }

        public Menu()
        {
        }
        public Menu(User userLogged)
        {
            UserLogged = userLogged;
        }

        public Menu(string title, string subTitle)
        {
            this.Title = title;
            this.SubTitle = subTitle;
        }

        public virtual void ShowMenu() {
            Console.Clear();
            Console.WriteLine(this.Title);
            Console.WriteLine(this.SubTitle);
        }
        public abstract void MenuFunc();
    }
}
