using UselessRockPaperScissors.View;

namespace UselessRockPaperScissors.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            view.Presenter = this;
        }

        public void UpdateMainView()
        {
            
        }
    }
}