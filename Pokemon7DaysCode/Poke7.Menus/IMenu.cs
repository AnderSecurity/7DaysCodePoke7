namespace Pokemon7DaysCode.Menus
{
    internal interface IMenu
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        void ShowMenu();
        void MenuFunc();
    }
}
