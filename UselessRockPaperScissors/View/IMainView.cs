using UselessRockPaperScissors.Model;

namespace UselessRockPaperScissors.View
{
    public interface IMainView
    {
        Weapon Weapon { get; set; }
        
        Presenter.MainPresenter Presenter { set; }
    }
}