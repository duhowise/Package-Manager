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

    

        public void Initializate()
        {
            var loginControl = new LoginControl();
            navigateToView(loginControl);    
        }

        public void NavigateToNewPackageControl()
        {
            var newPackageControl = new NewPackageControl();
            navigateToView(newPackageControl);

        }

        public void NavigateToExplorePackageControl()
        {
            var viewPackagesControl = new ViewPackagesControl();
            navigateToView(viewPackagesControl);
        }
    }
}
