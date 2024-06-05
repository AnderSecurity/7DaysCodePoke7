using Pokemon7DaysCode.Poke7.Models;

namespace Pokemon7DaysCode.Poke7.Menus
{
    internal interface IMenu
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        void ShowMenu();
        void MenuFunc();
    }
}
