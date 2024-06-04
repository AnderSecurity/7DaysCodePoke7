namespace Pokemon7DaysCode.Menus
{
    internal abstract class Menu:IMenu
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public Menu()
        {
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
