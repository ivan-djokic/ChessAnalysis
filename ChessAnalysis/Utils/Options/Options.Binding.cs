using System.Linq.Expressions;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
    public partial class Options
    {
        private readonly Lazy<MVVMContextFluentAPI<OptionsBindModel>> m_binding;
        private readonly OptionsBindModel m_optionsModel = new();

        private Options()
        {
            m_binding = new(() => CreateBinding());
        }

        public static Action<bool> BoardOptionsChanged;

        private MVVMContextFluentAPI<OptionsBindModel> Binding
        {
            get => m_binding.Value;
        }

        public void Bind(CheckEdit control, Expression<Func<OptionsBindModel, bool>> expression)
        {
            Binding.SetBinding(control, c => c.Checked, expression);
        }

        public void Bind(ColorPickEdit control, Expression<Func<OptionsBindModel, Color>> expression)
        {
            Binding.SetBinding(control, c => c.Color, expression);
        }

        public void Bind(TextEdit control, Expression<Func<OptionsBindModel, string>> expression)
        {
            Binding.SetBinding(control, c => c.EditValue, expression);
        }

        private MVVMContextFluentAPI<OptionsBindModel> CreateBinding()
        {
            var context = new MVVMContext();
            context.SetViewModel(typeof(OptionsBindModel), m_optionsModel);
            return context.OfType<OptionsBindModel>();
        }

        private void RaiseOnChange()
        {
            m_optionsModel.RaisePropertiesChanged();
            //TODO: Invoke language changer here
            BoardOptionsChanged?.Invoke(false);
            Theming.ApplyTheme();
        }
    }
}
