using System;
using System.Windows.Controls;

namespace Package_Manager.View
{
    public class MainContentView: ViewModelBase
    {
        private readonly Action<UserControl> navigateToView;
       
        public MainContentView(Action<UserControl> navigateToView)
        {
            this.navigateToView = navigateToView;
            Initializate();
        }

    

        private void Initializate()
        {
            var loginControl = new LoginControl();

            navigateToView(loginControl);


            
        }

    }
}
