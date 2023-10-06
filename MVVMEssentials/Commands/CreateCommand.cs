using MVVMEssentials.ViewModels;
using System.Windows.Input;

namespace MVVMEssentials.Commands
{
    public delegate ICommand CreateCommand<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;
}
