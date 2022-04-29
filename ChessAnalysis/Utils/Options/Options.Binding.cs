using System.Linq.Expressions;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
    public partial class Options
    {
        private readonly Lazy<MVVMContextFluentAPI<OptionsModel>> m_binding;
        private readonly OptionsModel m_optionsModel = new();

        private Options()
        {
            m_binding = new(() => CreateBinding());
        }

        public static Action? BoardOptionsChanged;

        private MVVMContextFluentAPI<OptionsModel> Binding
        {
            get => m_binding.Value;
        }

        public void Bind(CheckEdit control, Expression<Func<OptionsModel, bool>> expression)
        {
            Binding.SetBinding(control, c => c.Checked, expression);
        }

        public void Bind(ColorPickEdit control, Expression<Func<OptionsModel, Color>> expression)
        {
            Binding.SetBinding(control, c => c.Color, expression);
        }

        public void Bind(TextEdit control, Expression<Func<OptionsModel, string>> expression)
        {
            Binding.SetBinding(control, c => c.EditValue, expression);
        }

        private MVVMContextFluentAPI<OptionsModel> CreateBinding()
        {
            var context = new MVVMContext();
            context.SetViewModel(typeof(OptionsModel), m_optionsModel);
            return context.OfType<OptionsModel>();
        }

        private void RaisePropertiesChanged(bool raisePropertiesChanged)
        {
            if (!raisePropertiesChanged)
            {
                return;
            }

            m_optionsModel.RaisePropertiesChanged();
            BoardOptionsChanged?.Invoke();
        }
    }
}
